using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_ORDER
    {
        public decimal FF_ECL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal PARENT_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string REF_NO { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal ECL_RATE_ID { get; set; }
        public decimal ECL_TYPE { get; set; }
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
        public string REMARK { get; set; }
        public decimal? SPECIARATE_STATUS { get; set; }
        public string SPECIARATE_REMARK_REQUEST { get; set; }
        public string SPECIARATE_REMARK_REPLY { get; set; }
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
        public decimal? BUSINESS_USER_ID { get; set; }
        public decimal? SERVICE_USER_ID { get; set; }
        public decimal? OVERSEA_AGENCY_ID { get; set; }
        public decimal? AGENCY_COMAPNY_ID { get; set; }
        public string CUSTOMER_REF_NO { get; set; }
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_MOBILE { get; set; }
        public string LINKER_ADDRESS { get; set; }
        public string SHIPPER_COMPANY { get; set; }
        public string SHIPPER_ADDRESS { get; set; }
        public decimal? PACK_TYPE { get; set; }
        public string SERVICE_PROMISE { get; set; }
        public string CHANNEL { get; set; }
        public decimal? COMMISSION_RATE { get; set; }
        public bool? IS_REFUND { get; set; }
        public bool? IS_INSURANCE { get; set; }
        public decimal? INSURANCE_AMOUNT { get; set; }
        public string INSURANCE_CURRENCY { get; set; }
        public decimal? CONSIGNEE_STATE_ID { get; set; }
        public decimal? CONSIGNEE_CITY_ID { get; set; }
        public string CONSIGNEE_ZIP { get; set; }
        public decimal? CARGO_LENGTH { get; set; }
        public decimal? CARGO_WIDTH { get; set; }
        public decimal? CARGO_HEIGHT { get; set; }
        public string CONSIGNEE_STATE_ENAME { get; set; }
        public string CONSIGNEE_CITY_ENAME { get; set; }
        public string CONSIGNEE_STATE_CNAME { get; set; }
        public string CONSIGNEE_CITY_CNAME { get; set; }
        public decimal? ORDER_SOURCE { get; set; }
        public string PLATFORM_ORDER_ID { get; set; }
        public int? CONTAINER_COUNT { get; set; }
    }
}
