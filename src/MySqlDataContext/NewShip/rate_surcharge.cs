using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class rate_surcharge
    {
        public rate_surcharge()
        {
            rate_surcharge_detail = new HashSet<rate_surcharge_detail>();
        }

        public long BASE_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long FEETYPE_ID { get; set; }
        public int SURCHARGE_TYPE { get; set; }
        public int UNIT { get; set; }
        public string CURRENCY { get; set; }
        public string PPCC { get; set; }
        public decimal? CHARGE_BOOKING { get; set; }
        public decimal? CHARGE_GP20 { get; set; }
        public decimal? CHARGE_GP40 { get; set; }
        public decimal? CHARGE_HC40 { get; set; }
        public decimal? CHARGE_HC45 { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public int VALID { get; set; }
        public string REMARK { get; set; }
        public int ROUTE_QTY { get; set; }
        public int RECEIPT_QTY { get; set; }
        public int POL_QTY { get; set; }
        public int POD_QTY { get; set; }
        public int DELIVERY_QTY { get; set; }
        public bool DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string MODIFY_USERNAME { get; set; }

        public virtual ICollection<rate_surcharge_detail> rate_surcharge_detail { get; set; }
    }
}
