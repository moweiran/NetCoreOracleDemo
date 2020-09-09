using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_ALLIANCE
    {
        public decimal ID { get; set; }
        public string CODE { get; set; }
        public string NAME_EN { get; set; }
        public string NAME_CN { get; set; }
        public string ADDRESS { get; set; }
        public string WEBSITE { get; set; }
        public string REFEREE_NO { get; set; }
        public decimal LOGO_ID { get; set; }
        public decimal? COUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
