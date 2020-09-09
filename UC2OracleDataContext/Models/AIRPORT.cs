using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class AIRPORT
    {
        public decimal AIRPORTID { get; set; }
        public string NAME_CN { get; set; }
        public string NAME_EN { get; set; }
        public string THREE_LETTERS_CODE { get; set; }
        public string FOUR_LETTERS_CODE { get; set; }
        public decimal BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string ADDRESS { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public bool DELETE_MARK { get; set; }
        public DateTime? MODIFT_DATE { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public decimal? CITY_ID { get; set; }
        public string CITY_NAME { get; set; }
    }
}
