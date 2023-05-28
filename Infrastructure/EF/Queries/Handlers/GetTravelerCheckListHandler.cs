using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.DTO;
using Application.Queries;

using Infrastructure.EF.Contexts;
using Infrastructure.EF.Models;

using Microsoft.EntityFrameworkCore;

using Shared.Abstractions.Queries;

namespace Infrastructure.EF.Queries.Handlers
{
    internal sealed class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public GetTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
            => _TravelerCheckLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
