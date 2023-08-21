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
	public partial class FormEditPublication : Form
	{
		private PublicationBLL _publicationBLL;
		
		public FormEditPublication()
		{
			InitializeComponent();
			_publicationBLL = new PublicationBLL();
		}

		private void buttonAddPublication_Click(object sender, EventArgs e)
		{
			PublicationVO _publicationVO = new PublicationVO();

			if (textBoxTitle.Text != string.Empty)
			{
				_publicationVO.Title = textBoxTitle.Text;
			}
			else
			{
				MessageBox.Show("Title can not be empty");
			}
			if (textBoxJournal.Text != string.Empty)
			{
				_publicationVO.Journal = textBoxJournal.Text;
			}
			else
			{
				MessageBox.Show("Must write Journal name");
			}
			if (textBoxAuthor.Text != string.Empty)
			{
				_publicationVO.Author = textBoxAuthor.Text;
			}
			else
			{
				MessageBox.Show("Must write Author name");
			}
			if (textBoxPublicationYear.Text != string.Empty)
			{
				_publicationVO.Publicationyear = int.Parse(textBoxPublicationYear.Text);
			}
			else
			{
				MessageBox.Show("Must write Publication year");
			}
			if (textBoxDetails.Text != string.Empty)
			{
				_publicationVO.Details = textBoxDetails.Text;
			}
			if (textBoxURL.Text != string.Empty)
			{
				_publicationVO.Url = textBoxURL.Text;
			}

			bool flag = _publicationBLL.AddUserPublication(_publicationVO);

			if (flag)
			{
				MessageBox.Show("Publication added successfully!");
			}
			else
			{
				MessageBox.Show("Publication can not be added. Tryagain!");
			}
		}
	}
}
