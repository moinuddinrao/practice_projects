using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class CertificationVO
	{
        private int _userid;
        private string _certificatetitle;
        private string _certificateprovider;
        private int _certificationyear;

		public CertificationVO()
		{
			_userid = UserDAL.currentUser;
			_certificatetitle = "";
			_certificateprovider = "";
			_certificationyear = 0;
		}

		public int Userid { get => _userid; set => _userid = value; }
		public string Certificatetitle { get => _certificatetitle; set => _certificatetitle = value; }
		public string Certificateprovider { get => _certificateprovider; set => _certificateprovider = value; }
		public int Certificationyear { get => _certificationyear; set => _certificationyear = value; }
	}
}
