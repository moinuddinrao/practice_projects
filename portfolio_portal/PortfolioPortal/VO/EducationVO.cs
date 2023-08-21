using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;

namespace PortfolioPortal.VO
{
	public class EducationVO
	{
        private int _userid;
        private string _degreetitle;
        private string _specialization;
        private string _institute;
        private int _passingyear;

        public EducationVO()
        {
            Userid = UserDAL.currentUser;
            _degreetitle = "";
            _specialization = "";
            _institute = "";
            _passingyear = 0;

        }

		public int Userid { get => _userid; set => _userid = value; }
		public string Degreetitle { get => _degreetitle; set => _degreetitle = value; }
		public string Specialization { get => _specialization; set => _specialization = value; }
		public string Institute { get => _institute; set => _institute = value; }
		public int Passingyear { get => _passingyear; set => _passingyear = value; }
	}
}
