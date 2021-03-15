using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_CP_VIum
    {
        public decimal FF_FCLMAIN_CP_VIA_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_FCLMAIN_CP_ID { get; set; }
        public decimal FCLBRANCH_TYPE { get; set; }
        public decimal FF_FCLBRANCH_CP_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
