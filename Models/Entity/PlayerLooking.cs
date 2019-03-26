﻿using Models.Enum;

namespace Models.Entity
{
    public class PlayerLooking
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string DoublesRating { get; set; }
        public string MixedRating { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string EventNeedingPartner { get; set; }
    }
}