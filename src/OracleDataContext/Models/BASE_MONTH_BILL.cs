using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_MONTH_BILL
    {
        public string BASE_MONTH_BILL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal COMAPNY_LEVEL { get; set; }
        public decimal BILL_YEAR { get; set; }
        public decimal BILL_MONTH { get; set; }
        public decimal PEER_TEU { get; set; }
        public decimal PEER_PRICE { get; set; }
        public decimal DIRECT_CUSTOMER_TEU { get; set; }
        public decimal DIRECT_CUSTOMER_PRICE { get; set; }
        public decimal OCEAN_FCL_TEU { get; set; }
        public decimal OCEAN_FCL_AMOUNT { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_REMARK { get; set; }
        public decimal? RECEIVABLES_USERID { get; set; }
        public string RECEIVABLES_FULLNAME { get; set; }
        public DateTime? RECEIVABLES_DATE { get; set; }
        public string RECEIVABLES_REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
