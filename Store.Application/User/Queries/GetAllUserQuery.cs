using MediatR;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Application.User.Queries
{
    public record GetAllUserQuery() : IRequest<IEnumerable<UserEntity>>;

    public class GetAllUserQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUserQuery, IEnumerable<UserEntity>>
    {
        public async Task<IEnumerable<UserEntity>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetUsers();
        }
    }
}
