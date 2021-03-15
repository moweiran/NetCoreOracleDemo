using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class rate_land_detail
    {
        public long RATE_LAND_DETAIL_ID { get; set; }
        public long RATE_LAND_ID { get; set; }
        public long BYWEIGHT_LEVEL_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP20_DOUBLE { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? GP45 { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
