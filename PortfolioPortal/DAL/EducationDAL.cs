using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class EducationDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

        public EducationDAL()
        {
            cn = new SqlConnection(dbConnection.getConnection());
        }

        public bool addEducation(string _degreetitle, string _specialization, string _institute, int _passingyear, int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("insert into [Education] values (@p_degreetitle, @p_specialization, @p_institute, @p_passingyear, @p_userid)", cn);
            cmd.Parameters.AddWithValue("p_degreetitle", _degreetitle);
            cmd.Parameters.AddWithValue("p_specialization", _specialization);
            cmd.Parameters.AddWithValue("p_institute", _institute);
            cmd.Parameters.AddWithValue("p_passingyear", _passingyear);
            cmd.Parameters.AddWithValue("p_userid", _userid);

            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }

        public DataTable getEducation(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select DegreeTitle, Specialization, Institute, PassingYear from Education where UserId = '" + _userid + "'", cn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cn.Close();

                return dt;
            }
            catch
            {
                throw;
            }

        }
    }
}
