using Application.Exceptions;
using Domain.Repositories;
using Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Handlers
{
    internal sealed class TakeItemHandler : ICommandHandler<TakeItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public TakeItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(TakeItem command)
        {
            var TravelerCheckList = await _repository.GetAsync(command.TravelerCheckListId);

            if (TravelerCheckList is null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }

            TravelerCheckList.TakeItem(command.Name);

            await _repository.UpdateAsync(TravelerCheckList);
        }
    }
}
