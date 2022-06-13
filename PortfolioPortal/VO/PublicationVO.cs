using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class PublicationVO
	{
		private int _userid;
		private string _title;
		private string _journal;
		private string _url;
		private int _publicationyear;
		private string _author;
		private string _details;

		public PublicationVO()
		{
			Userid = UserDAL.currentUser;
			Title = "";
			Journal = "";
			Url = "";
			Publicationyear = 0;
			Author = "";
			Details = "";
		}

		public int Userid { get => _userid; set => _userid = value; }
		public string Title { get => _title; set => _title = value; }
		public string Journal { get => _journal; set => _journal = value; }
		public string Url { get => _url; set => _url = value; }
		public int Publicationyear { get => _publicationyear; set => _publicationyear = value; }
		public string Author { get => _author; set => _author = value; }
		public string Details { get => _details; set => _details = value; }
	}
}
