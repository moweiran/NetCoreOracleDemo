using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
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
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
