using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_MOBILE_VERIFYCODE
    {
        public decimal BASE_MOBILE_VERIFYCODE_ID { get; set; }
        public decimal USER_ID { get; set; }
        public decimal USER_TYPE { get; set; }
        public decimal VERIFY_TYPE { get; set; }
        public string MOBILE_NO { get; set; }
        public string MOBILE_VERIFYCODE { get; set; }
        public DateTime CREATEON { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool IS_DELETE { get; set; }
    }
}
