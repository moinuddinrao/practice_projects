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
	public partial class Login : Form
	{
		private UserBLL _userBLL;
		public Login()
		{
			InitializeComponent();
			_userBLL = new UserBLL();
		}

		public bool checkData()
		{
			bool flag = true;
			if (textBoxEmail.Text == string.Empty)
			{
				MessageBox.Show("Email can not be empty.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				flag = false;
			}
			if (textBoxPassword.Text == string.Empty)
			{
				MessageBox.Show("Password can not be empty.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				flag = false;
			}
			return flag;
		}

		private void Login_Load(object sender, EventArgs e)
		{
			panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			UserVO _userVO = new UserVO();
			if (checkData())
			{
				_userVO.Email = textBoxEmail.Text;
				_userVO.Userpass = textBoxPassword.Text;
				

				bool flag = _userBLL.LoginUser(_userVO);

				if (flag)
				{
					this.Hide();
					HomePage form = new HomePage();
					form.ShowDialog();
				}
				else
				{
					MessageBox.Show("No Account avilable with this Email and Password", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("You can not be logged in. Try again.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void labelSignup_Click(object sender, EventArgs e)
		{
			this.Hide();
			Signup form1 = new Signup();
			form1.ShowDialog();
		}

	}
}
