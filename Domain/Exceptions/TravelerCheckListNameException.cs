

using Shared.Abstractions.Exceptions;

namespace Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {

        public TravelerCheckListNameException() : base("Traveler CheckList list name cannot be empty.")
        {
        }
    }
}
