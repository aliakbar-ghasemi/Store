using MediatR;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Application.User.Commands
{
    public record AddUserCommand(UserEntity UserEntity) : IRequest<UserEntity>;

    public class AddUserCommandHandler(IUserRepository userRepository) : IRequestHandler<AddUserCommand, UserEntity>
    {
        public async Task<UserEntity> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return await userRepository.AddUserAsync(request.UserEntity);
        }
    }
}
