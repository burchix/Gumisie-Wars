using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GummyBears.DAL.Repositories
{
    public class UserRepository : BaseRepository<UserDB, User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override User FromDBToModel(UserDB dbModel)
        {
            throw new NotImplementedException();
        }

        public override UserDB FromModelToDB(User model)
        {
            throw new NotImplementedException();
        }

        public User GetByLogin(string login)
        {
            UserDB userDB = _dbSet.SingleOrDefault(u => u.Login == login);
            return FromDBToModel(userDB);
        }
    }
}
