using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class ship_route_staff
    {
        public long SHIP_ROUTE_STAFF_ID { get; set; }
        public long USER_ID { get; set; }
        public string USER_ACCOUNT { get; set; }
        public string USER_CODE { get; set; }
        public string USER_FULLNAME { get; set; }
        public string USER_TEL { get; set; }
        public string USER_EMAIL { get; set; }
        public long? USER_COMPANY_ID { get; set; }
        public string USER_COMPANY_NAME { get; set; }
        public int? USER_TYPE { get; set; }
        public string SHIP_ROUTE_CODE { get; set; }
        public string SHIP_ROUTE_SHORT_CODE { get; set; }
        public string SHIP_ROUTE_NAME { get; set; }
        public string SHIP_ROUTE_PORT_CODE { get; set; }
        public short? COURSE { get; set; }
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
        public long SHIP_ROUTE_ID { get; set; }
        public long CARRIER_ID { get; set; }
    }
}
