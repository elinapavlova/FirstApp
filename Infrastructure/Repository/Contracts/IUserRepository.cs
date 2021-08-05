using Models.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Contracts
{
    public interface IUserRepository 
    {
        Task<ICollection<User>> GetUserList();

        void Create(User user);
    }
}
