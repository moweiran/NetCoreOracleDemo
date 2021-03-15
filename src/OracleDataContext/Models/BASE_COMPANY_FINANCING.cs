using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_FINANCING
    {
        public decimal BASE_COMPANY_FINANCING_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string UNIFORM_CODE { get; set; }
        public string CONTACTS { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string LEGALREP_NAME { get; set; }
        public string LEGALREP_ID { get; set; }
        public decimal? REGISTERED_FILEID { get; set; }
        public decimal? ID_UP_FILEID { get; set; }
        public decimal? ID_DOWN_FILEID { get; set; }
        public string OTHER_FILEIDS { get; set; }
        public bool? IS_BANKER { get; set; }
        public string ADVANTAGE_SERVICE { get; set; }
        public string ADVANTAGE_ZONE { get; set; }
        public decimal STATUS { get; set; }
        public decimal TOTAL_QUOTA { get; set; }
        public decimal BASE_QUOTA { get; set; }
        public decimal LOAN_QUOTA { get; set; }
        public decimal WAIT_CHECK_QUOTA { get; set; }
        public decimal SURPLUS_QUOTA { get; set; }
        public decimal? TEMP_QUOTA { get; set; }
        public DateTime? TEMP_EXPIREDATE { get; set; }
        public decimal? COMMISSION_DISCOUNT_RATE { get; set; }
        public DateTime? COMMISSION_DISCOUNT_EXPIREDATE { get; set; }
        public decimal? ALERT_QUOTA { get; set; }
        public decimal? APPLY_USERID { get; set; }
        public string APPLY_NAME { get; set; }
        public DateTime? APPLY_DATETIME { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_NAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public decimal? REJECT_TYPE { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACCOUNT_NO { get; set; }
        public string BANK_ACCOUNT_NAME { get; set; }
        public string REMARK { get; set; }
        public string OPERATION_LOG { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string FDD_CUSTOMER_ID { get; set; }
    }
}
