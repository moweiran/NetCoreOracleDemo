using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_RATE
    {
        public FF_RTFCL_RATE()
        {
            FF_RTFCL_RATE_DETAIL = new HashSet<FF_RTFCL_RATE_DETAIL>();
        }

        public decimal FF_RTFCL_RATE_ID { get; set; }
        public decimal? PARENT_RTFCL_RATE_ID { get; set; }
        public decimal FF_RTFCL_RATE_LIST_ID { get; set; }
        public decimal FF_RTFCL_PRODUCT_ID { get; set; }
        public decimal MAIN_RTFCL_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public string CURRENCY { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal FF_COMPANY_ID { get; set; }

        public virtual ICollection<FF_RTFCL_RATE_DETAIL> FF_RTFCL_RATE_DETAIL { get; set; }
    }
}
