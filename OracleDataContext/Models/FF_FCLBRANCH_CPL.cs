using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLBRANCH_CPL
    {
        public decimal FF_FCLBRANCH_CPL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal MAIN_PORT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal? PRODUCT_COUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
