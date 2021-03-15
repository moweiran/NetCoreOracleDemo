using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_OI_ORDER
    {
        public decimal OI_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal OPERATION_TYPE { get; set; }
        public decimal OI_DATA_SOURCE { get; set; }
        public decimal PRE_ORDER_ID { get; set; }
        public decimal? PRE_MAIN_ORDER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal? RATE_ID { get; set; }
        public string REF_NO { get; set; }
        public string BL_TYPE { get; set; }
        public string RELEASE_MODE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public decimal? SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal? ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public decimal TT { get; set; }
        public decimal? PRODUCT_ID { get; set; }
        public DateTime ETD { get; set; }
        public DateTime? ETA { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POD_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public string ORDER_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public decimal TRAILER_STATUS { get; set; }
        public decimal? BILL_STATUS { get; set; }
        public decimal? BL_STATUS { get; set; }
        public decimal? RELEASE_STATUS { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public decimal? APPROVED_ID { get; set; }
        public string APPROVED_FULLNAME { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public decimal? BUSINESS_USER_ID { get; set; }
        public decimal? SERVICE_USER_ID { get; set; }
        public decimal? PRE_AGENCY_ID { get; set; }
        public decimal? PRE_AGENCY_COMAPNY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string DELIVERYTO { get; set; }
    }
}
