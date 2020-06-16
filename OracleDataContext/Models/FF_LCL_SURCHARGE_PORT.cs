using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_LCL_SURCHARGE_PORT
    {
        public decimal FF_LCL_SURCHARGE_PORT_ID { get; set; }
        public decimal FF_LCL_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
