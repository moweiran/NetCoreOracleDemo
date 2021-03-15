using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_HOMEPAGE_CONFIGURE
    {
        public decimal BASE_HOMEPAGE_CONFIGURE_ID { get; set; }
        public decimal? ALLIANCE_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal? TOP_LOGOID { get; set; }
        public decimal? BOTTON_LOGOID { get; set; }
        public string CONTACTS { get; set; }
        public string DESCRIBE_LOCAL { get; set; }
        public string DESCRIBE_EN { get; set; }
        public decimal? RATESEARCH_FCL_INDEX { get; set; }
        public decimal? RATESEARCH_LCL_INDEX { get; set; }
        public decimal? RATESEARCH_AIR_INDEX { get; set; }
        public decimal? RATESEARCH_TRUCKING_INDEX { get; set; }
        public decimal? RATESEARCH_ECL_INDEX { get; set; }
        public decimal? RATESEARCH_FBA_INDEX { get; set; }
        public string RATESEARCH_FCL_CITYS { get; set; }
        public string RATESEARCH_LCL_CITYS { get; set; }
        public string RATESEARCH_AIR_CITYS { get; set; }
        public string RATESEARCH_ECL_CITYS { get; set; }
        public string RATESEARCH_FBA_CITYS { get; set; }
        public bool? MENU_RATESEARCH_SHOW { get; set; }
        public decimal? MENU_RATESEARCH_INDEX { get; set; }
        public bool? MENU_TOOLS_SHOW { get; set; }
        public decimal? MENU_TOOLS_INDEX { get; set; }
        public bool? MENU_RESOURCE_SHOW { get; set; }
        public decimal? MENU_RESOURCE_INDEX { get; set; }
        public string RECORD_INFO { get; set; }
        public string COPYRIGHT_INFO { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string RECORD_LINK { get; set; }
        public bool? RECORD_SHOW { get; set; }
        public decimal? RATE_SEARCH_CHARTERING_INDEX { get; set; }
        public bool? RATESEARCH_FCL_ENABLED { get; set; }
        public bool? RATESEARCH_LCL_ENABLED { get; set; }
        public bool? RATESEARCH_AIR_ENABLED { get; set; }
        public bool? RATESEARCH_TRUCKING_ENABLED { get; set; }
        public bool? RATESEARCH_ECL_ENABLED { get; set; }
        public bool? RATESEARCH_FBA_ENABLED { get; set; }
        public bool? RATE_SEARCH_CHARTERING_ENABLED { get; set; }
    }
}
