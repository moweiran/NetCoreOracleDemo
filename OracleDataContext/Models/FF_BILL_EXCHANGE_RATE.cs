using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_BILL_EXCHANGE_RATE
    {
        public decimal FF_BILL_EXCHANGE_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string SOURCE_CURRENCY { get; set; }
        public string PAYMENT_CURRENCY_CODE { get; set; }
        public decimal RATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public decimal? RATE_TYPE { get; set; }
        public decimal? BUSINESSTYPE { get; set; }
    }
}
