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
	public partial class FormEditEducation : Form
	{
		private EducationBLL _educationBLL;
		public FormEditEducation()
		{
			InitializeComponent();
			_educationBLL = new EducationBLL();
		}

		private void buttonAddEducation_Click(object sender, EventArgs e)
		{
			EducationVO _educationVO = new EducationVO();

			if (textBoxDegreeTitle.Text != string.Empty)
			{
				_educationVO.Degreetitle = textBoxDegreeTitle.Text;
			}
			else
			{
				MessageBox.Show("Degree Title can not be empty");
			}
			if (textBoxSpecialization.Text != string.Empty)
			{
				_educationVO.Specialization = textBoxSpecialization.Text;
			}
			else
			{
				MessageBox.Show("Specialization can not be empty");
			}
			if (textBoxInstitute.Text != string.Empty)
			{
				_educationVO.Institute = textBoxInstitute.Text;
			}
			else
			{
				MessageBox.Show("Institute can not be empty");
			}
			if (textBoxPassingYear.Text != string.Empty)
			{
				_educationVO.Passingyear = int.Parse(textBoxPassingYear.Text);
			}
			else
			{
				MessageBox.Show("Passing Year can not be empty");
			}

			bool flag = _educationBLL.AddUserEduaction(_educationVO);

			if (flag)
			{
				MessageBox.Show("Education added successfully!");
			}
			else
			{
				MessageBox.Show("Education can not be added. Tryagain!");
			}
		}
	}
}
