using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Models.Domain;
using Models.Entity;
using Models.Enum;
using Service.Contracts.Mappers;
using Stripe;

namespace Service.Mappers
{
    public class PlayerMapper : IPlayerMapper
    {
        public Player Map(PlayerInfo playerInfo, IEnumerable<Rating> ratings, int? doublesPartnerId, int? mixedPartnerId)
        {
            var ratingList = ratings.ToList();
            return new Player()
            {
                FirstName = playerInfo.FirstName, 
                LastName = playerInfo.LastName,
                BirthYear = playerInfo.BirthYear, 
                Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), playerInfo.Gender),
                Email = playerInfo.Email, 
                Phone = playerInfo.Phone, 
                EventsPlaying = (EventFormatEnum)Enum.Parse(typeof(EventFormatEnum), playerInfo.Event),
                DoublesRatingId = GetRating(playerInfo.RatingDoubles, ratingList), 
                MixedRatingId = GetRating(playerInfo.RatingMixed, ratingList), 
                DoublesPartnerId = doublesPartnerId, 
                MixedPartnerId = mixedPartnerId,
                CrawfishGuestCount = playerInfo.CrawfishGuestCount
            };
        }

        private static int? GetRating(string ratingText, IEnumerable<Rating> ratings)
        {
            return ratings.SingleOrDefault(x => x.Rate == ratingText)?.Id; 
        }
    }
}