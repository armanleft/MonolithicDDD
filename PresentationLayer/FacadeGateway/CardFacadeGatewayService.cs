using System;
using Presentation.Contract.CommandDtos;
using Presentation.Contract.FacadeGatewayInterfaces;
using System.Threading.Tasks;
using Application.Contracts;

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

        public async Task<Guid> Create(string value)
        {
            var command = new CreateCardCommand {Value = value};
            return await _handler.HandleAsync(command);
        }

        #endregion
    }
}