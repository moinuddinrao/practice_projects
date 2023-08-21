using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PortfolioPortal.DAL
{
	public class dbConnection
	{
        private static string conString = @"Data Source=DESKTOP-LBLC0OF\SQLEXPRESS;Initial Catalog=PortfolioPortal;Integrated Security=True";

		public static string getConnection()
		{
			return dbConnection.conString;
		}
	}
}
