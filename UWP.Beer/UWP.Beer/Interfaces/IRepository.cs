using System.Threading.Tasks;

namespace UWP.Beer.Interfaces
{
    public interface IRepository<T>
    {
        Task LoadAll();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
