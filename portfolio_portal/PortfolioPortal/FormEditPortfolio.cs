using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioPortal
{
	public partial class FormEditPortfolio : Form
	{
		public FormEditPortfolio()
		{
			InitializeComponent();
		}

		private void buttonEditPersonalInfo_Click(object sender, EventArgs e)
		{
			FormEditProfile form = new FormEditProfile();
			form.ShowDialog();
		}

		private void buttonEditEducation_Click(object sender, EventArgs e)
		{
			FormEditEducation form = new FormEditEducation();
			form.ShowDialog();
		}

		private void buttonEditCertifications_Click(object sender, EventArgs e)
		{
			FormEditCertification form = new FormEditCertification();
			form.ShowDialog();
		}

		private void buttonEditExperience_Click(object sender, EventArgs e)
		{
			FormEditExperience form = new FormEditExperience();
			form.ShowDialog();
		}

		private void buttonEditProjects_Click(object sender, EventArgs e)
		{
			FormEditProject form = new FormEditProject();
			form.ShowDialog();
		}

		private void buttonEditPublications_Click(object sender, EventArgs e)
		{
			FormEditPublication form = new FormEditPublication();
			form.ShowDialog();
		}

		private void buttonEditSocialLinks_Click(object sender, EventArgs e)
		{
			FormEditLink form = new FormEditLink();
			form.ShowDialog();
		}
	}
}
