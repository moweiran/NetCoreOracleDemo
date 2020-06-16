using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RATES
    {
        public FF_RATES()
        {
            FF_RATE_DETAIL = new HashSet<FF_RATE_DETAIL>();
        }

        public decimal FF_RATE_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal CARRIER_COMPANY_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public decimal? CLOSE_TIME { get; set; }
        public decimal? LEAVE_TIME { get; set; }
        public decimal TT { get; set; }
        public string RECEIPT_CODE { get; set; }
        public decimal? RECEIPT_CITY_ID { get; set; }
        public string POL_CODE { get; set; }
        public decimal? POL_CITY_ID { get; set; }
        public string VIA_CODE { get; set; }
        public decimal? VIA_CITY_ID { get; set; }
        public string POD_CODE { get; set; }
        public decimal? POD_CITY_ID { get; set; }
        public string DELIVERY_CODE { get; set; }
        public decimal? DELIVERY_CITY_ID { get; set; }
        public string REMARK { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime? ETD { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal FF_RATE_LIST_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal MAIN_PRODUCT_ID { get; set; }
        public bool? IS_MAIN_PRODUCT { get; set; }
        public string PRE_BRANCH_RATE_ID { get; set; }
        public string AFTER_BRANCH_RATE_ID { get; set; }
        public decimal FCLMAIN_RATE_ID { get; set; }
        public decimal? TOP_SUPPLIER_ID { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
        public string CLOSE_LEAVE { get; set; }
        public decimal PRE_CP_ID { get; set; }
        public decimal MAIN_CP_ID { get; set; }
        public decimal AFTER_CP_ID { get; set; }
        public decimal PRE_CPRATE_ID { get; set; }
        public decimal MAIN_CPRATE_ID { get; set; }
        public decimal AFTER_CPRATE_ID { get; set; }
        public decimal? PARENT_RATE_ID { get; set; }
        public decimal? WEEK_ID { get; set; }
        public decimal? NEWSHIP_RATE_ID { get; set; }
        public decimal? MAIN_CRS_ID { get; set; }

        public virtual ICollection<FF_RATE_DETAIL> FF_RATE_DETAIL { get; set; }
    }
}
