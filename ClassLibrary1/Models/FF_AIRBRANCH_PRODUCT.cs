using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_AIRBRANCH_PRODUCT
    {
        public decimal FF_AIRBRANCH_PRODUCT_ID { get; set; }
        public decimal? FF_AIRBRANCH_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public decimal TRANSPORT_TYPE { get; set; }
        public string SCHEDULE { get; set; }
        public string AIR_MODEL { get; set; }
        public string FLIGHT_NO { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? SHOW_INDEX { get; set; }
    }
}
