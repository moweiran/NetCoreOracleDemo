using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ORDER_COMMENT
    {
        public decimal ORDER_COMMENT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_COMPANY_ID { get; set; }
        public decimal COMMENT_TYPE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
