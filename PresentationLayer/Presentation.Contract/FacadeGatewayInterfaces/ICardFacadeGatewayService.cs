using System;
using System.Threading.Tasks;

namespace Presentation.Contract.FacadeGatewayInterfaces
{
    public interface ICardFacadeGatewayService
    {
        Task<Guid> Create(string value);
    }
}