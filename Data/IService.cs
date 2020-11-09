using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment1.Data
{
    public interface IService
    {
        Task<IList<Adult>> GetAdultsAsync();

        Task AddAdultAsync(Adult adult);

        Task RemoveAdultAsync(Adult adult);

        Task UpdateAsync(Adult adult);
    }
}