using Data;
using Microsoft.EntityFrameworkCore;
using Models.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Repository.Contracts;

namespace Infrastructure.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppContext db;

        public UserRepository()
        {
            this.db = new AppContext();
        }

        public async Task<ICollection<User>> GetUserList()
        {
            var users = await db.Users.ToListAsync();
            return users; 
        }


        public void Create(User user)
        {
            db.Users.AddAsync(user);
            db.SaveChangesAsync();
        }

    }
}
