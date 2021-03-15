using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_ORDER
    {
        public decimal FF_RTFCL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal PARENT_ORDER_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string CUSTOMER_RF_NO { get; set; }
        public decimal FF_RTFCL_RATE_ID { get; set; }
        public decimal FF_RTFCL_PRODUCT_ID { get; set; }
        public string FF_RF_NO { get; set; }
        public string RELEASE_MODE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public decimal? CUSTOMER_SHIPPER_ID { get; set; }
        public decimal? FF_SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CUSTOMER_CONSIGNEE_ID { get; set; }
        public decimal? FF_CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? CUSTOMER_NOTIFIER_ID { get; set; }
        public decimal? FF_NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal? START_CITY_ID { get; set; }
        public decimal? DEST_CITY_ID { get; set; }
        public decimal? TEU { get; set; }
        public decimal? LOAD_TEU { get; set; }
        public string CONTA_DESC { get; set; }
        public string ORDER_REMARK { get; set; }
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_MOBILE { get; set; }
        public decimal? SPECIARATE_STATUS { get; set; }
        public string SPECIARATE_REMARK_REQUEST { get; set; }
        public string SPECIARATE_REMARK_REPLY { get; set; }
        public decimal STATUS { get; set; }
        public decimal TRAILER_STATUS { get; set; }
        public decimal? BILL_STATUS { get; set; }
        public decimal? SI_STATUS { get; set; }
        public decimal? BL_STATUS { get; set; }
        public decimal? RELEASE_STATUS { get; set; }
        public decimal? RELEASE_USERID { get; set; }
        public string RELEASE_FULLNAME { get; set; }
        public DateTime? RELEASE_DATE { get; set; }
        public string RELEASE_REMARK { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public decimal? BUSINESS_USER_ID { get; set; }
        public decimal? SERVICE_USER_ID { get; set; }
        public decimal? OVERSEA_AGENCY_ID { get; set; }
        public decimal? AGENCY_COMAPNY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
