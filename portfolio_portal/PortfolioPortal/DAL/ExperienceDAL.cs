using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class ExperienceDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

		public ExperienceDAL()
		{
			cn = new SqlConnection(dbConnection.getConnection());
		}

        public bool addExperience(string _jobtitle, string _workplace, string _yearfrom, string _yearto, int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("insert into [Experience] values (@p_jobtitle, @p_workplace, @p_yearfrom, @p_yearto, @p_userid)", cn);
            cmd.Parameters.AddWithValue("p_jobtitle", _jobtitle);
            cmd.Parameters.AddWithValue("p_workplace", _workplace);
            cmd.Parameters.AddWithValue("p_yearfrom", _yearfrom);
            cmd.Parameters.AddWithValue("p_yearto", _yearto);
            cmd.Parameters.AddWithValue("p_userid", _userid);

            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }

        public DataTable getExperience(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select JobTitle, Workplace, YearFrom, YearTo from Experience where UserId = '" + _userid + "'", cn);
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
