using Smanageemploy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Repositories.Contracts
{
    public interface ILeaverequestRepository
    {
        Task<Leaverequest> CreateLeaverequestAsync(Leaverequest leaverequestToCreate);

        Task<List<Leaverequest>> GetLeaverequestsAsync();

        Task<Leaverequest> GetLeaverequestByIdAsync(int leaverequestId);

        Task<Leaverequest> GetLeaverequestByIdWithIncludeAsync(int leaverequestId);

        Task<Leaverequest> UpdateLeaverequestAsync(Leaverequest leaverequestToUpdate);

        Task<Leaverequest> DeleteLeaverequestByIdAsync(int leaverequestId);
    }
}
