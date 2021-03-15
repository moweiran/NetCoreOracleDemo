using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_THUNES_KYB_EXTEND
    {
        public decimal ID { get; set; }
        public decimal COMPANY_THUNES_KYB_ID { get; set; }
        public decimal EXTEND_TYPE { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string COUNTRY_OF_RESIDENCE { get; set; }
        public string CITY_OF_RESIDENCE { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string JOB_TITLE { get; set; }
        public decimal? KYB_FILE_ID { get; set; }
        public string KYB_FILE_NAME { get; set; }
        public string SHARE_RATIO { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string EMAIL { get; set; }
        public bool DELETE_MARK { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
    }
}
