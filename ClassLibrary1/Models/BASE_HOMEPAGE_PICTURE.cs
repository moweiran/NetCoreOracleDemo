using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_HOMEPAGE_PICTURE
    {
        public decimal BASE_HOMEPAGE_PICTURE_ID { get; set; }
        public decimal SHOW_POSITION { get; set; }
        public decimal SHOW_INDEX { get; set; }
        public decimal? FILE_CN_ID { get; set; }
        public decimal? FILE_EN_ID { get; set; }
        public decimal BACKGROUND_TYPE { get; set; }
        public decimal? BACKGROUND_FILE_ID { get; set; }
        public string BACKGROUND_COLOR { get; set; }
        public string CLICK_URL { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? M_BG_FILE_ID { get; set; }
        public string M_CLICK_URL { get; set; }
        public decimal? ACTIVITY_ID { get; set; }
    }
}
