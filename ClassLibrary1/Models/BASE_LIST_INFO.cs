using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_LIST_INFO
    {
        public decimal LIST_ID { get; set; }
        public string PAGE_NAME { get; set; }
        public string LIST_NAME { get; set; }
        public string FIELD { get; set; }
        public string DISPLAY { get; set; }
        public string SHOWINLANG { get; set; }
        public string ALIGN { get; set; }
        public bool? HIDEINLG { get; set; }
        public bool? HIDEINSM { get; set; }
        public bool? HIDEINXS { get; set; }
        public bool? HIDEINMD { get; set; }
        public string COMBTYPE { get; set; }
        public string TEMPLATE { get; set; }
        public string COMBINATION { get; set; }
        public string FILTER { get; set; }
        public bool? SELECTED { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? ORDERABLE { get; set; }
    }
}
