using MediatR;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Application.User.Commands
{
    public record UpdateUserCommand(UserEntity UserEntity) : IRequest<UserEntity>;

    public class UpdateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<UpdateUserCommand, UserEntity>
    {
        public async Task<UserEntity> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await userRepository.UpdateUserAsync(request.UserEntity);
        }
    }
}
