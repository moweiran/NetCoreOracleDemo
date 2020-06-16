using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCLSURCHARGE_OWLEVEL
    {
        public decimal FF_FCLSURCHARGE_OWLEVEL_ID { get; set; }
        public decimal FF_FCLSURCHARGE_OW_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string CONT_SIZETYPE { get; set; }
        public decimal BEGIN_WEIGHT { get; set; }
        public decimal END_WEIGHT { get; set; }
        public decimal? AMOUNT_COST { get; set; }
        public decimal AMOUNT_SALE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
