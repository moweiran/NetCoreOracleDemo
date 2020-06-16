using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_BILL_LIST
    {
        public decimal FF_BILL_LIST_ID { get; set; }
        public string BILL_NO { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RECEIVER_COMPANY_TYPE { get; set; }
        public decimal RECEIVER_COMPANY_ID { get; set; }
        public decimal? RECEIVER_SUB_COMPANY_ID { get; set; }
        public decimal PAY_COMAPNY_TYPE { get; set; }
        public decimal PAY_COMPANY_ID { get; set; }
        public decimal? PAY_SUB_COMPANY_ID { get; set; }
        public DateTime BILL_DATE { get; set; }
        public string CUSTOMER_REF_NO { get; set; }
        public string TOTAL_BILL_AMOUNT { get; set; }
        public string TOTAL_CHECK_AMOUNT { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public string RECEIVER_COMPANY_CODE { get; set; }
        public string RECEIVER_COMPANY_ENAME { get; set; }
        public string RECEIVER_COMPANY_CNAME { get; set; }
        public string PAY_COMPANY_CODE { get; set; }
        public string PAY_COMPANY_ENAME { get; set; }
        public string PAY_COMPANY_CNAME { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal? PAY_STATUS { get; set; }
        public decimal? PAY_TYPE { get; set; }
        public DateTime? PAY_DATETIME { get; set; }
        public string PAY_ORDER_ID { get; set; }
        public bool? IS_CONFIRM { get; set; }
        public string SAP_PAYMENT_TERMS { get; set; }
        public string SAP_BILLING_TYPE { get; set; }
        public string SAP_CONTRACT_NO { get; set; }
        public string SAPCUSTOMERNO { get; set; }
        public decimal? SAP_FILE_ID { get; set; }
        public decimal? SAP_STATUS { get; set; }
        public string INVOICE_NO { get; set; }
    }
}
