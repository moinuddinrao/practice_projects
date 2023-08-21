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
    public partial class FormViewPublications : Form
    {
        private PublicationBLL _publicationBLL;
        public FormViewPublications()
        {
            InitializeComponent();
            _publicationBLL = new PublicationBLL();
        }

		private void FormViewPublications_Load(object sender, EventArgs e)
		{
            
        }

		private void buttonView_Click(object sender, EventArgs e)
		{
            PublicationVO _publicationVO = new PublicationVO();
            dataGridView1.DataSource = _publicationBLL.GetUserPublication(_publicationVO);
        }
	}
}
