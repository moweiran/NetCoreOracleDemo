using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_THUNES_KYB
    {
        public decimal BASE_COMPANY_THUNES_KYB_ID { get; set; }
        public decimal FFID { get; set; }
        public string CERTIFICATE_FILE_NAME { get; set; }
        public decimal CERTIFICATE_FILE_ID { get; set; }
        public string CORPORATE_STRUCTURE_FILE_NAME { get; set; }
        public decimal? CORPORATE_STRUCTURE_FILE_ID { get; set; }
        public string CORPORATE_CUSTOMER_NAME { get; set; }
        public string TRADING_NAME { get; set; }
        public string REGISTRATION_NUMBER { get; set; }
        public string NUMBER_EMPLOYEES { get; set; }
        public string COUNTRY_REGISTRATION { get; set; }
        public string REGISTERED_ADDRESS { get; set; }
        public string COUNTRY_OPERATION { get; set; }
        public string WEBISTE_ADDRESS { get; set; }
        public string DATE_INCORPORATION { get; set; }
        public decimal STATUS { get; set; }
        public string CHECK_REMARK { get; set; }
        public DateTime? CHECK_DATETIME { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string BOARD_OF_DIRECTORS_INFO { get; set; }
        public bool? ISDIRECTORS { get; set; }
        public string REGISTERED_CITY { get; set; }
        public string REGISTERED_POSTAL_CODE { get; set; }
    }
}
