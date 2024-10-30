using MediatR;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Application.User.Commands
{
    public record DeleteUserCommand(Guid userId) : IRequest<bool>;

    public class DeleteUserCommandHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand, bool>
    {
        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return await userRepository.DeleteUserAsync(request.userId);
        }
    }
}
