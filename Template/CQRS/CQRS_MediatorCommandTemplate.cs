using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Template.CQRS
{
    public static class CQRS_MediatorCommandTemplate
    {
        public class Command : ICommand<ModelDto>
        {

        }

        public class Handler : IRequestHandler<Command, ModelDto>
        {
            public Handler()
            {
            }
            
            public async Task<ModelDto> Handle(Command request, CancellationToken cancellationToken)
            {
            }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {

            }
        }
    }
}
