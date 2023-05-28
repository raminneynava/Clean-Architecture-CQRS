using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.DTO;

using Shared.Abstractions.Queries;

namespace Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
    {
        public Guid Id { get; set; }
    }
}
