using Smanageemploy.Dtos.Status;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Services.Contracts
{
    public interface IStatusService
    {
        Task<List<ReadStatus>> GetStatuses();

        Task<ReadStatus> GetStatusByIdAsync(int statusId);
    }
}
