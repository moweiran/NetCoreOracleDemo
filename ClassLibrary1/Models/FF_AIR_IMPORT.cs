using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_AIR_IMPORT
    {
        public decimal AIR_IMPORT_ID { get; set; }
        public decimal OI_DATA_SOURCE { get; set; }
        public decimal PRE_ORDER_ID { get; set; }
        public decimal? PRE_MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public string FLIGHT_NO { get; set; }
        public DateTime ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string MAWB_NO { get; set; }
        public string HAWB_NO { get; set; }
        public decimal AIR_PRODUCT_ID { get; set; }
        public decimal AIR_RATE_ID { get; set; }
        public string REF_NO { get; set; }
        public string AIR_BL_TYPE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public string PAY_LOCATION { get; set; }
        public decimal? SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal WEIGHT { get; set; }
        public decimal CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public string ORDER_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public decimal? BILL_STATUS { get; set; }
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
