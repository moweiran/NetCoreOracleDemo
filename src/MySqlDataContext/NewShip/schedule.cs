using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class schedule
    {
        public long SCHEDULE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public int? YEARS { get; set; }
        public int? WEEKS { get; set; }
        public long SHIP_ROUTE_ID { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public string SHIP_ROUTE_NAME { get; set; }
        public int SCHEDULE_TYPE { get; set; }
        public long VESSEL_ID { get; set; }
        public string SHIP_OWNER_NAME_CN { get; set; }
        public string SHIP_OWNER_NAME_EN { get; set; }
        public string VESSEL_CODE { get; set; }
        public string VESSEL_NAME { get; set; }
        public string CALLSIGN { get; set; }
        public string VOYAGE_GO { get; set; }
        public string VOYAGE_BACK { get; set; }
        public int COURSE { get; set; }
        public string SHIP_OWNER_ROUTE { get; set; }
        public int VESSEL_TYPE { get; set; }
        public string REMARK { get; set; }
        public byte VALID { get; set; }
        public byte DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public string VOYAGE { get; set; }
        public int STATUS { get; set; }
        public string VESSEL_NAME_CN { get; set; }
        public string VESSEL_OWNER { get; set; }
        public int TEU { get; set; }
        public string MD5_VALIDATE { get; set; }
        public long? VOYAGEID { get; set; }
    }
}
