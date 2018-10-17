using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phc_Common_Api.DatabaseContext;
using Phc_Common_Api.ViewModel;
namespace Phc_Common_Api.Service
{
    public class DivisionsLocationsService
    {
        readonly IBMD2Context _iBMD2Context;
        public DivisionsLocationsService(IBMD2Context iBMD2Context)
        {
            this._iBMD2Context = iBMD2Context;
        }


        #region 'Public Method'

        public List<DivisionsLocationOption> GetDivisionLocation(String webId, String masterId)
        {
            List<DivisionsLocationOption> divisionsLocationOptions = null;
            try
            {

                //divisionsLocationOptions = (from a in this._iBMD2Context.WEB_USER_SUPP_DIV
                //                            join b in this._iBMD2Context.PARKER_DIV_XREF on a.PARKER_DIV_ID equals b.PARKER_DIV_ID
                //                            join c in this._iBMD2Context.PARKER_LOC_XREF on a.PARKER_DIV_ID equals c.PARKER_DIV_ID
                //                            join d in this._iBMD2Context.SUPP_PARKER_LOC
                //                            on new { parker_div_id = a.PARKER_DIV_ID, security_loc_cd = c.SECURITY_LOC_CD, supp_ord_id = a.SUPP_ORG_ID } 
                //                            equals new { parker_div_id = d.PARKER_DIV_ID, security_loc_cd = d.PARKER_LOC_CD, supp_ord_id = d.SUPP_ORG_ID }
                //                            join e in _iBMD2Context.SUPPLIER_ORG on a.SUPP_ORG_ID equals e.SUPP_ORG_ID
                //                            join f in _iBMD2Context.PARKER_DIV_XREF on b.INTERNATL_DIV_ID equals f.PARKER_DIV_ID into temp
                //                            from wt in temp.DefaultIfEmpty()
                //                            where a.WEB_ID == webId && e.MASTER_ID == masterId && a.RECORD_STATUS_CD == "A" 
                //                            && a.RECORD_STATUS_CD == "A" && b.RECORD_STATUS_CD == "A" && c.RECORD_STATUS_CD == "A" && d.RECORD_STATUS_CD == "A"
                //                            select new DivisionsLocationOption
                //                            {
                //                                PARKER_DIV_ID = c.PARKER_DIV_ID,
                //                                SECURITY_LOC_CD = c.SECURITY_LOC_CD,
                //                                PARKER_LOC_NAME = c.PARKER_LOC_NAME.ToUpper().Trim(),
                //                                PRIMARY = a.SUPP_PRIMARY_YN,
                //                                PARKER_DIV_NAME = wt.PARKER_DIV_NAME.ToUpper().Trim()
                //                            }).ToList();

                divisionsLocationOptions = (from a in this._iBMD2Context.WEB_USER_SUPP_DIV
                                            join b in this._iBMD2Context.PARKER_DIV_XREF on a.PARKER_DIV_ID equals b.PARKER_DIV_ID
                                            join c in this._iBMD2Context.PARKER_LOC_XREF on a.PARKER_DIV_ID equals c.PARKER_DIV_ID
                                            join d in this._iBMD2Context.SUPP_PARKER_LOC on a.PARKER_DIV_ID equals d.PARKER_DIV_ID
                                            where c.SECURITY_LOC_CD == d.PARKER_LOC_CD && a.SUPP_ORG_ID == d.SUPP_ORG_ID
                                            join e in _iBMD2Context.SUPPLIER_ORG on a.SUPP_ORG_ID equals e.SUPP_ORG_ID
                                            join f in _iBMD2Context.PARKER_DIV_XREF on b.INTERNATL_DIV_ID equals f.PARKER_DIV_ID
                                            where a.WEB_ID == webId && e.MASTER_ID == masterId && a.RECORD_STATUS_CD == "A" && b.RECORD_STATUS_CD == "A" && c.RECORD_STATUS_CD == "A" && d.RECORD_STATUS_CD == "A"


                                            select new DivisionsLocationOption
                                            {
                                                parkerDivId = c.PARKER_DIV_ID,
                                                securityLocCD = c.SECURITY_LOC_CD,
                                                parkerLocName = c.PARKER_LOC_NAME.ToUpper().Trim(),
                                                primary = a.SUPP_PRIMARY_YN,
                                                parkerDivName = f.PARKER_DIV_NAME.ToUpper().Trim(),
                                                masterId = e.MASTER_ID
                                            }).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return divisionsLocationOptions.ToList();
        }

        #endregion

        #region 'Private Method'

        #endregion
    }
}
