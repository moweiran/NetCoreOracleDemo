using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FINANCE_CHECK_EXPENSES
    {
        public decimal FF_FINANCE_CHECK_EXPENSES_ID { get; set; }
        public decimal FF_FINANCE_CHECK_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal EXPENSES_WAY { get; set; }
        public decimal EXPENSES_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal? USE_AMOUNT { get; set; }
        public bool? IS_WRITEOFF { get; set; }
        public decimal? REF_ID { get; set; }
        public decimal? RATE { get; set; }
        public decimal? FINAL_AMOUNT { get; set; }
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
    }
}
