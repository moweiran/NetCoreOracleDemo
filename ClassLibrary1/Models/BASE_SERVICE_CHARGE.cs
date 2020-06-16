using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_SERVICE_CHARGE
    {
        public decimal BASE_SERVICE_CHARGE_ID { get; set; }
        public decimal SERVICE_TYPE { get; set; }
        public string SERVICE_TYPE_DESC { get; set; }
        public string SERVICE_UNIT { get; set; }
        public decimal CHARGE_TYPE_C1 { get; set; }
        public decimal? AMOUNT_C1 { get; set; }
        public decimal CHARGE_TYPE_C2 { get; set; }
        public decimal? AMOUNT_C2 { get; set; }
        public decimal CHARGE_TYPE_C3 { get; set; }
        public decimal? AMOUNT_C3 { get; set; }
        public decimal CHARGE_TYPE_C4 { get; set; }
        public decimal? AMOUNT_C4 { get; set; }
        public decimal CHARGE_TYPE_C5 { get; set; }
        public decimal? AMOUNT_C5 { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
