using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_BILL_CONTAINER
    {
        public decimal FF_BILL_CONTAINER_ID { get; set; }
        public decimal BOOKING_ORDER_CONTAINER_ID { get; set; }
        public decimal FF_BILL_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
