using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER
    {
        public BOOKING_ORDER()
        {
            BOOKING_ORDER_OTHER = new HashSet<BOOKING_ORDER_OTHER>();
            BOOKING_ORDER_RATE = new HashSet<BOOKING_ORDER_RATE>();
            BOOKING_ORDER_SURCHARGE = new HashSet<BOOKING_ORDER_SURCHARGE>();
        }

        public decimal BOOKING_ORDER_ID { get; set; }
        public string BOOKING_ORDER_GUID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal PARENT_BOOKING_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal BOOKING_RATE_SOURCE { get; set; }
        public decimal? BOOKING_SUPPLIER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? CARRIER_COMPANY_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public decimal? SALES_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string BOOKING_NO { get; set; }
        public string BATCH_NO { get; set; }
        public decimal RATE_ID { get; set; }
        public string CONTRACT_NO { get; set; }
        public string FORWARD_RF_NO { get; set; }
        public string CUSTOMER_RF_NO { get; set; }
        public string BL_TYPE { get; set; }
        public string RELEASE_MODE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public string PAY_LOCATION { get; set; }
        public decimal? CUSTOMER_SHIPPER_ID { get; set; }
        public decimal? FF_SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CUSTOMER_CONSIGNEE_ID { get; set; }
        public decimal? FF_CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? CUSTOMER_NOTIFIER_ID { get; set; }
        public decimal? FF_NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public decimal TT { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public DateTime? CLOSE_DT { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETD { get; set; }
        public decimal? PRODUCT_DEMAND_ID { get; set; }
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
        public decimal? WEIGHT { get; set; }
        public string WEIGHT_UNIT { get; set; }
        public decimal? CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public decimal? TEU { get; set; }
        public decimal? LOAD_TEU { get; set; }
        public string ORDER_REMARK { get; set; }
        public decimal? SPLIT_PARENT_ID { get; set; }
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_FAX { get; set; }
        public string LINKER_ADDRESS { get; set; }
        public decimal? FREEDETENTIONN_STATUS { get; set; }
        public string FREEDETENTIONN_REMARK_REQUEST { get; set; }
        public string FREEDETENTIONN_REMARK_REPLY { get; set; }
        public decimal? SPECIARATE_STATUS { get; set; }
        public string SPECIARATE_REMARK_REQUEST { get; set; }
        public string SPECIARATE_REMARK_REPLY { get; set; }
        public decimal STATUS { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public decimal? APPROVED_ID { get; set; }
        public string APPROVED_FULLNAME { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public decimal? BOOKING_UPDATE_MODEL { get; set; }
        public string BOOKING_UPDATE_FULLNAME { get; set; }
        public DateTime BOOKING_UPDATE_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? IS_ORDERLIST_SHOWTOP { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal TRAILER_STATUS { get; set; }
        public decimal? VGM_STATUS { get; set; }
        public decimal? LAND_PRODUCT_PATH_ID { get; set; }
        public decimal? LAND_RECEIPT_ID { get; set; }
        public decimal? LAND_RECEIPT_CITY_ID { get; set; }
        public decimal? LAND_DELIVERY_ID { get; set; }
        public decimal? LAND_DELIVERY_CITY_ID { get; set; }
        public decimal? BILL_STATUS { get; set; }
        public decimal? PRODUCT_DEMAND_SUPPLIER_ID { get; set; }
        public decimal? SI_STATUS { get; set; }
        public decimal? RELEASE_STATUS { get; set; }
        public decimal? BUSINESS_USER_ID { get; set; }
        public decimal? SERVICE_USER_ID { get; set; }
        public decimal? OVERSEA_AGENCY_ID { get; set; }
        public decimal? AGENCY_COMAPNY_ID { get; set; }
        public decimal? BL_STATUS { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
        public string CONTA_DESC { get; set; }
        public string LINKER_MOBILE { get; set; }
        public decimal? COMMISSION_RATE { get; set; }
        public decimal? CALISTA_STATUS { get; set; }

        public virtual ICollection<BOOKING_ORDER_OTHER> BOOKING_ORDER_OTHER { get; set; }
        public virtual ICollection<BOOKING_ORDER_RATE> BOOKING_ORDER_RATE { get; set; }
        public virtual ICollection<BOOKING_ORDER_SURCHARGE> BOOKING_ORDER_SURCHARGE { get; set; }
    }
}
