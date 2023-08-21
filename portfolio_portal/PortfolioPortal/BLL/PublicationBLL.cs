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
	public class PublicationBLL
	{
		private PublicationDAL _publicationDAL;

		public PublicationBLL()
		{
			_publicationDAL = new PublicationDAL();
		}

        public bool AddUserPublication(PublicationVO _publicationVO)
        {
            try
            {
                return _publicationDAL.addPublication(_publicationVO.Title, _publicationVO.Journal, _publicationVO.Author, _publicationVO.Publicationyear,  _publicationVO.Details, _publicationVO.Url, _publicationVO.Userid);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserPublication(PublicationVO _publicationVO)
        {
            try
            {
                return _publicationDAL.getPublication(_publicationVO.Userid);
            }
            catch
            {
                throw;
            }
        }
    }
}
