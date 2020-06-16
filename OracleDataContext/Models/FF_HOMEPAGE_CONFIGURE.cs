using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_HOMEPAGE_CONFIGURE
    {
        public decimal FF_HOMEPAGE_CONFIGURE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string THEME_COLOR { get; set; }
        public string PAGE_BACKGROUND_COLOR { get; set; }
        public string IS_SHOW_BACKGROUND_COLOR { get; set; }
        public decimal? PAGE_BACKGROUND_FILE_ID { get; set; }
        public decimal? PAGE_BACKGROUND_FILE_TO { get; set; }
        public decimal? HOMEPAGE_SHOW_TYPE { get; set; }
        public decimal? HOMEPAGE_FILE1_ID { get; set; }
        public decimal? HOMEPAGE_FILE2_ID { get; set; }
        public decimal? HOMEPAGE_FILE3_ID { get; set; }
        public decimal? SEARCH_RATE_SHOW_TYPE { get; set; }
        public string SEARCH_RATE_COLOR { get; set; }
        public decimal? SEARCH_RATE_FILE_ID { get; set; }
        public decimal? CONTACTUS_FILE_ID { get; set; }
        public decimal? ABOUTUS_FILE_ID { get; set; }
        public bool IS_SHOW_SEARCHRATE { get; set; }
        public bool IS_SHOW_ABOUTUS { get; set; }
        public bool IS_SHOW_CONTACTUS { get; set; }
        public bool IS_SHOW_NEWS { get; set; }
        public bool IS_SHOW_NOTICE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? UI_INDEX_SEARCHRATE { get; set; }
        public decimal? UI_INDEX_ABOUTUS { get; set; }
        public decimal? UI_INDEX_CONTACTUS { get; set; }
        public decimal? UI_INDEX_NEWS { get; set; }
        public decimal? UI_INDEX_NOTICE { get; set; }
        public bool IS_SHOW_COREBUSINESS { get; set; }
        public decimal? UI_INDEX_COREBUSINESS { get; set; }
        public bool IS_SHOW_CLASSICHOMEPAGE { get; set; }
        public decimal? UI_INDEX_CLASSICHOMEPAGE { get; set; }
        public bool IS_SHOW_CONCISEHOMEPAGE { get; set; }
        public decimal? UI_INDEX_CONCISEHOMEPAGE { get; set; }
        public decimal? COREBUSINESS_FILE_ID { get; set; }
        public decimal? BOTTOM_FILE_ID { get; set; }
        public bool? IS_SHOW_CARGOTRACK { get; set; }
        public decimal? UI_INDEX_CARGOTRACK { get; set; }
        public decimal? RATE_FILE_ID { get; set; }
    }
}
