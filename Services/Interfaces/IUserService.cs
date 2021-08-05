using Models.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<ICollection<UserResponseDto>> GetUserList();
        void Create(UserRequestDto user);
    }
}
