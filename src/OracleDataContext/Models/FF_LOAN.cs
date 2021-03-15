using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LOAN
    {
        public decimal FF_LOAN_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string BILL_LIST_IDS { get; set; }
        public string CURRENCY { get; set; }
        public decimal AMOUNT_LOAN { get; set; }
        public decimal? DAYS_LOAN { get; set; }
        public decimal? RATE_INTEREST { get; set; }
        public decimal? RATE_OVERDUE { get; set; }
        public decimal? RATE_SERVICECHARGE { get; set; }
        public decimal? RATE_COMMISSION { get; set; }
        public decimal DAYS_FREE { get; set; }
        public decimal? AMOUNT_PAY { get; set; }
        public decimal? AMOUNT_INTEREST { get; set; }
        public decimal? AMOUNT_OVERDUE { get; set; }
        public decimal? AMOUNT_SERVICECHARGE { get; set; }
        public decimal? AMOUNT_COMMISSION { get; set; }
        public bool? IS_RETURN_INTEREST { get; set; }
        public bool IS_LOCK { get; set; }
        public decimal STATUS { get; set; }
        public DateTime FEE_EXPIRE_DATE { get; set; }
        public DateTime? LOAN_EXPIRE_DATE { get; set; }
        public string FILE_IDS { get; set; }
        public decimal? APPLY_USERID { get; set; }
        public string APPLY_NAME { get; set; }
        public DateTime? APPLY_DATETIME { get; set; }
        public string APPLY_REMARK { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_NAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_NAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_REMARK { get; set; }
        public string REPAYMENT_NAME { get; set; }
        public string REPAYMENT_PAYINFO_ID { get; set; }
        public DateTime? REPAYMENT_DATE { get; set; }
        public string OPERATION_LOG { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal CONTRACT_STATUS { get; set; }
        public string CONTRACT_NO { get; set; }
        public decimal? SIGN_USERID { get; set; }
        public DateTime? SIGN_DATE { get; set; }
        public string CUSTOMER_TRANSACTION_ID { get; set; }
        public string PLATFORM_TRANSACTION_ID { get; set; }
        public string CONTRACT_VIEW_URLD { get; set; }
        public string CONTRACT_DOWNLOAD_URL { get; set; }
        public string IP { get; set; }
        public string IMEI { get; set; }
        public decimal AMOUNT_SUBSIDY { get; set; }
        public decimal AMOUNT_BILL { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
    }
}
