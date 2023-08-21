using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class ProjectDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

		public ProjectDAL()
		{
			cn = new SqlConnection(dbConnection.getConnection());
		}

        public bool addProject(string _projecttitle, string _members, string _details, int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("insert into [Projects] values (@p_projecttitle, @p_members, @p_details, @p_userid)", cn);
            cmd.Parameters.AddWithValue("p_projecttitle", _projecttitle);
            cmd.Parameters.AddWithValue("p_members", _members);
            cmd.Parameters.AddWithValue("p_details", _details);
            cmd.Parameters.AddWithValue("p_userid", _userid);

            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }

        public DataTable getProject(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select ProjectTitle, Members, Details from Projects where UserId = '" + _userid + "'", cn);
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
