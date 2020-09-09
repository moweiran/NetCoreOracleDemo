using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_PRODUCT_GROUP
    {
        public decimal FF_FCLMAIN_PRODUCT_GROUP_ID { get; set; }
        public decimal FF_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public decimal PRODUCT_QTY { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
