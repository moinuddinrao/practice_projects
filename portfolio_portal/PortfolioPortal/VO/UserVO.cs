using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
    public class UserVO
    {
        private int _userid;
        private string _fullname;
        private string _email;
        private string _userpass;
        private string _gender;
        private string _phone;
        private string _address;

        public UserVO()
        {
            _userid = UserDAL.currentUser;
            _fullname = "";
            _email = "";
            _userpass = "";
            _gender = "";
            _phone = "";
            _address = "";
        }

        public int Userid { get => _userid; set => _userid = value; }
        public string Fullname { get => _fullname; set => _fullname = value; }
        public string Email { get => _email; set => _email = value; }
        public string Userpass { get => _userpass; set => _userpass = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
    }
}
