using Models.Enum;

namespace Models.Entity
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public GenderEnum Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EventFormatEnum EventsPlaying { get; set; }
        public int? SinglesRatingId { get; set; }
        public int? DoublesRatingId { get; set; }
        public int? MixedRatingId { get; set; }
        public int? DoublesPartnerId { get; set; }
        public int? MixedPartnerId { get; set; }
        public int CrawfishGuestCount { get; set; }
    }
}