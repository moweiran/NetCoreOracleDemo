using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_WAREHOUSE
    {
        public decimal ID { get; set; }
        public decimal FF_ID { get; set; }
        public string WAREHOUSE_NAME { get; set; }
        public decimal CITY_ID { get; set; }
        public decimal IS_MAIN_WAREHOUSE { get; set; }
        public decimal WAREHOUSE_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string CONTACT { get; set; }
        public string CONTACT_NUMBER { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? MIN_CHARGE { get; set; }
        public string WORKING_HOURS { get; set; }
        public string REMARK { get; set; }
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
