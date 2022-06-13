using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;
using PortfolioPortal.VO;
using System.Data;

namespace PortfolioPortal.BLL
{
    public class UserBLL
    {
        private UserDAL _userDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
        }

        public bool SignupUser(UserVO _userVO)
        {
            try
            {
                return _userDAL.addUser(_userVO.Fullname, _userVO.Email, _userVO.Userpass, _userVO.Gender, _userVO.Phone, _userVO.Address);
            }
            catch
            {
                throw;
            }

        }

        public bool LoginUser(UserVO _userVO)
        {
            try
            {
                return _userDAL.checkUser(_userVO.Email, _userVO.Userpass);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserInfo(UserVO _userVO)
        {
            try
            {
                return _userDAL.getUser(_userVO.Userid);
            }
            catch
            {
                throw;
            }
        }

        public string GetUserName(UserVO _userVO)
        {
            try
            {
                return _userDAL.getName(_userVO.Userid);
            }
            catch
            {
                throw;
            }
        }
        public string GetUserJobTitle(UserVO _userVO)
        {
            try
            {
                return _userDAL.getJobTitle(_userVO.Userid);
            }
            catch
            {
                throw;
            }
        }
        public bool UpdateUserInfo(UserVO _userVO)
        {
            bool flag = true;
            if(_userVO.Fullname != string.Empty) // update name
			{
                flag = _userDAL.updateUserFullname(_userVO.Userid, _userVO.Fullname);
            }
            if (_userVO.Email != string.Empty) // update email
            {
                flag = _userDAL.updateUserEmail(_userVO.Userid, _userVO.Email);
            }
            if (_userVO.Userpass != string.Empty) // update password
            {
                flag = _userDAL.updateUserPass(_userVO.Userid, _userVO.Userpass);
            }
            if (_userVO.Gender != string.Empty) // update gender
            {
                flag = _userDAL.updateUserGender(_userVO.Userid, _userVO.Gender);
            }
            if (_userVO.Phone != string.Empty) // update phone
            {
                flag = _userDAL.updateUserPhone(_userVO.Userid, _userVO.Phone);
            }
            if (_userVO.Address != string.Empty) // update address
            {
                flag = _userDAL.updateUserAddress(_userVO.Userid, _userVO.Address);
            }
            return flag;
        }
    }
}
