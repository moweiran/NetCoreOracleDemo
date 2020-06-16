using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RTLCL_SEARCHRATE_LOG
    {
        public decimal FF_RTLCL_SEARCHRATE_LOG_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? START_CITY_ID { get; set; }
        public decimal? DEST_CITY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
