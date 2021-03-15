using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_CUSTOMER_MONTHLY
    {
        public decimal FF_CUSTOMER_MONTHLY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMAPNY_ID { get; set; }
        public decimal CREDIT_DAYS { get; set; }
        public decimal? CREDIT_MARK { get; set; }
        public decimal? CREDIT_QUOTA { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public string CURRENCY { get; set; }
    }
}
