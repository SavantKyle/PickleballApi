using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain
{
    public class PlayerAndPaymentInfo
    {
        public PlayerInfo PlayerInfo { get; set; }
        public StripePaymentRequest StripePaymentRequest { get; set; }
    }
}
