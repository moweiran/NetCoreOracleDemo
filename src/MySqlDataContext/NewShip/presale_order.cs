using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class presale_order
    {
        public long PRESALE_ORDER_ID { get; set; }
        public long PAENT_ORDER_ID { get; set; }
        public long MAIN_ORDER_ID { get; set; }
        public long FF_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public long? CARRIER_COMPANY_ID { get; set; }
        public int CUSTOMER_TYPE { get; set; }
        public long CUSTOMER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public long PRESALE_RATE_ID { get; set; }
        public long? SHIP_ROUTE_AREA_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long PRODUCT_ID { get; set; }
        public int PRODUCT_TYPE { get; set; }
        public int? CLOSE_TIME { get; set; }
        public int? LEAVE_TIME { get; set; }
        public int? TT { get; set; }
        public long WEEK_ID { get; set; }
        public long RECEIPT_ID { get; set; }
        public long RECEIPT_CITY_ID { get; set; }
        public long POL_ID { get; set; }
        public long POL_CITY_ID { get; set; }
        public long POD_ID { get; set; }
        public long POD_CITY_ID { get; set; }
        public long DELIVERY_ID { get; set; }
        public long DELIVERY_CITY_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public int PRE_TEU { get; set; }
        public int USE_TEU { get; set; }
        public int CANCEL_TEU { get; set; }
        public int CHANGE_TEU { get; set; }
        public int SURPLUS_TEU { get; set; }
        public int OW_PRE_TEU { get; set; }
        public int OW_USE_TEU { get; set; }
        public int OW_CANCEL_TEU { get; set; }
        public int OW_CHANGE_TEU { get; set; }
        public int OW_SURPLUS_TEU { get; set; }
        public int CHANGE_TIME { get; set; }
        public string ORDER_REMARK { get; set; }
        public string LINKER_NAME { get; set; }
        public string LINKER_EMAIL { get; set; }
        public string LINKER_TEL { get; set; }
        public string LINKER_FAX { get; set; }
        public string LINKER_ADDRESS { get; set; }
        public int ORDER_SOURCE { get; set; }
        public int STATUS { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
