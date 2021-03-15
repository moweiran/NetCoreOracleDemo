using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class b_products
    {
        public long PRODUCT_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public string PRODUCT_NO { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public int? BERTH_WEEK { get; set; }
        public int CLOSE { get; set; }
        public int DEPARTURE { get; set; }
        public int PRODUCT_TYPE { get; set; }
        public int TT { get; set; }
        public string RECEIPT_CODE { get; set; }
        public string RECEIPT_ENAME { get; set; }
        public string RECEIPT_CNAME { get; set; }
        public long RECEIPT_CITY_ID { get; set; }
        public string RECEIPT_CITY_ENAME { get; set; }
        public string RECEIPT_CITY_CNAME { get; set; }
        public string RECEIPT_COUNTRY_CODE { get; set; }
        public string RECEIPT_COUNTRY_NAME { get; set; }
        public string POL_CODE { get; set; }
        public string POL_ENAME { get; set; }
        public string POL_CNAME { get; set; }
        public long POL_CITY_ID { get; set; }
        public string POL_CITY_ENAME { get; set; }
        public string POL_CITY_CNAME { get; set; }
        public string POL_COUNTRY_CODE { get; set; }
        public string POL_COUNTRY_NAME { get; set; }
        public string VIA_CODE { get; set; }
        public string VIA_NAME { get; set; }
        public long? VIA_CITY_ID { get; set; }
        public string VIA_CITY_NAME { get; set; }
        public string POD_CODE { get; set; }
        public string POD_ENAME { get; set; }
        public string POD_CNAME { get; set; }
        public long POD_CITY_ID { get; set; }
        public string POD_CITY_ENAME { get; set; }
        public string POD_CITY_CNAME { get; set; }
        public string POD_COUNTRY_CODE { get; set; }
        public string POD_COUNTRY_NAME { get; set; }
        public string DELIVERY_CODE { get; set; }
        public string DELIVERY_ENAME { get; set; }
        public string DELIVERY_CNAME { get; set; }
        public long DELIVERY_CITY_ID { get; set; }
        public string DELIVERY_CITY_ENAME { get; set; }
        public string DELIVERY_CITY_NAME { get; set; }
        public string DELIVERY_COUNTRY_CODE { get; set; }
        public string DELIVERY_COUNTRY_NAME { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRANS_TYPE_ENAME { get; set; }
        public string TRANS_TYPE_CNAME { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public decimal? GP20_REEFER { get; set; }
        public decimal? GP40_REEFER { get; set; }
        public decimal? HQ40_REEFER { get; set; }
        public decimal? GP45_REEFER { get; set; }
        public decimal? TON { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
        public long? CREATEBY { get; set; }
        public int STATUS { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public int? COURSE { get; set; }
        public long? SHIP_ROUTE_AREA_ID { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string SHIP_ROUTE_AREA_NAME { get; set; }
        public long? FIRST_ROUTE_ID { get; set; }
        public int? VOYAGE_COUNT { get; set; }
        public int? TOTAL_DAY { get; set; }
        public int? AVG_TT { get; set; }
        public decimal? PUNCTUAL_RATE { get; set; }
        public bool IS_FF_CONFIRM { get; set; }
        public long TRUNK_ID { get; set; }
        public byte IS_TRUNK { get; set; }
        public string FRONT_FEE_ASSIGN_ID { get; set; }
        public string BACK_FEE_ASSIGN_ID { get; set; }
        public long? CALISTA_RECEIPT_ID { get; set; }
        public long? CALISTA_POL_ID { get; set; }
        public long? CALISTA_POD_ID { get; set; }
        public long? CALISTA_DELIVERY_ID { get; set; }
        public string CALISTA_SCAC { get; set; }
        public long RECEIPT_ID { get; set; }
        public long POL_ID { get; set; }
        public long POD_ID { get; set; }
        public long DELIVERY_ID { get; set; }
        public long VALID { get; set; }
        public long RECEIPT_COUNTRY_ID { get; set; }
        public long POL_COUNTRY_ID { get; set; }
        public long POD_COUNTRY_ID { get; set; }
        public long DELIVERY_COUNTRY_ID { get; set; }
    }
}
