using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class SHIP_ROUTE_AREA_CITY
    {
        public decimal SHIP_ROUTE_AREA_CITY_ID { get; set; }
        public decimal SHIP_ROUTE_AREA_ID { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public decimal CITY_ID { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string CITY_COUNTRY_CODE { get; set; }
        public string CITY_COUNTRY_NAME { get; set; }
    }
}
