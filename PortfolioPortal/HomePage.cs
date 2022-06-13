using System;
using System.Windows.Forms;
using PortfolioPortal.BLL;
using PortfolioPortal.VO;
using System.Diagnostics;

namespace PortfolioPortal
{
	public partial class HomePage : Form
	{
        private UserBLL _userBLL;
        private LinkBLL _linkBLL;
        public HomePage()
		{
			InitializeComponent();
            _userBLL = new UserBLL();
            _linkBLL = new LinkBLL();
            openChildForm(new FormViewProfile());
		}
        private void HomePage_Load(object sender, EventArgs e)
        {
            UserVO _userVO = new UserVO();
            labelFullName.Text = _userBLL.GetUserName(_userVO);
            labelWelcomeUserName.Text = "Welcome " + _userBLL.GetUserName(_userVO) + " |";
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewProfile());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login form1 = new Login();
			form1.ShowDialog();
		}

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewProfile());
        }

        private void buttonEducation_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewEducation());
        }

        private void buttonCertification_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewCertification());
        }

        private void buttonExperience_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewExperience());
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewProjects());
        }

		private void buttonPublications_Click(object sender, EventArgs e)
		{
            openChildForm(new FormViewPublications());
		}

		private void buttonEditPortfolio_Click(object sender, EventArgs e)
		{
            openChildForm(new FormEditPortfolio());
        }

		private void buttonLinkedIn_Click(object sender, EventArgs e)
		{
            LinkVO _linkVO = new LinkVO();
            string _string = _linkBLL.GetUserLinkedIn(_linkVO);
            if (_string != string.Empty)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(_string);
                Process.Start(sInfo);
                MessageBox.Show("Opening link!");
            }
        }

		private void buttonResearchGate_Click(object sender, EventArgs e)
		{
            LinkVO _linkVO = new LinkVO();
            string _string = _linkBLL.GetUserResearchGate(_linkVO);
            if (_string != string.Empty)
			{
                ProcessStartInfo sInfo = new ProcessStartInfo(_string);
                Process.Start(sInfo);
                MessageBox.Show("Opening link!");
            }
        }

		private void buttonGoogleScholar_Click(object sender, EventArgs e)
		{
            LinkVO _linkVO = new LinkVO();
            string _string = _linkBLL.GetUserGoogleScholar(_linkVO);
            if (_string != string.Empty)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(_string);
                Process.Start(sInfo);
                MessageBox.Show("Opening link!");
            }
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            FormTemplateCV form1 = new FormTemplateCV();
            form1.ShowDialog();
        }
    }
}
