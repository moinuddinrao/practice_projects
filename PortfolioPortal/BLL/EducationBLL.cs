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
	public class EducationBLL
	{
		private EducationDAL _educationDAL;

		public EducationBLL()
		{
			_educationDAL = new EducationDAL();
		}

        public bool AddUserEduaction(EducationVO _educationVO)
        {
            try
            {
                return _educationDAL.addEducation(_educationVO.Degreetitle, _educationVO.Specialization, _educationVO.Institute, _educationVO.Passingyear, _educationVO.Userid);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserEducation(EducationVO _educationVO)
        {
            try
            {
                return _educationDAL.getEducation(_educationVO.Userid); ;
            }
            catch
            {
                throw;
            }
        }
    }
}
