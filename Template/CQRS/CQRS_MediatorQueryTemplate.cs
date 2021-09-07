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
    public static class CQRS_MediatorQueryTemplate
    {
        public class Query : IRequest<ModelDto>
        {

        }

        public class Handler : IRequestHandler<Query, ModelDto>
        {
            public Handler()
            {
            }

            public async Task<ModelDto> Handle(Query request, CancellationToken cancellationToken)
            {
            }
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {

            }
        }
    }
}
