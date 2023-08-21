using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioPortal.DAL;
using PortfolioPortal.VO;
using System.Data;

namespace PortfolioPortal.BLL
{
	public class ExperienceBLL
	{
		private ExperienceDAL _experienceDAL;

		public ExperienceBLL()
		{
			_experienceDAL = new ExperienceDAL();
		}

        public bool AddUserExperience(ExperienceVO _experienceVO)
        {
            try
            {
                return _experienceDAL.addExperience(_experienceVO.Jobtitle, _experienceVO.Workplace, _experienceVO.Yearfrom, _experienceVO.Yearto, _experienceVO.Userid);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserExperience(ExperienceVO _experienceVO)
        {
            try
            {
                return _experienceDAL.getExperience(_experienceVO.Userid);
            }
            catch
            {
                throw;
            }
        }
    }
}