using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender,Domain.ValueObjects.Temperature Temperature,
        Destination Destination);
}
