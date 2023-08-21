using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class ProjectVO
	{
		private int _userid;
		private string _projecttitle;
		private string _members;
		private string _details;

		public ProjectVO()
		{
			Userid = UserDAL.currentUser;
			Projecttitle = "";
			Members = "";
			Details = "";
		}

		public int Userid { get => _userid; set => _userid = value; }
		public string Projecttitle { get => _projecttitle; set => _projecttitle = value; }
		public string Members { get => _members; set => _members = value; }
		public string Details { get => _details; set => _details = value; }
	}
}
