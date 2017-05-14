using GummyBears.DTO.Models;
using System.Collections.Generic;

namespace GummyBears.DAL
{
    public class GummyBearsInitializer : System.Data.Entity./*DropCreateDatabaseAlways*/DropCreateDatabaseIfModelChanges<GummyBearsContext>
    {
        protected override void Seed(GummyBearsContext context)
        {
            var users = new List<UserDB>
            {
                new UserDB() { Login = "burchix", Password = "burchix" },
                new UserDB() { Login = "kamilslaw", Password = "kamilslaw" }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
