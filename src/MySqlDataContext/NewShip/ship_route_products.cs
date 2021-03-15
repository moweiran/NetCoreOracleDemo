using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_products
    {
        public long SHIP_ROUTE_PRODUCT_ID { get; set; }
        public long SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long DEPARTURE_PORT_ID { get; set; }
        public long? DEPARTURE_CITY_ID { get; set; }
        public long? DEPARTURE_COUNT_ID { get; set; }
        public long ARRIVE_PORT_ID { get; set; }
        public long? ARRIVE_CITY_ID { get; set; }
        public long? ARRIVE_COUNT_ID { get; set; }
        public int? TT { get; set; }
        public int? CLOSE_TIME { get; set; }
        public int? LEAVE_TIME { get; set; }
        public int VALID { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual ship_route SHIP_ROUTE { get; set; }
    }
}
