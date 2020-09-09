using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class SHIP_ROUTE_AREA
    {
        public SHIP_ROUTE_AREA()
        {
            SHIP_ROUTE_AREA_PORT = new HashSet<SHIP_ROUTE_AREA_PORT>();
        }

        public decimal SHIP_ROUTE_AREA_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public string CARRIER_SHORT_NAME { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string SHIP_ROUTE_AREA_NAME { get; set; }
        public string REMARK { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? PARENT_ID { get; set; }

        public virtual ICollection<SHIP_ROUTE_AREA_PORT> SHIP_ROUTE_AREA_PORT { get; set; }
    }
}
