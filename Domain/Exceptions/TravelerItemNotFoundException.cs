
using Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public TravelerItemNotFoundException(string itemName) : base($"Traveler item '{itemName}' was not found.")
            => ItemName = itemName;
    }
}
