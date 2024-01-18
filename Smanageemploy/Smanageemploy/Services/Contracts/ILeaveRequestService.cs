using Smanageemploy.Dtos.Leaverequest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Services.Contracts
{
    public interface ILeaverequestService
    {
        Task<ReadLeaverequest> CreateLeaverequestAsync(CreateLeaverequest leaverequest);

        Task<List<ReadLeaverequest>> GetLeaverequests();

        Task<ReadLeaverequest> GetLeaverequestByIdAsync(int leaverequestId);

        Task<Leaverequest> UpdateLeaverequestAsync(int leaverequestId, UpdateLeaverequest leaverequest);

        Task<Leaverequest> DeleteLeaverequestById(int leaverequestId);
    }
}
