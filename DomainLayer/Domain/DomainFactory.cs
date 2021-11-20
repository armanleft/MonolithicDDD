using Domain.Contract;
using Domain.Contract.Models;
using Domain.Models;
using System;
using Domain.Contract.Models.Cards;
using Domain.Models.Cards;

namespace Domain
{
    public class DomainFactory : IDomainFactory
    {
        public T GetInstance<T>()
        {
            if (typeof(T) == typeof(ICardBuilder))
            {
                return (T) (ICardBuilder) new CardBuilder();
            }
            else
                throw new NotImplementedException($"Creation of {typeof(T)} interface is not supported yet.");
        }
    }
}