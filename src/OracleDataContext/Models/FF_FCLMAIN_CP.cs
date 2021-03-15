using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLMAIN_CP
    {
        public decimal FF_FCLMAIN_CP_ID { get; set; }
        public decimal? FF_FCLMAIN_CPL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public string GROUP_CODE { get; set; }
        public decimal? TT { get; set; }
        public string CLOSE_LEAVE { get; set; }
        public string REMARK { get; set; }
        public bool? IS_NOT_ALONESALE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? SHOW_INDEX { get; set; }
    }
}
