using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCL_SPACE_SO
    {
        public decimal FF_FCL_SPACE_SO_ID { get; set; }
        public decimal FF_FCL_SPACE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string SO_NO { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
