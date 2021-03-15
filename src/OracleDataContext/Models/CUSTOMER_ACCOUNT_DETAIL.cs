using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CUSTOMER_ACCOUNT_DETAIL
    {
        public decimal CUSTOMER_ACCOUNT_DETAIL_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public decimal TYPE { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? REF_ID { get; set; }
        public decimal QTY { get; set; }
        public string PAYMENT_NO { get; set; }
        public decimal? PAYMENT_VOUCHER_FILEID { get; set; }
        public string PAYMENT_VOUCHER_PATH { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal? CHECK_USER_ID { get; set; }
        public string CHECK_USER_CODE { get; set; }
        public string CHECK_USER_FULLNAME { get; set; }
        public decimal? CHECK_COMPANY_ID { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public decimal? CREATE_COMPANY_ID { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal STATUS { get; set; }
    }
}
