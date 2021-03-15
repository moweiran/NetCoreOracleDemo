using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class product_main
    {
        public long PRODUCT_MAIN_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public long TRUNK_ID { get; set; }
        public long POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public long POL_CITY_ID { get; set; }
        public long? VIA_ID { get; set; }
        public string VIA_CODE { get; set; }
        public long? VIA_CITY_ID { get; set; }
        public long POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public long POD_CITY_ID { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
