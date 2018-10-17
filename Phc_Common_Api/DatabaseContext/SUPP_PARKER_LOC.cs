using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phc_Common_Api.DatabaseContext
{
    public class SUPP_PARKER_LOC
    {
        [Key]
        public string SUPP_ORG_ID { get; set; }
        [Key]
        public string PARKER_DIV_ID { get; set; }
        [Key]
        public string PARKER_LOC_CD { get; set; }
        public string RECORD_STATUS_CD { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime CHANGE_TIMESTAMP { get; set; }
        public string MAINT_AUTH_ID { get; set; }
    }
}
