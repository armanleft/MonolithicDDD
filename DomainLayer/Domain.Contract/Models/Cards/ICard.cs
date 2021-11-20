namespace Domain.Contract.Models.Cards
{
    public interface ICard : IBaseEntity
    {
        public string Value { get; set; }
    }
}