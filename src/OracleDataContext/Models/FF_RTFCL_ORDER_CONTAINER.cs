using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_ORDER_CONTAINER
    {
        public decimal FF_RTFCL_ORDER_CONTAINER_ID { get; set; }
        public decimal FF_RTFCL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? CONTA_PROPERTY { get; set; }
        public string CONTA_SIZE { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public decimal CARGO_TYPE { get; set; }
        public decimal CONTA_QTY { get; set; }
        public decimal? EIR_QTY { get; set; }
        public decimal TEU { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public decimal? CARGO_QTY { get; set; }
        public string CARGO_UNIT { get; set; }
        public string CARGO_DESC { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
