using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AIR_ORDER
    {
        public FF_AIR_ORDER()
        {
            FF_AIR_ORDER_BOOKING = new HashSet<FF_AIR_ORDER_BOOKING>();
            FF_AIR_ORDER_CHARGE = new HashSet<FF_AIR_ORDER_CHARGE>();
            FF_AIR_ORDER_DESTFEE = new HashSet<FF_AIR_ORDER_DESTFEE>();
        }

        public decimal AIR_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal PARENT_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal BOOKING_RATE_SOURCE { get; set; }
        public decimal? BOOKING_SUPPLIER_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal AIR_PRODUCT_ID { get; set; }
        public decimal AIR_RATE_ID { get; set; }
        public string FF_REF_NO { get; set; }
        public string CUSTOMER_RF_NO { get; set; }
        public string AIR_BL_TYPE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public string PAY_LOCATION { get; set; }
        public decimal? CUSTOMER_SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CUSTOMER_CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? CUSTOMER_NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? RECEIPT_CITY_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POL_CITY_ID { get; set; }
        public decimal? POD_ID { get; set; }
        public decimal? POD_CITY_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal? DELIVERY_CITY_ID { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal WEIGHT { get; set; }
        public decimal CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public decimal CHARGE_WEIGHT { get; set; }
        public string ORDER_REMARK { get; set; }
        public decimal? SPECIARATE_STATUS { get; set; }
        public string SPECIARATE_REMARK_REQUEST { get; set; }
        public string SPECIARATE_REMARK_REPLY { get; set; }
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
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_MOBILE { get; set; }
        public string LINKER_ADDRESS { get; set; }
        public decimal? COMMISSION_RATE { get; set; }
        public int? CONTAINER_COUNT { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
        public decimal? BL_STATUS { get; set; }
        public decimal? SI_STATUS { get; set; }

        public virtual ICollection<FF_AIR_ORDER_BOOKING> FF_AIR_ORDER_BOOKING { get; set; }
        public virtual ICollection<FF_AIR_ORDER_CHARGE> FF_AIR_ORDER_CHARGE { get; set; }
        public virtual ICollection<FF_AIR_ORDER_DESTFEE> FF_AIR_ORDER_DESTFEE { get; set; }
    }
}
