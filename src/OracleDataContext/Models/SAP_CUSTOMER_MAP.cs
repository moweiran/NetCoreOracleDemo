using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class SAP_CUSTOMER_MAP
    {
        public decimal ID { get; set; }
        public decimal COMPANYTYPE { get; set; }
        public decimal COMPANYID { get; set; }
        public string COMPANYNAMECN { get; set; }
        public string COMPANYNAMEEN { get; set; }
        public string SAP_PAYMENT_TERMS { get; set; }
        public string SAP_BILLING_TYPE { get; set; }
        public string SAP_CONTRACT_NO { get; set; }
        public string SAP_CUSTOMER_NO { get; set; }
        public string REMARK { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public string SAP_CONTRACT_NAME { get; set; }
    }
}
