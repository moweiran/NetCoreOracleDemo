using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_OI_ORDER_CONTAINER
    {
        public decimal OI_ORDER_CONTAINER_ID { get; set; }
        public decimal OI_ORDER_ID { get; set; }
        public decimal OI_DATA_SOURCE { get; set; }
        public decimal? PRE_CONTA_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARGO_PROPERTY { get; set; }
        public decimal? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public decimal CONTA_PROPERTY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CONTA_SIZE { get; set; }
        public decimal TEU { get; set; }
        public string CONTAINER_NO { get; set; }
        public string SEAL_NO { get; set; }
        public decimal? PACKAGE_NUM { get; set; }
        public string PACKAGE_UNIT { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? VOUME { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARK { get; set; }
        public decimal? TC_CONTAINER_ID { get; set; }
        public string BOOKING_NO { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public decimal? VGM_WEIGHT { get; set; }
        public decimal? VGM_TYPE { get; set; }
        public DateTime? VGM_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public DateTime? DELETE_DATE { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
