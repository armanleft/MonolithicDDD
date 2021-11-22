using Presentation.Contract.CommandDtos.Cards;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface ICardCommandHandler
    {
        Task<string> HandleAsync(CreateCardCommand command);
        Task HandleAsync(UpdateCardCommand command);
        Task HandleAsync(DeleteCardCommand command);
    }
}