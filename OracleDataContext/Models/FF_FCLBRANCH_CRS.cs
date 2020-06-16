using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCLBRANCH_CRS
    {
        public decimal FF_FCLBRANCH_CRS_ID { get; set; }
        public decimal? FF_FCLBRANCH_CPL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal RATE_QTY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
