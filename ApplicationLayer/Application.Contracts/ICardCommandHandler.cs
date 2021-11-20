using System;
using Presentation.Contract.CommandDtos;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface ICardCommandHandler
    {
        Task<Guid> HandleAsync(CreateCardCommand request);
    }
}