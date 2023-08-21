using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class LinkDAL
	{
		private SqlConnection cn;
		private SqlCommand cmd;

		public LinkDAL()
		{
			cn = new SqlConnection(dbConnection.getConnection());
		}


        public bool addLink(string _linkedin, string _researchgate, string _googlescholar, int _userid)
        {
            bool flag = false;
            if(_linkedin != string.Empty)
			{
                flag = updateLinkedIn(_userid, _linkedin);
			}
            if (_researchgate != string.Empty)
            {
                flag = updateResearchGate(_userid, _researchgate);
            }
            if (_googlescholar != string.Empty)
            {
                flag = updateGoogleScholar(_userid, _googlescholar);
            }
            return flag;
        }

        public bool updateLinkedIn(int _userid, string _linkedin)
        {
            cn.Open();
            cmd = new SqlCommand("update Links set LinkedIn = '" + _linkedin + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();
            cn.Close();
            return true;
        }
        public bool updateResearchGate(int _userid, string _researchgate)
        {
            cn.Open();
            cmd = new SqlCommand("update Links set ResearchGate = '" + _researchgate + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();
            cn.Close();
            return true;
        }
        public bool updateGoogleScholar(int _userid, string _googlescholar)
        {
            cn.Open();
            cmd = new SqlCommand("update Links set GoogleScholar = '" + _googlescholar + "' where UserId = '" + _userid + "'", cn);
            cmd.ExecuteReader();
            cn.Close();
            return true;
        }
        public string getLinkedIn(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select LinkedIn from Links where UserId = '" + _userid + "'", cn);
            try
            {
                string linkedIn = cmd.ExecuteScalar().ToString();
                cn.Close();

                return linkedIn;
            }
            catch
            {
                throw;
            }
        }
        public string getResearchGate(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select ResearchGate from Links where UserId = '" + _userid + "'", cn);
            try
            {
                string researchGate = cmd.ExecuteScalar().ToString();
                cn.Close();

                return researchGate;
            }
            catch
            {
                throw;
            }
        }
        public string getGoogleScholar(int _userid)
        {
            cn.Open();

            cmd = new SqlCommand("select GoogleScholar from Links where UserId = '" + _userid + "'", cn);
            try
            {
                string googleScholar = cmd.ExecuteScalar().ToString();
                cn.Close();

                return googleScholar;
            }
            catch
            {
                throw;
            }
        }
    }
}
