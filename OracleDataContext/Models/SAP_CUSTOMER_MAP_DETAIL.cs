using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class SAP_CUSTOMER_MAP_DETAIL
    {
        public decimal ID { get; set; }
        public decimal SAP_CUSTOMER_MAP_ID { get; set; }
        public decimal SAP_FEE_TYPE_MAP_ID { get; set; }
        public string ITEMNO { get; set; }
    }
}
