using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortfolioPortal.BLL;
using PortfolioPortal.VO;

namespace PortfolioPortal
{
    public partial class FormTemplateCV : Form
    {
        private UserBLL _userBLL;
        private EducationBLL _educationBLL;
        private ExperienceBLL _experienceBLL;
        private ProjectBLL _projectBLL;
        public FormTemplateCV()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _educationBLL = new EducationBLL();
            _experienceBLL = new ExperienceBLL();
            _projectBLL = new ProjectBLL();
        }

        private void FormTemplateCV_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            UserVO _userVO = new UserVO();
            EducationVO _educationVO = new EducationVO();
            dataGridViewEducation.DataSource = _educationBLL.GetUserEducation(_educationVO);
            ExperienceVO _experienceVO = new ExperienceVO();
            dataGridViewJob.DataSource = _experienceBLL.GetUserExperience(_experienceVO);
            ProjectVO _projectVO = new ProjectVO();
            dataGridViewProject.DataSource = _projectBLL.GetUserProject(_projectVO);

            labelPersonName.Text = _userBLL.GetUserName(_userVO);
            labelPersonJob.Text = _userBLL.GetUserJobTitle(_userVO);
        }
	}
}
