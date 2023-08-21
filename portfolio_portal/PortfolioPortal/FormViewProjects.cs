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
    public partial class FormViewProjects : Form
    {
        private ProjectBLL _projectBLL;
        public FormViewProjects()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
        }
        private void FormViewProjects_Load(object sender, EventArgs e)
        {
            
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            ProjectVO _projectVO = new ProjectVO();
            dataGridView1.DataSource = _projectBLL.GetUserProject(_projectVO);
        }
	}
}
