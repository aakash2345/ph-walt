using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Phc_Common_Api.DatabaseContext
{
    public class WEB_USER_SUPP_DIV
    {
        //[Key]
        public string WEB_ID { get; set; }
        public string SUPP_PRIMARY_YN { get; set; }
        public string SUPP_ORG_ID { get; set; }
        public string RECORD_STATUS_CD { get; set; }
        public string PARKER_DIV_ID { get; set; }
        public string MAINT_AUTH_ID { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime CHANGE_TIMESTAMP { get; set; }
    }
}
