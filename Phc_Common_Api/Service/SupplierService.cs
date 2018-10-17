using Phc_Common_Api.DatabaseContext;
using Phc_Common_Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phc_Common_Api.Service
{
    public class SupplierService
    {
        readonly IBMD2Context _iBMD2Context;
        public SupplierService(IBMD2Context iBMD2Context)
        {
            this._iBMD2Context = iBMD2Context;
        }


        #region 'Public Method'

        public List<SupplierOption> GetSupplier(String webId)
        {
            List<SupplierOption> supplierOptions = null;
            try
            {
                //var d1 = this._iBMD2Context.SUPPLIER_ORG.ToList();
                //var d2 = this._iBMD2Context.WEB_USER_SUPP_DIV.ToList();

                var data2 = (from s in this._iBMD2Context.SUPPLIER_ORG
                             join ws in this._iBMD2Context.WEB_USER_SUPP_DIV on s.SUPP_ORG_ID equals ws.SUPP_ORG_ID
                             where ws.WEB_ID == webId && ws.SUPP_PRIMARY_YN == "Y"
                             select new
                             {
                                 MASTER_ID = s.MASTER_ID,
                                 Y = "Y"
                             }).ToList();

                var data = (from ws in this._iBMD2Context.WEB_USER_SUPP_DIV
                            from s in this._iBMD2Context.SUPPLIER_ORG
                            from m in this._iBMD2Context.SUPPLIER_ORG
                            where ws.SUPP_ORG_ID == s.SUPP_ORG_ID && s.MASTER_ID == m.SUPP_ORG_ID && ws.WEB_ID == webId && ws.RECORD_STATUS_CD == "A"
                            select new
                            {
                                MASTER_ID = m.MASTER_ID,
                                SUPP_ORG_NAME = m.SUPP_ORG_NAME,
                                UC_FIELD = m.SUPP_ORG_NAME
                            }).Distinct().ToList();

                supplierOptions = (from temp in data
                                   join primary in data2 on temp.MASTER_ID equals primary.MASTER_ID into wt1
                                   from wt in wt1.DefaultIfEmpty()
                                   orderby temp.SUPP_ORG_NAME
                                   select new SupplierOption
                                   {
                                       MasterId = temp.MASTER_ID,
                                       SupplierOrganizationName = temp.SUPP_ORG_NAME.Trim().ToUpper(),
                                       
                                   }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            // this._iBMD2Context.SUPPLIER_ORG
            return supplierOptions;
        }

        #endregion

        #region 'Public Method'
        public List<SupplierAddressOption> GetSupplierAddress(String SupplierOrganizationId)
        {
            List<SupplierAddressOption> supplierAddressData = null;
            try
            {
                supplierAddressData = (from a in this._iBMD2Context.SUPPLIER_ORG
                                   where a.SUPP_ORG_ID == SupplierOrganizationId
                                   select new SupplierAddressOption
                                   {
                                       SupplierOrganizationId = a.SUPP_ORG_ID,
                                       SupplierOrganizationName = a.SUP_ADDR1.Trim(),
                                       SupplierAddress = a.SUPP_ORG_NAME.Trim()
                                   }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return supplierAddressData;
        }
        #endregion
    }
}
