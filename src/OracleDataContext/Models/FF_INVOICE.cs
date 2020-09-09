using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_INVOICE
    {
        public decimal FF_INVOICE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string INVOICE_NO { get; set; }
        public DateTime INVOICE_DATE { get; set; }
        public decimal INVOICE_AMOUNT { get; set; }
        public string EXPRESS_NO { get; set; }
        public DateTime? EXPRESS_DATE { get; set; }
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
        public decimal? AMOUNT { get; set; }
        public string CURRENCY { get; set; }
    }
}
