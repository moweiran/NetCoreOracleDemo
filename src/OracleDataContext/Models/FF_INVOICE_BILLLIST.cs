using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_INVOICE_BILLLIST
    {
        public decimal FF_INVOICE_BILLLIST_ID { get; set; }
        public decimal FF_INVOICE_ID { get; set; }
        public decimal FF_BILL_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
