using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AIRMAIN_PRODUCT_VIA
    {
        public decimal FF_AIRMAIN_PRODUCT_VIA_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_AIRMAIN_PRODUCT_ID { get; set; }
        public decimal AIRBRANCH_TYPE { get; set; }
        public decimal FF_AIRBRANCH_PRODUCT_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
