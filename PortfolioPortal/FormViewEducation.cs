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
    public partial class FormViewEducation : Form
    {
        private EducationBLL _educationBLL;
        public FormViewEducation()
        {
            InitializeComponent();
            _educationBLL = new EducationBLL();
        }

		private void FormViewEducation_Load(object sender, EventArgs e)
		{
            
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            EducationVO _educationVO = new EducationVO();
            dataGridView1.DataSource = _educationBLL.GetUserEducation(_educationVO);
        }
	}
}
