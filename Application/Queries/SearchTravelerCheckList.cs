using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.DTO;

using Shared.Abstractions.Queries;

namespace Application.Queries
{
    public class SearchTravelerCheckList : IQuery<IEnumerable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
