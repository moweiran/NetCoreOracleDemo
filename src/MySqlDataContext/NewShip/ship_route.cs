using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route
    {
        public ship_route()
        {
            ship_route_ports = new HashSet<ship_route_ports>();
            ship_route_products = new HashSet<ship_route_products>();
        }

        public long SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public int VALID { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual ICollection<ship_route_ports> ship_route_ports { get; set; }
        public virtual ICollection<ship_route_products> ship_route_products { get; set; }
    }
}
