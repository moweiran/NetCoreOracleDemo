using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_IMPORT
    {
        public decimal FF_ECL_IMPORT_ID { get; set; }
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
        public decimal? BUSINESS_USER_ID { get; set; }
        public decimal? SERVICE_USER_ID { get; set; }
        public string REF_NO { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_COUNTRY_ID { get; set; }
        public string DEST_AREA { get; set; }
        public decimal CHARGE_UNIT { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal? CHAGE_QTY { get; set; }
        public decimal WEIGHT { get; set; }
        public decimal CBM { get; set; }
        public string SHIPPER_CONTACTS { get; set; }
        public string SHIPPER_TEL { get; set; }
        public decimal ORDER_TYPE { get; set; }
        public decimal? FBA_ID { get; set; }
        public string FBA_REF_ID { get; set; }
        public string FBA_SHIP_ID { get; set; }
        public string CONSIGNEE_ADDRESS { get; set; }
        public string CONSIGNEE_CONTACTS { get; set; }
        public string CONSIGNEE_TEL { get; set; }
        public string RECEIPT_WAREHOUSE { get; set; }
        public DateTime? RECEIPT_DATE { get; set; }
        public decimal? TRANSPORT_COMPANY_TYPE { get; set; }
        public decimal? TRANSPORT_COMPANY_ID { get; set; }
        public string TRANSPORT_COMPANY_CODE { get; set; }
        public string TRANSPORT_COMPANY_CNAME { get; set; }
        public string TRANSPORT_COMPANY_ENAME { get; set; }
        public string BOOKING_NO { get; set; }
        public string CONTAINER_NO { get; set; }
        public string TRANSPORT_NO { get; set; }
        public string TRANSPORT_CLASS { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public decimal? AFTER_EXPRESS_ID { get; set; }
        public string AFTER_EXPRESS_NO { get; set; }
        public DateTime? AFTER_EXPRESS_STARTDATE { get; set; }
        public DateTime? AFTER_EXPRESS_ENDDATE { get; set; }
        public string REMARK { get; set; }
        public decimal? OVERSEA_AGENCY_ID { get; set; }
        public decimal? AGENCY_COMAPNY_ID { get; set; }
        public decimal STATUS { get; set; }
        public decimal? BILL_STATUS { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal ECL_TYPE { get; set; }
        public string SHIPPER_COMPANY { get; set; }
        public string SHIPPER_ADDRESS { get; set; }
        public decimal? PACK_TYPE { get; set; }
        public string CONSIGNEE_STATE_ENAME { get; set; }
        public string CONSIGNEE_CITY_ENAME { get; set; }
        public string CONSIGNEE_ZIP { get; set; }
        public string CHANNEL { get; set; }
    }
}
