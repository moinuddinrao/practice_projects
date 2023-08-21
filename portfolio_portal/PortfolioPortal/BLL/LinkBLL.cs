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
	public class LinkBLL
	{
		private LinkDAL _linkDAL;
		public LinkBLL()
		{
			_linkDAL = new LinkDAL();
		}
        public bool AddUserLink(LinkVO _linkVO)
        {
            try
            {
                return _linkDAL.addLink(_linkVO.Linkedin, _linkVO.Researchgate, _linkVO.Googlescholar, _linkVO.Userid);
            }
            catch
            {
                throw;
            }

        }
        public string GetUserLinkedIn(LinkVO _linkVO)
        {
            try
            {
                return _linkDAL.getLinkedIn(_linkVO.Userid);
            }
            catch
            {
                throw;
            }
        }
        public string GetUserResearchGate(LinkVO _linkVO)
        {
            try
            {
                return _linkDAL.getResearchGate(_linkVO.Userid);
            }
            catch
            {
                throw;
            }
        }
        public string GetUserGoogleScholar(LinkVO _linkVO)
        {
            try
            {
                return _linkDAL.getGoogleScholar(_linkVO.Userid);
            }
            catch
            {
                throw;
            }
        }
    }
}
