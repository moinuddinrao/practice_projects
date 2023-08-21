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
	public partial class FormEditLink : Form
	{
		private LinkBLL _linkBLL;
		public FormEditLink()
		{
			InitializeComponent();
			_linkBLL = new LinkBLL();
		}

		private void buttonAddLink_Click(object sender, EventArgs e)
		{
			LinkVO _linkVO = new LinkVO();

			if (textBoxLinkedIn.Text != string.Empty)
			{
				_linkVO.Linkedin = textBoxLinkedIn.Text;
			}
			if (textBoxResearchGate.Text != string.Empty)
			{
				_linkVO.Researchgate = textBoxResearchGate.Text;
			}
			if (textBoxGoogleScholar.Text != string.Empty)
			{
				_linkVO.Googlescholar = textBoxGoogleScholar.Text;
			}

			bool flag = _linkBLL.AddUserLink(_linkVO);

			if (flag)
			{
				MessageBox.Show("Links added successfully!");
			}
			else
			{
				MessageBox.Show("Links can not be added. Tryagain!");
			}
		}
	}
}
