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
    public partial class FormViewCertification : Form
    {
        private CertificationBLL _certificationBLL;
        public FormViewCertification()
        {
            InitializeComponent();
            _certificationBLL = new CertificationBLL();
        }

		private void FormViewCertification_Load(object sender, EventArgs e)
		{
            
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            CertificationVO _certificationVO = new CertificationVO();
            dataGridView1.DataSource = _certificationBLL.GetUserCertification(_certificationVO);
        }
	}
}
