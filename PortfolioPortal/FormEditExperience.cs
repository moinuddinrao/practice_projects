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
	public partial class FormEditExperience : Form
	{
		private ExperienceBLL _experienceBLL;
		public FormEditExperience()
		{
			InitializeComponent();
			_experienceBLL = new ExperienceBLL();
		}

		private void buttonAddExperience_Click(object sender, EventArgs e)
		{
			ExperienceVO _experienceVO = new ExperienceVO();

			if (textBoxJobTitle.Text != string.Empty)
			{
				_experienceVO.Jobtitle = textBoxJobTitle.Text;
			}
			else
			{
				MessageBox.Show("Job Title can not be empty");
			}
			if (textBoxWorkplace.Text != string.Empty)
			{
				_experienceVO.Workplace = textBoxWorkplace.Text;
			}
			else
			{
				MessageBox.Show("Workplace can not be empty");
			}
			if (textBoxYearFrom.Text != string.Empty)
			{
				_experienceVO.Yearfrom = textBoxYearFrom.Text;
			}
			else
			{
				MessageBox.Show("Start Year can not be empty");
			}
			if (textBoxYearTo.Text != string.Empty)
			{
				_experienceVO.Yearto = textBoxYearTo.Text;
			}
			else
			{
				MessageBox.Show("End Year can not be empty");
			}

			bool flag = _experienceBLL.AddUserExperience(_experienceVO);

			if (flag)
			{
				MessageBox.Show("Experience added successfully!");
			}
			else
			{
				MessageBox.Show("Experience can not be added. Tryagain!");
			}
		}
	}
}
