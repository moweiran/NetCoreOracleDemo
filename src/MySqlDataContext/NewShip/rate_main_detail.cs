﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class rate_main_detail
    {
        public long RATE_MAIN_DETAIL_ID { get; set; }
        public long RATE_MAIN_ID { get; set; }
        public int RATE_TYPE { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
