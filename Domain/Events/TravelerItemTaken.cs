using Domain.Entities;
using Domain.ValueObjects;
using Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    public record TravelerItemTaken(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;

}
