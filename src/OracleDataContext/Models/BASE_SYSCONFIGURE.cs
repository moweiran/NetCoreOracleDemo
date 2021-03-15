using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_SYSCONFIGURE
    {
        public decimal SYSCONFIGURE_ID { get; set; }
        public string SYSCONFIGURE_CATEGORY { get; set; }
        public string SYSCONFIGURE_KEY { get; set; }
        public string SYSCONFIGURE_VALUE { get; set; }
        public string SYSCONFIGURE_DESCRIPTION { get; set; }
        public decimal? UIINDEX { get; set; }
        public bool? RAADONLY { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
    }
}
