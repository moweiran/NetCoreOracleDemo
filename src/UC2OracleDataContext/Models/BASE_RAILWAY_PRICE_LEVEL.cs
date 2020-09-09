using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_RAILWAY_PRICE_LEVEL
    {
        public BASE_RAILWAY_PRICE_LEVEL()
        {
            BASE_RAILWAY_PRICE_LEV_DET = new HashSet<BASE_RAILWAY_PRICE_LEV_DET>();
        }

        public decimal BASE_RAILWAY_PRICE_LEVEL_ID { get; set; }
        public decimal COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal? CITY_ID { get; set; }
        public decimal CLASS { get; set; }
        public decimal GP20_LOWER { get; set; }
        public decimal GP20_UPPER { get; set; }
        public decimal GP40_LOWER { get; set; }
        public decimal GP40_UPPER { get; set; }
        public decimal GP45_LOWER { get; set; }
        public decimal GP45_UPPER { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public decimal DELETE_MARK { get; set; }
        public decimal MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public decimal GP20_DOUBLE_LOWER { get; set; }
        public decimal GP20_DOUBLE_UPPER { get; set; }

        public virtual BASE_CITYS CITY_ { get; set; }
        public virtual BASE_COUNTRY COUNTRY_ { get; set; }
        public virtual BASE_PROVINCES PROVINCE_ { get; set; }
        public virtual ICollection<BASE_RAILWAY_PRICE_LEV_DET> BASE_RAILWAY_PRICE_LEV_DET { get; set; }
    }
}
