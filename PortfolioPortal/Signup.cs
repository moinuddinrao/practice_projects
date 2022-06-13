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
	public partial class Signup : Form
	{
		private UserBLL _userBLL;
		public Signup()
		{
			InitializeComponent();
			_userBLL = new UserBLL();
		}
		public bool checkData()
		{
			bool flag = true;
			if (textBoxName.Text == string.Empty) 
			{
				MessageBox.Show("Name can not be empty.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				flag = false;
			}
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
			if (textBoxCPassword.Text == string.Empty)
			{
				MessageBox.Show("Please Retype Password.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				flag = false;
			}
			if (textBoxPassword.Text != textBoxCPassword.Text)
			{
				MessageBox.Show("Passwords don't match.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				flag = false;
			}

			return flag;
		}
		private void Signup_Load(object sender, EventArgs e)
		{
			panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
		}

		private void buttonSignup_Click(object sender, EventArgs e)
		{
			UserVO _userVO = new UserVO();
			if (checkData())
			{
				_userVO.Fullname = textBoxName.Text;
				_userVO.Email = textBoxEmail.Text;
				_userVO.Userpass = textBoxPassword.Text;
				if (radioButtonMale.Checked)
				{
					_userVO.Gender = "Male";
				}
				else if (radioButtonFemale.Checked)
				{
					_userVO.Gender = "Female";
				}
				if(textBoxPhone.Text != string.Empty)
				{
					_userVO.Phone = textBoxPhone.Text;
				}
				if (textBoxAddress.Text != string.Empty)
				{
					_userVO.Address = textBoxAddress.Text;
				}

				bool flag = _userBLL.SignupUser(_userVO);

				if(flag)
				{
					MessageBox.Show("Account created successfully!");
				}
				else
				{
					MessageBox.Show("User already exist. Login!");
				}
			}
			else
			{
				MessageBox.Show("Your account can not be created. Try again.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void labelSignin_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login form1 = new Login();
			form1.ShowDialog();
		}

	}
}
