using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_old
    {
        public long SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string CARRIER_NAME { get; set; }
        public string CARRIER_SHORTNAME { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public string SHIP_ROUTE_SHORT_CODE { get; set; }
        public string SHIP_ROUTE_NAME { get; set; }
        public string SHIP_ROUTE_CIRCLE_CODE { get; set; }
        public string SHIP_ROUTE_CIRCLE_NAME { get; set; }
        public long? MANAGER_ID { get; set; }
        public string MANAGER_CODE { get; set; }
        public string MANAGER_FULLNAME { get; set; }
        public string SALEMAN { get; set; }
        public string LINE_BUSI_TYPE { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string SHIP_ROUTE_AREA_NAME { get; set; }
        public int? BERTH_WEEK { get; set; }
        public int? FREQUENCY { get; set; }
        public int? SPAN { get; set; }
        public int? DAYS { get; set; }
        public string PICTURE { get; set; }
        public bool? NEGATIVE_FREIGHT { get; set; }
        public byte? RATE_RULE { get; set; }
        public string REMARK { get; set; }
        public bool VALID { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? MODIFY_COMPANYID { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long? CREATE_COMPANYID { get; set; }
        public long? SHIP_ROUTE_AREA_ID { get; set; }
        public string COURSE { get; set; }
    }
}
