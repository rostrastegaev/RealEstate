using System.Threading.Tasks;

namespace RealEstate.Core
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
