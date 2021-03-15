using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_FCLSURCHARGE_DGLEVEL
    {
        public decimal FF_FCLSURCHARGE_DGLEVEL_ID { get; set; }
        public decimal FF_FCLSURCHARGE_DG_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal DG_LEVEL_ID { get; set; }
        public decimal? GP20_COST { get; set; }
        public decimal? GP40_COST { get; set; }
        public decimal? HQ40_COST { get; set; }
        public decimal? GP45_COST { get; set; }
        public decimal? GP20_SALE { get; set; }
        public decimal? GP40_SALE { get; set; }
        public decimal? HQ40_SALE { get; set; }
        public decimal? GP45_SALE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
