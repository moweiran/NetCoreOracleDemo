using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class ORDER_EIR
    {
        public decimal ORDER_EIR_ID { get; set; }
        public decimal ORDER_EIR_APPLY_ID { get; set; }
        public decimal? BOOKING_ORDER_RATE_ID { get; set; }
        public decimal CONTA_PROPERTY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CONTA_SIZE { get; set; }
        public bool? IS_DOUBLE { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public decimal CONTA_QTY { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? DANGEROU_LEVEL_ID { get; set; }
        public decimal? PRICE_CUSTOMER_BYWEIGHT_ID { get; set; }

        public virtual ORDER_EIR_APPLY ORDER_EIR_APPLY { get; set; }
    }
}
