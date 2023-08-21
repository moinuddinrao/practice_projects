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
    public partial class FormViewProfile : Form
    {
        private UserBLL _userBLL;
        private EducationBLL _educationBLL;
        private CertificationBLL _certificateBLL;
        private ExperienceBLL _experienceBLL;
        private ProjectBLL _projectBLL;
        private PublicationBLL _publicationBLL;
        public FormViewProfile()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _educationBLL = new EducationBLL();
            _certificateBLL = new CertificationBLL();
            _experienceBLL = new ExperienceBLL();
            _projectBLL = new ProjectBLL();
            _publicationBLL = new PublicationBLL();
        }

		private void FormViewProfile_Load(object sender, EventArgs e)
		{
            UserVO _userVO = new UserVO();
            labelProfileName.Text = _userBLL.GetUserName(_userVO);
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            UserVO _userVO = new UserVO();
            labelDesignation.Text = _userBLL.GetUserJobTitle(_userVO);

            dataGridViewProfile.DataSource = _userBLL.GetUserInfo(_userVO);
            dataGridViewProfile.ClearSelection();
            EducationVO _educationVO = new EducationVO();
            dataGridViewEducation.DataSource = _educationBLL.GetUserEducation(_educationVO);
            CertificationVO _certificationVO = new CertificationVO();
            dataGridViewCertificate.DataSource = _certificateBLL.GetUserCertification(_certificationVO);
            ExperienceVO _experienceVO = new ExperienceVO();
            dataGridViewJob.DataSource = _experienceBLL.GetUserExperience(_experienceVO);
            ProjectVO _projectVO = new ProjectVO();
            dataGridViewProject.DataSource = _projectBLL.GetUserProject(_projectVO);
            PublicationVO _publicationVO = new PublicationVO();
            dataGridViewPublication.DataSource = _publicationBLL.GetUserPublication(_publicationVO);
        }
	}
}
