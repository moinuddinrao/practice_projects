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
    public partial class FormEditProfile : Form
    {
        private UserBLL _userBLL;
        public FormEditProfile()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
        }

		private void buttonUpdateProfile_Click(object sender, EventArgs e)
		{
			UserVO _userVO = new UserVO();

			if(textBoxName.Text != string.Empty)
			{
				_userVO.Fullname = textBoxName.Text;
			}
			if(textBoxEmail.Text != string.Empty)
			{
				_userVO.Email = textBoxEmail.Text;
			} 
			if(textBoxPassword.Text != string.Empty)
			{
				_userVO.Userpass = textBoxPassword.Text;
			}
			if (radioButtonMale.Checked)
			{
				_userVO.Gender = "Male";
			}
			else if (radioButtonFemale.Checked)
			{
				_userVO.Gender = "Female";
			}
			if (textBoxPhone.Text != string.Empty)
			{
				_userVO.Phone = textBoxPhone.Text;
			}
			if (textBoxAddress.Text != string.Empty)
			{
				_userVO.Address = textBoxAddress.Text;
			}

			bool flag = _userBLL.UpdateUserInfo(_userVO);

			if (flag)
			{
				MessageBox.Show("Profile updated successfully!");
			}
			else
			{
				MessageBox.Show("Profile can not be updated. Tryagain!");
			}
		}
	}
}
