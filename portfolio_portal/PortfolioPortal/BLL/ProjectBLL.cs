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
	public class ProjectBLL
	{
		private ProjectDAL _projectDAL;

		public ProjectBLL()
		{
			_projectDAL = new ProjectDAL();
		}

        public bool AddUserProject(ProjectVO _projectVO)
        {
            try
            {
                return _projectDAL.addProject(_projectVO.Projecttitle, _projectVO.Members, _projectVO.Details, _projectVO.Userid);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserProject(ProjectVO _projectVO)
        {
            try
            {
                return _projectDAL.getProject(_projectVO.Userid);
            }
            catch
            {
                throw;
            }
        }
    }
}
