using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_AGENCYFEE_CUSTOMER
    {
        public decimal FF_ECL_AGENCYFEE_CUSTOMER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? FF_ECL_AGENCYFEE_ID { get; set; }
        public string SERVICES_PROJECT { get; set; }
        public string FEE { get; set; }
        public string CURRENCY { get; set; }
        public string PPCC { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
