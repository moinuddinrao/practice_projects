using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class ExperienceVO
	{
		private int _userid;
		private string _jobtitle;
		private string _workplace;
		private string _yearfrom;
		private string _yearto;

		public ExperienceVO()
		{
			Userid = UserDAL.currentUser;
			Jobtitle = "";
			Workplace = "";
			Yearfrom = "";
			Yearto = "";
		}

		public int Userid { get => _userid; set => _userid = value; }
		public string Jobtitle { get => _jobtitle; set => _jobtitle = value; }
		public string Workplace { get => _workplace; set => _workplace = value; }
		public string Yearfrom { get => _yearfrom; set => _yearfrom = value; }
		public string Yearto { get => _yearto; set => _yearto = value; }
	}

}
