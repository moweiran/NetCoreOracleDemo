using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_COUNTRY
    {
        public BASE_COUNTRY()
        {
            BASE_PROVINCES = new HashSet<BASE_PROVINCES>();
            BASE_RAILWAY_PRICE_LEVEL = new HashSet<BASE_RAILWAY_PRICE_LEVEL>();
            BASE_TRAILER_PRICE_LEVEL = new HashSet<BASE_TRAILER_PRICE_LEVEL>();
        }

        public decimal BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string COUNTRY_FULLNAME { get; set; }
        public string UNCODE { get; set; }
        public string REMARK { get; set; }
        public bool? IS_ISO { get; set; }
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

        public virtual ICollection<BASE_PROVINCES> BASE_PROVINCES { get; set; }
        public virtual ICollection<BASE_RAILWAY_PRICE_LEVEL> BASE_RAILWAY_PRICE_LEVEL { get; set; }
        public virtual ICollection<BASE_TRAILER_PRICE_LEVEL> BASE_TRAILER_PRICE_LEVEL { get; set; }
    }
}
