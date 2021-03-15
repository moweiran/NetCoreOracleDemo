using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class port_by_company
    {
        public long PORT_BY_COMPANY_ID { get; set; }
        public long COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public long BASE_LOCATION_ID { get; set; }
        public string LOCATION_CODE { get; set; }
        public string LOCATION_NAME_EN { get; set; }
        public string LOCATION_NAME_CN { get; set; }
        public long? BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public long? BASE_PROVINCE_ID { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public long? BASE_CITY_ID { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
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
        public long CARRIER_ID { get; set; }
    }
}
