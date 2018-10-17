using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Phc_Common_Api.DatabaseContext
{
    public class SUPPLIER_ORG
    {
        //[Key]
        public string SUPP_ORG_ID { get; set; }
        public string ADDRESSBOOK { get; set; }
        public string BANK_NO { get; set; }
        public DateTime CHANGE_TIMESTAMP { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CURRENT_SER_CD { get; set; }
        public string DUNS_NUM { get; set; }
        public string HIGH_RISK_CD { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string MAINT_AUTH_ID { get; set; }
        public string MASTER_ID { get; set; }
        public string MINORITY_OWNED_YN { get; set; }
        public string MINORITY_TYPE_CD { get; set; }
        public string OWNER_CD1 { get; set; }
        public string OWNER_CD2 { get; set; }
        public string OWNER_CD3 { get; set; }
        public string PARENT_OFC_SUPP_ID { get; set; }
        public string PRIMARYADDRESSBOOK { get; set; }
        public string PRIMARYSUPPLIERID { get; set; }
        public string RECORD_STATUS_CD { get; set; }
        public string REMIT_SUPP_ID { get; set; }
        public string SUP_ADDR1 { get; set; }
        public string SUP_ADDR2 { get; set; }
        public string SUP_ADDR3 { get; set; }
        public string SUP_ADDR4 { get; set; }
        public string SUP_CITY { get; set; }
        public string SUP_COUNTRY { get; set; }
        public string SUP_GL_CLASS { get; set; }
        public string SUP_PAY_ADDR1 { get; set; }
        public string SUP_PAY_ADDR2 { get; set; }
        public string SUP_PAY_ADDR3 { get; set; }
        public string SUP_PAY_ADDR4 { get; set; }
        public string SUP_PAY_CITY { get; set; }
        public string SUP_PAY_COUNTRY { get; set; }
        public string SUP_PAY_NAME { get; set; }
        public string SUP_PAY_STATE_PROV_CD { get; set; }
        public string SUP_PAY_ZIP { get; set; }
        public string SUP_PROCESS_NO { get; set; }
        public string SUP_SS_TAX_ID { get; set; }
        public string SUP_STATE_PROV_CD { get; set; }
        public string SUP_ZIP { get; set; }
        public DateTime SUPP_EFFECTIVE_TS { get; set; }
        public string SUPP_INACTIVE { get; set; }
        
        public string SUPP_ORG_NAME { get; set; }
        public string SUPPLIER_ID { get; set; }
        public string SUPPLIER_TYPE { get; set; }
        public string VERIFICATION_CD { get; set; }
        public string WOMAN_OWNED_YN { get; set; }
    }
}
