using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RAISE_QUOTA
    {
        public decimal FF_RAISE_QUOTA_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal APPLY_QUOTA { get; set; }
        public decimal APPLY_TYPE { get; set; }
        public string REMARK { get; set; }
        public string FILE_IDS { get; set; }
        public decimal? CHECK_QUOTA { get; set; }
        public decimal? CHECK_TYPE { get; set; }
        public DateTime? TEMP_EXPIREDATE { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_FULLNAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
