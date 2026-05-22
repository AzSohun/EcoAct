using EcoAct.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoAct.Domain.Repositories
{
    public interface ICampaignRepositories
    {
        Task<IEnumerable<Campaign>> GetAllAsync();
        Task<Campaign?> GetByIdAsync(Guid id);
        Task CreateAsync(Campaign campaign);
        Task UpdateAsync(Campaign campaign);
        Task DeleteAsync(Guid id);
    }
}
