using MediatR;

namespace Template.CQRS
{
    public interface ICommand<TResult> : IRequest<TResult>
    {
    }
}