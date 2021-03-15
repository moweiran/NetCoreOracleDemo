using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LCLMAIN_PRODUCT_VIA
    {
        public decimal FF_LCLMAIN_PRODUCT_VIA_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_LCLMAIN_PRODUCT_ID { get; set; }
        public decimal LCLBRANCH_TYPE { get; set; }
        public decimal FF_LCLBRANCH_PRODUCT_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
