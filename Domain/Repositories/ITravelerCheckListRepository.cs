using Domain.Entities;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITravelerCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelerCheckList travelerCheckList);
        Task UpdateAsync(TravelerCheckList travelerCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList);
    }
}
