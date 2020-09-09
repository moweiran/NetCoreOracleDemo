using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class LOC_IM_TODO_BAK
    {
        public decimal? BASE_LOCATION_ID { get; set; }
        public decimal? BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public decimal? BASE_PROVINCE_ID { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public decimal? BASE_CITY_ID { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string LOCATION_CODE { get; set; }
        public string LOCATION_NAME_EN { get; set; }
        public string LOCATION_NAME_CN { get; set; }
        public string AREA_CODE { get; set; }
        public string AREA_NAME_CN { get; set; }
        public string AREA_NAME_EN { get; set; }
        public decimal? PORT_TYPE_CODE { get; set; }
        public string PORT_TYPE_NAME { get; set; }
        public string REMARK { get; set; }
        public string COORDINATES { get; set; }
        public bool? IS_ISO { get; set; }
        public bool? IS_PORT { get; set; }
        public bool? IS_RAILTERMINAL { get; set; }
        public bool? IS_ROADTERMINAL { get; set; }
        public bool? IS_AIRPORT { get; set; }
        public bool? IS_POSTAL { get; set; }
        public bool? IS_FIXED { get; set; }
        public bool? IS_INLAND { get; set; }
        public bool? IS_BORDER { get; set; }
        public bool? IS_OTHER { get; set; }
        public string UNCODE { get; set; }
        public string DKCODE { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
        public decimal? SEQUENCE { get; set; }
    }
}
