using Smanageemploy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Repositories.Contracts
{
    public interface IStatusRepository
    {
        Task<List<Status>> GetStatusesAsync();

        Task<Status> GetStatusByIdAsync(int statusId);
    }
}
