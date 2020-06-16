using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_TICKET
    {
        public decimal TICKET_ID { get; set; }
        public string KEY { get; set; }
        public decimal USER_TYPE { get; set; }
        public decimal USER_ID { get; set; }
        public DateTime CREATEON { get; set; }
        public DateTime EXIRESSON { get; set; }
        public decimal TICKET_TYPE { get; set; }
        public decimal IS_DELETE { get; set; }
    }
}
