using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class booking_order
    {
        public long BOOKING_ORDER_ID { get; set; }
        public string BOOKING_ORDER_GUID { get; set; }
        public long FF_BOOKING_ORDER_ID { get; set; }
        public long FF_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public long? CARRIER_COMPANY_ID { get; set; }
        public int CUSTOMER_TYPE { get; set; }
        public long CUSTOMER_ID { get; set; }
        public long? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string BOOKING_NO { get; set; }
        public long RATE_ID { get; set; }
        public string CONTRACT_NO { get; set; }
        public string RELEASE_MODE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public string PAY_LOCATION { get; set; }
        public string SHIPPER_DESC { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long SCHEDULE_ID { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public int TT { get; set; }
        public int WEEK_ID { get; set; }
        public long PRODUCT_ID { get; set; }
        public long LAND_PRODUCT_PATH_ID { get; set; }
        public DateTime? CLOSE_DT { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public long? LAND_RECEIPT_ID { get; set; }
        public long? LAND_RECEIPT_CITY_ID { get; set; }
        public long? RECEIPT_ID { get; set; }
        public long? RECEIPT_CITY_ID { get; set; }
        public long? POL_ID { get; set; }
        public long? POL_CITY_ID { get; set; }
        public long? POD_ID { get; set; }
        public long? POD_CITY_ID { get; set; }
        public long? DELIVERY_ID { get; set; }
        public long? DELIVERY_CITY_ID { get; set; }
        public long? LAND_DELIVERY_ID { get; set; }
        public long? LAND_DELIVERY_CITY_ID { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal? WEIGHT { get; set; }
        public string WEIGHT_UNIT { get; set; }
        public decimal? CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public int? TEU { get; set; }
        public int? LOAD_TEU { get; set; }
        public string ORDER_REMARK { get; set; }
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_FAX { get; set; }
        public string LINKER_ADDRESS { get; set; }
        public int? FREEDETENTIONN_STATUS { get; set; }
        public string FREEDETENTIONN_REMARK_REQUEST { get; set; }
        public string FREEDETENTIONN_REMARK_REPLY { get; set; }
        public int? SPECIARATE_STATUS { get; set; }
        public string SPECIARATE_REMARK_REQUEST { get; set; }
        public string SPECIARATE_REMARK_REPLY { get; set; }
        public int STATUS { get; set; }
        public int TRAILER_STATUS { get; set; }
        public int? VGM_STATUS { get; set; }
        public int? BILL_STATUS { get; set; }
        public int? SI_STATUS { get; set; }
        public int? BL_STATUS { get; set; }
        public int? RELEASE_STATUS { get; set; }
        public long? RELEASE_USERID { get; set; }
        public string RELEASE_FULLNAME { get; set; }
        public DateTime? RELEASE_DATE { get; set; }
        public string RELEASE_REMARK { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
