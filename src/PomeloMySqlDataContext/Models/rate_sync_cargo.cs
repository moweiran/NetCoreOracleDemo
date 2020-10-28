using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rate_sync_cargo
    {
        public string ID { get; set; }
        public decimal RATE_ID { get; set; }
        public decimal STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
