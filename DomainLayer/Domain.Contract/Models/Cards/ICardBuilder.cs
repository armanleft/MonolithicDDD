namespace Domain.Contract.Models.Cards
{
    public interface ICardBuilder
    {
        ICardBuilder WithValue(string value);
        ICard Build();
    }
}