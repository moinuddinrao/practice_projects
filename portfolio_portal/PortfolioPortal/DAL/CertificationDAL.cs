using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class CertificationDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

		public CertificationDAL()
		{
			cn = new SqlConnection(dbConnection.getConnection());
		}

        public bool addCertification(string _certificatetitle, string _certificateprovider, int _certificationyear, int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("insert into [Certifications] values (@p_certificatetitle, @p_certificateprovider, @p_certificationyear, @p_userid)", cn);
            cmd.Parameters.AddWithValue("p_certificatetitle", _certificatetitle);
            cmd.Parameters.AddWithValue("p_certificateprovider", _certificateprovider);
            cmd.Parameters.AddWithValue("p_certificationyear", _certificationyear);
            cmd.Parameters.AddWithValue("p_userid", _userid);

            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }

        public DataTable getCertification(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select CertificateTitle, CertificateProvider, CertificationYear from Certifications where UserId = '" + _userid + "'", cn);
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
