using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_CONTRACT_TEMPLATE
    {
        public decimal CONTRACT_TEMPLATE_ID { get; set; }
        public decimal CONTRACT_TYPE { get; set; }
        public string TEMPLATE_NO { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public decimal FILE_ID { get; set; }
        public decimal VALID { get; set; }
        public decimal FDD_STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
