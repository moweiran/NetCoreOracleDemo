using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_PAY_SUPPLIER
    {
        public decimal BASE_PAY_SUPPLIER_ID { get; set; }
        public string FF_PAY_INFO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal PAY_AMOUNT { get; set; }
        public decimal PAY_STATUS { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string FF_PAY_DETAIL_ID { get; set; }
    }
}
