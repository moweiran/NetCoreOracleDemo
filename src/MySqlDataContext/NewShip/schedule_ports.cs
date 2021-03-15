using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class schedule_ports
    {
        public long SCHEDULE_PORT_ID { get; set; }
        public long SCHEDULE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public int? YEARS { get; set; }
        public int? WEEKS { get; set; }
        public long SHIP_ROUTE_ID { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public string SHIP_ROUTE_NAME { get; set; }
        public string VESSEL_CODE { get; set; }
        public string VESSEL_NAME { get; set; }
        public string CALLSIGN { get; set; }
        public string VOYAGE { get; set; }
        public int COURSE { get; set; }
        public int SEQUENCE { get; set; }
        public long? PREVIOUS_PORT_ID { get; set; }
        public long? NEXT_PORT_ID { get; set; }
        public string PORT_CODE { get; set; }
        public string PORT_NAME_CN { get; set; }
        public string PORT_NAME_EN { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME { get; set; }
        public long? BASE_CITY_ID { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public int? TRANSIT_TIME { get; set; }
        public int? PARK_TIME { get; set; }
        public int? OPEN_TIME { get; set; }
        public string DOCK { get; set; }
        public string BERTH { get; set; }
        public int PHASE { get; set; }
        public int STATUS { get; set; }
        public byte DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public int? WINDOW_TIME_START { get; set; }
        public int? WINDOW_TIME_END { get; set; }
        public decimal? TRANSITTIME { get; set; }
        public string DEST_PORT_CODE { get; set; }
        public string MD5_VALIDATE { get; set; }
        public byte IS_EXTEND { get; set; }
        public int EXTEND_TYPE { get; set; }
        public byte REPEAT_PORT { get; set; }
        public long? VOYAGESTOPID { get; set; }
        public long? CALISTA_PORT_ID { get; set; }
    }
}
