using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public class UserRepository : BaseRepository<UserDB, User>, IUserRepository
    {
        public UserRepository(DbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public User GetByLogin(string login)
        {
            UserDB userDB = _dbSet.SingleOrDefault(u => u.Login == login);
            return userDB == null ? null : _mapper.Map<User>(userDB);
        }
    }
}
