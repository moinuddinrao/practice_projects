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
	public partial class FormEditCertification : Form
	{
		private CertificationBLL _certificationBLL;
		public FormEditCertification()
		{
			InitializeComponent();
			_certificationBLL = new CertificationBLL();
		}

		private void buttonAddCertification_Click(object sender, EventArgs e)
		{
			CertificationVO _certificationVO = new CertificationVO();

			if (textBoxCertificateTitle.Text != string.Empty)
			{
				_certificationVO.Certificatetitle = textBoxCertificateTitle.Text;
			}
			else
			{
				MessageBox.Show("Certificate Title can not be empty");
			}
			if (textBoxCertificateProvider.Text != string.Empty)
			{
				_certificationVO.Certificateprovider = textBoxCertificateProvider.Text;
			}
			else
			{
				MessageBox.Show("Certificate Provider can not be empty");
			}
			if (textBoxCertificationYear.Text != string.Empty)
			{
				_certificationVO.Certificationyear = int.Parse(textBoxCertificationYear.Text);
			}
			else
			{
				MessageBox.Show("Certification Year can not be empty");
			}

			bool flag = _certificationBLL.AddUserCertification(_certificationVO);

			if (flag)
			{
				MessageBox.Show("Certificate added successfully!");
			}
			else
			{
				MessageBox.Show("Certificate can not be added. Tryagain!");
			}
		}
	}
}
