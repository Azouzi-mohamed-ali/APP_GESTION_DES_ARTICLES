namespace WebApplication2.Models.Repositories
{
    public interface IRepository<T>
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        T Add(T t);
        T Update(T t);
        T Delete(int Id);
        object FindByID(int id);
        void Update(int id, Product pro);
    }
}
