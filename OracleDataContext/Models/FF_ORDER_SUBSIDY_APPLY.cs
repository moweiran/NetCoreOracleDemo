using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ORDER_SUBSIDY_APPLY
    {
        public decimal FF_ORDER_SUBSIDY_APPLY_ID { get; set; }
        public string APPLY_NO { get; set; }
        public decimal ORDER_QTY { get; set; }
        public decimal ORDER_AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public decimal FF_ID { get; set; }
        public string RECEIVABLES_NO { get; set; }
        public decimal? RECEIVABLES_FILE_ID { get; set; }
        public string CONTACT_PHONE { get; set; }
        public decimal? APPLY_USERID { get; set; }
        public string APPLY_FULLNAME { get; set; }
        public DateTime? APPLY_DATE { get; set; }
        public string APPLY_REMARK { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
