using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CONTRACT
    {
        public CONTRACT()
        {
            CONTRACT_DETAIL = new HashSet<CONTRACT_DETAIL>();
        }

        public decimal CONTRACT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_SHORTNAME { get; set; }
        public string FF_NAME_CN { get; set; }
        public string FF_NAME_EN { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public string CUSTOMER_CNAME { get; set; }
        public string CUSTOMER_ENAME { get; set; }
        public string CONTRACT_NO { get; set; }
        public decimal? TEU_MIN { get; set; }
        public decimal? TEU_MAX { get; set; }
        public decimal? COMPLETE_TEU { get; set; }
        public string CARGO_DESC { get; set; }
        public string FREIGHT_CLAUSE_CODE { get; set; }
        public string FREIGHT_CLAUSE_ENAME { get; set; }
        public string FREIGHT_CLAUSE_CNAME { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public string MODIFY_COMPANY_SHORTNAME { get; set; }
        public string MODIFY_COMPANY_NAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string CREATE_COMPANY_SHORT_NAME { get; set; }
        public string CREATE_COMPANY_NAME { get; set; }
        public decimal FF_COMPANY_ID { get; set; }

        public virtual ICollection<CONTRACT_DETAIL> CONTRACT_DETAIL { get; set; }
    }
}
