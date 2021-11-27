namespace Understanding_OOP_Contracts
{
    public interface IValidationStrategy<T>
    {
        void Validate(T obj);
    }
}
