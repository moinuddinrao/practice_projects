using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
    public class UserDAL
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        public static int currentUser = 0;

        public UserDAL()
        {
            cn = new SqlConnection(dbConnection.getConnection());
        }

        public bool addUser(string _fullname, string _email, string _userpass, string _gender, string _phone, string _address)
        {
            cn.Open();

            // check if user already exist
            cmd = new SqlCommand("select * from UserInfo where Email='" + _email + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cn.Close();

                return false;
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into[UserInfo](FullName, Email, UserPass, Gender, Phone, UserAddress) " +
                                      "values (@p_fullname, @p_email, @p_userpass, @p_gender, @p_phone, @p_address)", cn);
                cmd.Parameters.AddWithValue("p_fullname", _fullname);
                cmd.Parameters.AddWithValue("p_email", _email);
                cmd.Parameters.AddWithValue("p_userpass", _userpass);
                cmd.Parameters.AddWithValue("p_gender", _gender);
                cmd.Parameters.AddWithValue("p_phone", _phone);
                cmd.Parameters.AddWithValue("p_address", _address);

                cmd.ExecuteNonQuery();
                cn.Close();

                return true;
            }
        }

        public bool checkUser(string _email, string _userpass)
        {
            cn.Open();

            // check if user exist
            cmd = new SqlCommand("select UserId from UserInfo where Email='" + _email + "' and UserPass = '" + _userpass + "'", cn);
            currentUser = Convert.ToInt32(cmd.ExecuteScalar()); //store id
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cn.Close();

                return true;
            }
            else
            {
                dr.Close();
                cn.Close();

                return false;
            }
        }

        public DataTable getUser(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select FullName, Email, Gender, Phone, UserAddress from UserInfo where UserId = '" + _userid + "'", cn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                cn.Close();

                return dt;
            }
            catch
            {
                throw;
            }

        }

        public string getName(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select FullName from UserInfo where UserId = '" + _userid + "'", cn);
            try
            {
                //SqlDataReader dr = cmd.ExecuteReader();
                string fullName = cmd.ExecuteScalar().ToString(); //get fullname

                //dr.Close();
                cn.Close();

                return fullName;
            }
            catch
            {
                throw;
            }

        }

        public string getJobTitle(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select JobTitle from Experience where UserId = '" + _userid + "'", cn);
            try
            {
                //SqlDataReader dr = cmd.ExecuteReader();
                string jobTitle = cmd.ExecuteScalar().ToString(); //get job title of user

                //dr.Close();
                cn.Close();

                return jobTitle;
            }
            catch
            {
                throw;
            }

        }

        public bool updateUserFullname(int _userid, string _fullname)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set FullName = '" + _fullname + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();
            
            cn.Close();
            
            return true;
        }
        public bool updateUserEmail(int _userid, string _email)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set Email = '" + _email + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();

            cn.Close();

            return true;
        }
        public bool updateUserPass(int _userid, string _userpass)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set UserPass = '" + _userpass + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();

            cn.Close();

            return true;
        }
        public bool updateUserGender(int _userid, string _gender)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set Gender = '" + _gender + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();

            cn.Close();

            return true;
        }
        public bool updateUserPhone(int _userid, string _phone)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set Phone = '" + _phone + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();

            cn.Close();

            return true;
        }
        public bool updateUserAddress(int _userid, string _address)
        {
            cn.Open();

            cmd = new SqlCommand("update UserInfo set UserAddress = '" + _address + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();

            cn.Close();

            return true;
        }
    }
}
