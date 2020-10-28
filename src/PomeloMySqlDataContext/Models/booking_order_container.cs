using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class booking_order_container
    {
        public long BOOKING_ORDER_CONTAINER_ID { get; set; }
        public long BOOKING_ORDER_ID { get; set; }
        public long MAIN_BOOKING_ORDER_ID { get; set; }
        public long FF_BOOKING_CONTAINER_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public int CARGO_PROPERTY { get; set; }
        public int? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public int CONTA_PROPERTY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CONTA_SIZE { get; set; }
        public int TEU { get; set; }
        public string CONTAINER_NO { get; set; }
        public string SEAL_NO { get; set; }
        public int? PACKAGE_NUM { get; set; }
        public string PACKAGE_UNIT { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? VOUME { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARK { get; set; }
        public string BOOKING_NO { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public decimal? VGM_WEIGHT { get; set; }
        public int? VGM_TYPE { get; set; }
        public DateTime? VGM_DATE { get; set; }
        public long? PRESALE_ORDER_ID { get; set; }
        public bool DELETE_MARK { get; set; }
        public DateTime? DELETE_DATE { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
