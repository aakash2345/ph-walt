using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phc_Common_Api.DatabaseContext
{
    public class PARKER_LOC_XREF
    {
        [Key]
        public string PARKER_DIV_ID { get; set; }
        [Key]
        public string SECURITY_LOC_CD { get; set; }
        public string PARKER_LOC_NAME { get; set; }
        public string PARKER_DUNS_NO { get; set; }
        public string PRIMARY_YN { get; set; }
        public string EDI_LOC_CD { get; set; }
        public string HR_LOC_CD { get; set; }
        public string HR_SUB_LOC_CD { get; set; }
        public string DIRECT_AREA_CD { get; set; }
        public string DIRECT_PHONE_NO { get; set; }
        public string DIRECT_FAX_NO { get; set; }
        public string TOLLFREE_PHONE_NO { get; set; }
        public string INTERNATIONAL_CD { get; set; }
        public string COUNTRY_CD { get; set; }
        public string STATE_PROVINCE_CD { get; set; }
        public string RECORD_STATUS_CD { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime CHANGE_TIMESTAMP { get; set; }
        public string MAINT_AUTH_ID { get; set; }
        public string POSTAL_CD { get; set; }
        public string VENDOR_NUMBER { get; set; }
        public string JDE_BRANCH_PLANT { get; set; }
        public string ROBOT_LOCATION { get; set; }
        public string SHIP_TO { get; set; }
        public string CUST_SERV_EMAIL { get; set; }
        public string PROCURER_EMAIL { get; set; }
        public string IT_CONTACT_EMAIL { get; set; }
        public string AP_COMPANY_NUMBER { get; set; }
        public string JDE_LIB_LIST_NM { get; set; }
        public string JDE_ADV_PRICE_YN { get; set; }
        public string CITY_NAME { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string STREET_ADDR1 { get; set; }
        public string STREET_ADDR2 { get; set; }
        public string STREET_ADDR3 { get; set; }
        public string STREET_ADDR4 { get; set; }
        public string ACCTRCV_ADDR2 { get; set; }
        public string ACCTPAY_ADDR2 { get; set; }
        public string HR_LOC_CD_LONG { get; set; }
        
    }
}
