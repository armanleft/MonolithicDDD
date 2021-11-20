using Domain.Contract.Models.Cards;

namespace Domain.Models.Cards
{
    public class CardBuilder : ICardBuilder
    {
        #region Properties

        public string Value { get; set; }

        #endregion

        #region With Methods

        public ICardBuilder WithValue(string value)
        {
            Value = value;
            return this;
        }

        #endregion

        #region Build Methods

        public ICard Build()
        {
            var card = new Card(Value);
            return card;
        }

        #endregion
    }
}