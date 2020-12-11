namespace UnitTesting.Application
{
    public interface ICustomerRepository
    {
        T Add<T>(T item);
        void Update<T>(T item);
        void Delete<T>(T item);
    }
}
