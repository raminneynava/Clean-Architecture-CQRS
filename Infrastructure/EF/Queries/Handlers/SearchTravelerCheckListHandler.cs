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
    internal sealed class SearchTravelerCheckListHandler : IQueryHandler<SearchTravelerCheckList, IEnumerable<TravelerCheckListDto>>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public SearchTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public async Task<IEnumerable<TravelerCheckListDto>> HandleAsync(SearchTravelerCheckList query)
        {
            var dbQuery = _TravelerCheckLists
                .Include(pl => pl.Items)
            .AsQueryable();

            if (query.SearchPhrase is not null)
            {
                dbQuery = dbQuery.Where(pl =>
                    Microsoft.EntityFrameworkCore.EF.Functions.Like(pl.Name, $"%{query.SearchPhrase}%"));
            }

            return await dbQuery
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
