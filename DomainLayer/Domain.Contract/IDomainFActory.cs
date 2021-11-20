namespace Domain.Contract
{
    public interface IDomainFactory
    {
        T GetInstance<T>();
    }
}