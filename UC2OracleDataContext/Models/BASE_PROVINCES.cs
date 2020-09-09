using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_PROVINCES
    {
        public BASE_PROVINCES()
        {
            BASE_RAILWAY_PRICE_LEVEL = new HashSet<BASE_RAILWAY_PRICE_LEVEL>();
            BASE_TRAILER_PRICE_LEVEL = new HashSet<BASE_TRAILER_PRICE_LEVEL>();
        }

        public decimal BASE_PROVINCE_ID { get; set; }
        public decimal? BASE_COUNTRY_ID { get; set; }
        public string UNCODE { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
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

        public virtual BASE_COUNTRY BASE_COUNTRY_ { get; set; }
        public virtual ICollection<BASE_RAILWAY_PRICE_LEVEL> BASE_RAILWAY_PRICE_LEVEL { get; set; }
        public virtual ICollection<BASE_TRAILER_PRICE_LEVEL> BASE_TRAILER_PRICE_LEVEL { get; set; }
    }
}
