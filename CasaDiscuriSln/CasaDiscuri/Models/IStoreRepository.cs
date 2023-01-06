using CasaDiscuri.Models;

namespace CasaDiscuri.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}