using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_COMPANY_STRIPE
    {
        public decimal COMPANY_STRIPE_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string SUBSCRIPTION_ID { get; set; }
        public string PLAN_ID { get; set; }
        public DateTime? PERIOD_END { get; set; }
        public DateTime? PERIOD_START { get; set; }
        public string COUPON_ID { get; set; }
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
        public string SOURCE_ID { get; set; }
        public decimal? PAY_TYPE { get; set; }
        public string PAYMENT_METHOD_ID { get; set; }
    }
}
