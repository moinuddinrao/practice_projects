using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class PublicationDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

		public PublicationDAL()
		{
			cn = new SqlConnection(dbConnection.getConnection());
		}

        public bool addPublication(string _title, string _journal, string _author, int _publicationyear, string _details, string _url, int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("insert into [Publications] values (@p_title, @p_journal, @p_author, @p_publicationyear, @p_details, @p_url,  @p_userid)", cn);
            cmd.Parameters.AddWithValue("p_title", _title);
            cmd.Parameters.AddWithValue("p_journal", _journal);
            cmd.Parameters.AddWithValue("p_author", _author);
            cmd.Parameters.AddWithValue("p_publicationyear", _publicationyear);
            cmd.Parameters.AddWithValue("p_details", _details);
            cmd.Parameters.AddWithValue("p_url", _url);
            cmd.Parameters.AddWithValue("p_userid", _userid);

            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }

        public DataTable getPublication(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select Title, Journal, Author, PublicationYear, Details, URL from Publications where UserId = '" + _userid + "'", cn);
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
