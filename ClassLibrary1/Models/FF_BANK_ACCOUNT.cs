using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_BANK_ACCOUNT
    {
        public decimal FF_BANK_ACCOUNT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string BANK_ENAME { get; set; }
        public string BANK_CNAME { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
