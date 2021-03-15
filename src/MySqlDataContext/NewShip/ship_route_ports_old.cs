using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_ports_old
    {
        public long SHIP_ROUTE_PORT_ID { get; set; }
        public long SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public byte COURSE { get; set; }
        public byte SEQUENCE { get; set; }
        public string PORT_CODE { get; set; }
        public string PORT_NAME_EN { get; set; }
        public string PORT_NAME_CN { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME { get; set; }
        public long? BASE_CITY_ID { get; set; }
        public string CITY_NAME { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string DOCK { get; set; }
        public byte? PARK_TIME { get; set; }
        public decimal? WINDOW_TIME_START { get; set; }
        public decimal? WINDOW_TIME_END { get; set; }
        public byte? CLOSE_TIME { get; set; }
        public byte? LEAVE_TIME { get; set; }
        public byte? OPEN_TIME { get; set; }
        public long? MANAGER_ID { get; set; }
        public string MANAGER_CODE { get; set; }
        public string MANAGER_FULLNAME { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public byte? OPEN_DATE { get; set; }
        public byte? CUT_BOOKING_DATE { get; set; }
        public byte? CLOSE_DATE { get; set; }
        public byte? CUT_OFF_DATE { get; set; }
        public byte? CUT_MATERIAL_DATE { get; set; }
        public byte? CUT_VIA_DATE { get; set; }
        public byte? TT { get; set; }
        public byte? TRANSITTIME { get; set; }
        public byte? CUT_VGM_DATE { get; set; }
        public long? CALISTA_PORT_ID { get; set; }
    }
}
