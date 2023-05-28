using Domain.Consts;
using Domain.Entities;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);

        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination);
    }
}
