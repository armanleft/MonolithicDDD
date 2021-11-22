using Domain.Contract.Models.Cards;

namespace Domain.Models.Cards
{
    public class Card : BaseEntity, ICard
    {
        #region Properties

        public string Value { get; set; }

        #endregion

        #region Constructors

        public Card(string value)
        {
            Value = value;
        }

        #endregion

        #region Public Methods

        public void Update(string value)
        {
            Value = value;
        }

        #endregion
    }
}