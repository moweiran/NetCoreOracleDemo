using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_BUSINESS_CARD_FAVORITE
    {
        public string FAVORITE_ID { get; set; }
        public string WECHAT_UNIONID { get; set; }
        public string FAVORITE_CARD_ID { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
