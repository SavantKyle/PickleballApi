using Facade.Contracts;
using Models.Domain;
using Models.Entity;
using Service.Contracts;
using Service.Contracts.Mappers;
using System.Linq;

namespace Facade
{
    public class RegisterFacade : IRegisterFacade
    {
        private readonly IRatingService _ratingService;
        private readonly IPlayerMapper _playerMapper;
        private readonly IPartnerMapper _partnerMapper;
        private readonly IPartnerService _partnerService;
        private readonly IPlayerService _playerService;

        public RegisterFacade(IRatingService ratingService, IPlayerMapper playerMapper, IPartnerMapper partnerMapper, IPartnerService partnerService, IPlayerService playerService)
        {
            _ratingService = ratingService;
            _playerMapper = playerMapper;
            _partnerMapper = partnerMapper;
            _partnerService = partnerService;
            _playerService = playerService;
        }

        public void RegisterPlayer(PlayerInfo playerInfo)
        {
            Partner doublesPartner = null, mixedPartner = null;

            var ratings = _ratingService.Get().ToList();

            if (playerInfo.Event == "Doubles" || playerInfo.Event == "Both")
                doublesPartner = _partnerService.Insert(_partnerMapper.MapDoublesPartner(playerInfo));
            if (playerInfo.Event == "Mixed" || playerInfo.Event == "Both")
                mixedPartner = _partnerService.Insert(_partnerMapper.MapMixedPartner(playerInfo));

            var player = _playerMapper.Map(playerInfo, ratings, doublesPartner?.Id, mixedPartner?.Id);

            _playerService.Insert(player);
        }
    }
}
