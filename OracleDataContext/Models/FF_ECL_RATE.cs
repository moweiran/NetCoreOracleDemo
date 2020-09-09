using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_RATE
    {
        public FF_ECL_RATE()
        {
            FF_ECL_RATE_DETAIL = new HashSet<FF_ECL_RATE_DETAIL>();
        }

        public decimal FF_ECL_RATE_ID { get; set; }
        public decimal FF_ECL_RATE_LIST_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal? PARENT_ECL_RATE_ID { get; set; }
        public decimal MAIN_ECL_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_COUNTRY_ID { get; set; }
        public decimal? MIN_SALE { get; set; }
        public decimal? BAF { get; set; }
        public decimal? DISCOUNT { get; set; }
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
        public decimal? OTHER_FEE { get; set; }

        public virtual ICollection<FF_ECL_RATE_DETAIL> FF_ECL_RATE_DETAIL { get; set; }
    }
}
