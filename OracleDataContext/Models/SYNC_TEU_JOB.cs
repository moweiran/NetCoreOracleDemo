using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class SYNC_TEU_JOB
    {
        public decimal SYNC_TEU_JOB_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal BOOKING_ORDER_CONTAINER_ID { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public decimal TEU { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal STATUS { get; set; }
        public DateTime? EXEC_DATETIME { get; set; }
    }
}
