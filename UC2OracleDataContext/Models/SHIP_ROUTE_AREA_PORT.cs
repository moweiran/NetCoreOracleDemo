using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class SHIP_ROUTE_AREA_PORT
    {
        public decimal SHIP_ROUTE_AREA_PORT_ID { get; set; }
        public decimal SHIP_ROUTE_AREA_ID { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string PORT_CODE { get; set; }
        public string PORT_NAME_EN { get; set; }
        public string PORT_NAME_CN { get; set; }
        public string PORT_COUNTRY_CODE { get; set; }
        public string PORT_COUNTRY_NAME { get; set; }

        public virtual SHIP_ROUTE_AREA SHIP_ROUTE_AREA_ { get; set; }
    }
}
