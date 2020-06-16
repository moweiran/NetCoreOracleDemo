using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_SEARCHRATE_LOG
    {
        public decimal FF_ECL_SEARCHRATE_LOG_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? START_CITY_ID { get; set; }
        public decimal? DEST_COUNTRY_ID { get; set; }
        public decimal? FBA_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? CBM { get; set; }
    }
}
