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
    public partial class FormViewExperience : Form
    {
        private ExperienceBLL _experienceBLL;
        public FormViewExperience()
        {
            InitializeComponent();
            _experienceBLL = new ExperienceBLL();
        }

		private void FormViewExperience_Load(object sender, EventArgs e)
		{
            ExperienceVO _experienceVO = new ExperienceVO();
            dataGridView1.DataSource = _experienceBLL.GetUserExperience(_experienceVO);
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            ExperienceVO _experienceVO = new ExperienceVO();
            dataGridView1.DataSource = _experienceBLL.GetUserExperience(_experienceVO);
        }
	}
}
