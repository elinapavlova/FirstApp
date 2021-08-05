using AutoMapper;
using Models.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Exceptions;
using Infrastructure.Repository.Contracts;
using Services.Interfaces;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<UserResponseDto>> GetUserList()
        {
            var users = _mapper.Map<ICollection<UserResponseDto>>(await _repository.GetUserList());
            return users;
        }

        public void Create(UserRequestDto userDto)
        {
            if (userDto.FirstName == null || userDto.LastName == null || userDto.Message == null)
                throw new ValidationException("Все поля должны быть заполнены","");
            
            var user = _mapper.Map<User>(userDto);
            _repository.Create(user);
        }
    }
}
