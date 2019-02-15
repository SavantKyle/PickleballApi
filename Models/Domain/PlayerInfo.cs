using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain
{
    public class PlayerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int BirthYear { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RatingMixed { get; set; }
        public string RatingDoubles { get; set; }
        public string Event { get; set; }
        public int CrawfishGuestCount { get; set; }
        public double TotalPrice { get; set; }
        public string MixedPartnerFirstName { get; set; }
        public string MixedPartnerLastName { get; set; }
        public string MixedPartnerPhone { get; set; }
        public string DoublesPartnerFirstName { get; set; }
        public string DoublesPartnerLastName { get; set; }
        public string DoublesPartnerPhone { get; set; }
    }
}
