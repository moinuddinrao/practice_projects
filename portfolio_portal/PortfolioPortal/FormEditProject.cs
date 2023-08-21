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
	public partial class FormEditProject : Form
	{
		private ProjectBLL _projectBLL;
		public FormEditProject()
		{
			InitializeComponent();
			_projectBLL = new ProjectBLL();
		}

		private void buttonAddProject_Click(object sender, EventArgs e)
		{
			ProjectVO _projectVO = new ProjectVO();

			if (textBoxProjectTitle.Text != string.Empty)
			{
				_projectVO.Projecttitle = textBoxProjectTitle.Text;
			}
			else
			{
				MessageBox.Show("Project Title can not be empty");
			}
			if (textBoxMembers.Text != string.Empty)
			{
				_projectVO.Members = textBoxMembers.Text;
			}
			else
			{
				MessageBox.Show("Must write members name");
			}
			if (textBoxDetails.Text != string.Empty)
			{
				_projectVO.Details = textBoxDetails.Text;
			}
			else
			{
				MessageBox.Show("Details can not be empty");
			}

			bool flag = _projectBLL.AddUserProject(_projectVO);

			if (flag)
			{
				MessageBox.Show("Project added successfully!");
			}
			else
			{
				MessageBox.Show("Project can not be added. Tryagain!");
			}
		}
	}
}
