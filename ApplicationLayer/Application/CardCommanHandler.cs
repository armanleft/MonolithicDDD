using System;
using Application.Contracts;
using Domain.Contract;
using Domain.Contract.Models.Cards;
using Presentation.Contract.CommandDtos;
using System.Threading.Tasks;
using Domain.Contract.Models;

namespace Application
{
    public class CardCommandHandler : ICardCommandHandler
    {
        #region Fields

        private readonly IDomainFactory _factory;
        private readonly IBaseRepository<ICard> _repository;

        #endregion

        #region Constructors

        public CardCommandHandler(IDomainFactory factory, IBaseRepository<ICard> repository)
        {
            _factory = factory;
            _repository = repository;
        }

        #endregion

        #region Handle Methods

        public async Task<Guid> HandleAsync(CreateCardCommand request)
        {
            var builder = _factory.GetInstance<ICardBuilder>();
            builder.WithValue(request.Value);
            var card = builder.Build();

            await _repository.CreateAsync(card);

            return card.Id;
        }

        #endregion
    }
}