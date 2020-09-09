using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CONTRACT_SURCHARGE
    {
        public decimal CONTRACT_SURCHARGE_ID { get; set; }
        public decimal? CONTRACT_DETAIL_ID { get; set; }
        public string FEE_CODE { get; set; }
        public string FEE_NAME { get; set; }
        public bool? INCLUDE { get; set; }
        public decimal? SURCHARGETYPE { get; set; }
        public string REMARK { get; set; }
        public decimal GP20_CHARGE { get; set; }
        public decimal GP40_CHARGE { get; set; }
        public decimal HQ40_CHARGE { get; set; }
        public decimal GP45_CHARGE { get; set; }
        public decimal UNIT { get; set; }
        public string CURRENCY { get; set; }
        public string FREIGHT_CLAUSE_CODE { get; set; }
        public decimal SEQUENCE { get; set; }
        public decimal? CREATEBY { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal FF_ID { get; set; }

        public virtual CONTRACT_DETAIL CONTRACT_DETAIL_ { get; set; }
    }
}
