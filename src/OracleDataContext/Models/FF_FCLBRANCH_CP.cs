using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCLBRANCH_CP
    {
        public decimal FF_FCLBRANCH_CP_ID { get; set; }
        public decimal? FF_FCLBRANCH_CPL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal MAIN_PORT_ID { get; set; }
        public decimal BRANCH_PORT_ID { get; set; }
        public decimal TRANSPORT_TYPE { get; set; }
        public string GROUP_CODE { get; set; }
        public decimal? TT { get; set; }
        public string CLOSE_LEAVE { get; set; }
        public string REMARK { get; set; }
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
