using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_products_old
    {
        public long SHIP_ROUTE_PRODUCT_ID { get; set; }
        public long? SHIP_ROUTE_ID { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public string SHIP_ROUTE_NAME { get; set; }
        public long CARRIER_ID { get; set; }
        public long DEPARTURE_PORT_ID { get; set; }
        public string DEPARTURE_CODE { get; set; }
        public string DEPARTURE_NAME_CN { get; set; }
        public string DEPARTURE_NAME_EN { get; set; }
        public string DEPARTURE_COUNTRY_CODE { get; set; }
        public string DEPARTURE_COUNTRY_ENAME { get; set; }
        public string DEPARTURE_COUNTRY_CNAME { get; set; }
        public string DEPARTURE_PROVINCE_CODE { get; set; }
        public string DEPARTURE_PROVINCE_NAME { get; set; }
        public long DEPARTURE_CITY_ID { get; set; }
        public string DEPARTURE_CITY_ENAME { get; set; }
        public string DEPARTURE_CITY_CNAME { get; set; }
        public long ARRIVE_PORT_ID { get; set; }
        public string ARRIVE_CODE { get; set; }
        public string ARRIVE_NAME_CN { get; set; }
        public string ARRIVE_NAME_EN { get; set; }
        public string ARRIVE_COUNTRY_CODE { get; set; }
        public string ARRIVE_COUNTRY_ENAME { get; set; }
        public string ARRIVE_COUNTRY_CNAME { get; set; }
        public string ARRIVE_PROVINCE_CODE { get; set; }
        public string ARRIVE_PROVINCE_NAME { get; set; }
        public long ARRIVE_CITY_ID { get; set; }
        public string ARRIVE_CITY_ENAME { get; set; }
        public string ARRIVE_CITY_CNAME { get; set; }
        public byte CLOSE { get; set; }
        public byte DEPARTURE { get; set; }
        public byte? TT { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public decimal? GP20_REEFER { get; set; }
        public decimal? GP40_REEFER { get; set; }
        public decimal? HQ40_REEFER { get; set; }
        public decimal? GP45_REEFER { get; set; }
        public string CURRENCY { get; set; }
        public bool PUBLISHED { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public byte COURSE { get; set; }
        public int? VOYAGE_COUNT { get; set; }
        public int? TOTAL_DAY { get; set; }
        public byte? AVG_TT { get; set; }
        public decimal? PUNCTUAL_RATE { get; set; }
        public long? SHIP_ROUTE_AREA_ID { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string SHIP_ROUTE_AREA_NAME { get; set; }
        public byte SEQ { get; set; }
        public bool VALID { get; set; }
        public string CALISTA_SCAC { get; set; }
        public long? DEPARTURE_CALIST_PORT_ID { get; set; }
        public long? ARRIVE_CALISTA_PORT_ID { get; set; }
        public bool? IS_TRANS { get; set; }
    }
}
