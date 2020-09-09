using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ADVANTAGE
    {
        public decimal FF_ADVANTAGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal ADVANTAGE_TYPE { get; set; }
        public decimal SEQUENCE { get; set; }
        public decimal? ADVANTAGE_ID { get; set; }
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
    }
}
