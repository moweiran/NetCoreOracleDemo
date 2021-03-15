using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_FCL_RATE
    {
        public decimal FF_RATE_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal MAIN_CP_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal CARRIER_COMPANY_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public decimal? CLOSE_TIME { get; set; }
        public decimal? LEAVE_TIME { get; set; }
        public decimal TT { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public string RECEIPT_CODE { get; set; }
        public decimal? RECEIPT_CITY_ID { get; set; }
        public decimal POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public decimal? POL_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public string VIA_CODE { get; set; }
        public decimal? VIA_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public decimal? POD_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public string DELIVERY_CODE { get; set; }
        public decimal? DELIVERY_CITY_ID { get; set; }
        public string REMARK { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime? ETD { get; set; }
        public decimal FF_RATE_LIST_ID { get; set; }
        public string CLOSE_LEAVE { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
        public decimal? TOTAL_TEU { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_CODE { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public bool? IS_SUPER_PARTNER { get; set; }
        public DateTime COMPANY_CREATEDATE { get; set; }
        public decimal? RECOMMEND_ALLIANCE_FF_ID { get; set; }
        public decimal? FCL_SURPLUS_AMOUNT { get; set; }
        public decimal? PUBLIC_GP20 { get; set; }
        public decimal? PUBLIC_GP40 { get; set; }
        public decimal? PUBLIC_HQ40 { get; set; }
        public decimal? PUBLIC_GP45 { get; set; }
        public decimal? SUBSIDY_TEU { get; set; }
        public decimal? SUBSIDY_SALE_TEU { get; set; }
        public decimal? SUBSIDY_GP20 { get; set; }
        public decimal? SUBSIDY_GP40 { get; set; }
        public decimal? SUBSIDY_HQ40 { get; set; }
        public decimal? SUBSIDY_GP45 { get; set; }
    }
}
