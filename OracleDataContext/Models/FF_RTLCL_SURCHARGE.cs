using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_SURCHARGE
    {
        public FF_RTLCL_SURCHARGE()
        {
            FF_RTLCL_SURCHARGE_PRODUCT = new HashSet<FF_RTLCL_SURCHARGE_PRODUCT>();
        }

        public decimal FF_RTLCL_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string PPCC { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal UNIT { get; set; }
        public decimal? AMOUNT { get; set; }
        public bool? IS_MUST_CHARGE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual ICollection<FF_RTLCL_SURCHARGE_PRODUCT> FF_RTLCL_SURCHARGE_PRODUCT { get; set; }
    }
}
