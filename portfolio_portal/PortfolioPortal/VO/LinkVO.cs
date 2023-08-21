using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class LinkVO
	{
		private int _userid;
		private string _linkedin;
		private string _researchgate;
		private string _googlescholar;

		public LinkVO()
		{
			Userid = UserDAL.currentUser;
			Linkedin = "";
			Researchgate = "";
			Googlescholar = "";
		}

		public int Userid { get => _userid; set => _userid = value; }
		public string Linkedin { get => _linkedin; set => _linkedin = value; }
		public string Researchgate { get => _researchgate; set => _researchgate = value; }
		public string Googlescholar { get => _googlescholar; set => _googlescholar = value; }
	}
}
