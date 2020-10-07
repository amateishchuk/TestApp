using System.Linq;

namespace TestApp.Services.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
    }
}
