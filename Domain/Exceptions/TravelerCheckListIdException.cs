

using Shared.Abstractions.Exceptions;

namespace Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {

        public TravelerCheckListIdException() : base("Traveler Checklist ID cannot be empty.")
        {
        }
    }
}
