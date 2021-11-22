using Application.Contracts;
using Domain.Contract;
using Domain.Contract.Models;
using Domain.Contract.Models.Cards;
using Presentation.Contract.CommandDtos.Cards;
using System;
using System.Threading.Tasks;

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

        public async Task<string> HandleAsync(CreateCardCommand command)
        {
            var builder = _factory.GetInstance<ICardBuilder>();
            builder.WithValue(command.Value);
            var card = builder.Build();

            await _repository.CreateAsync(card);

            return "";
        }

        public async Task HandleAsync(UpdateCardCommand command)
        {
            var card = await _repository.GetByIdAsync(command.Id);
            card.Update(command.Value);

            await _repository.UpdateAsync(card);
        }

        public async Task HandleAsync(DeleteCardCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }

        #endregion
    }
}