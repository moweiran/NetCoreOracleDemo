using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class rate_land
    {
        public long RATE_LAND_ID { get; set; }
        public long LAND_FEE_ID { get; set; }
        public long LAND_FEE_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public long PORT_ID { get; set; }
        public long LAND_CITY_ID { get; set; }
        public int BUSINESS_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
