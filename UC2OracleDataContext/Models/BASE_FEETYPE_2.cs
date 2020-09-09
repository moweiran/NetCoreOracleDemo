using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_FEETYPE_2
    {
        public decimal BASE_FEETYPE_ID { get; set; }
        public string FEE_CODE { get; set; }
        public string FEE_NAME { get; set; }
        public string FEE_REMARK { get; set; }
        public decimal? FEE_TYPE { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? ISCOMMON { get; set; }
        public string FEE_NAME_CN { get; set; }
        public decimal? SEQUENCE { get; set; }
        public bool? IS_COMMISSION { get; set; }
    }
}
