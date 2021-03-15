using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMMISSION_DISCOUNT
    {
        public decimal BASE_COMMISSION_DISCOUNT_ID { get; set; }
        public decimal COMMISSION_TYPE { get; set; }
        public decimal YEARS_ONE { get; set; }
        public decimal YEARS_TWO { get; set; }
        public decimal YEARS_THREE { get; set; }
        public decimal YEARS_THREE_LATER { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
