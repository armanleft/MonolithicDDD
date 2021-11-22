using Application.Contracts;
using Presentation.Contract.CommandDtos.Cards;
using Presentation.Contract.FacadeGatewayInterfaces;
using System;
using System.Threading.Tasks;

namespace FacadeGateway
{
    public class CardFacadeGatewayService : ICardFacadeGatewayService
    {
        #region Fields

        private readonly ICardCommandHandler _handler;

        #endregion

        #region Constructors

        public CardFacadeGatewayService(ICardCommandHandler handler)
        {
            _handler = handler;
        }

        #endregion

        #region Public Methods

        public Task<string> Create(CreateCardCommand command)
        {
            //TODO: Check the validation here
            return _handler.HandleAsync(command);
        }

        public async Task Update(UpdateCardCommand command)
        {
            await _handler.HandleAsync(command);
        }

        public async Task Delete(string id)
        {
            await _handler.HandleAsync(new DeleteCardCommand());
        }

        #endregion
    }
}