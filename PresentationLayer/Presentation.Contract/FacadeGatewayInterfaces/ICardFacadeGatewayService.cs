using System;
using System.Threading.Tasks;
using Presentation.Contract.CommandDtos.Cards;

namespace Presentation.Contract.FacadeGatewayInterfaces
{
    public interface ICardFacadeGatewayService
    {
        Task<string> Create(CreateCardCommand command);
        Task Update(UpdateCardCommand command);
        Task Delete(string id);
    }
}