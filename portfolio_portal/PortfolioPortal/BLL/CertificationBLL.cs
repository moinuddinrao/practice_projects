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
	public class CertificationBLL
	{
        private CertificationDAL _certificationDAL;

        public CertificationBLL()
        {
            _certificationDAL = new CertificationDAL();
        }

        public bool AddUserCertification(CertificationVO _certificationVO)
        {
            try
            {
                return _certificationDAL.addCertification(_certificationVO.Certificatetitle, _certificationVO.Certificateprovider, _certificationVO.Certificationyear, _certificationVO.Userid);
            }
            catch
            {
                throw;
            }

        }

        public DataTable GetUserCertification(CertificationVO _certificationVO)
        {
            try
            {
                return _certificationDAL.getCertification(_certificationVO.Userid);
            }
            catch
            {
                throw;
            }
        }
    }
}
