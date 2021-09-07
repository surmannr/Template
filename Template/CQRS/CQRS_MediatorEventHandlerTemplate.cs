using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Template.CQRS
{
    public class CQRS_MediatorEventHandlerTemplate : INotificationHandler<Event>
    {
        public OrderCreatedEventHandler()
        {
        }

        public async Task Handle(Event notification, CancellationToken cancellationToken)
        {
        }
    }
}