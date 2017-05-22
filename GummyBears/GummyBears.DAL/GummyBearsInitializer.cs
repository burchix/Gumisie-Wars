using GummyBears.DTO.Models;
using System;
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

            var map = new MapDB()
            {
                Width = 4,
                Height = 4,
                CreateDate = DateTime.Now,
                Name = "Basic Map no. 1",
                DefenceMultiplier = "1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0",
                JuiceMultiplier = "1,0;1,0;1,0;1,0;1,0;15,0;15,0;1,0;1,0;15,0;15,0;1,0;1,0;1,0;1,0;1,0",
                GoldMultiplier = "10,0;10,0;10,0;10,0;10,0;150,0;150,0;10,0;10,0;150,0;150,0;10,0;10,0;10,0;10,0;10,0",
                GummiesMultiplier = "1;1;1;1;1;15;15;1;1;15;15;1;1;1;1;1",
                GummiesNumber = "5;0;0;0;0;0;0;0;0;0;0;0;0;0;0;5",
                GummiesType = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0",
                Owner = "1;1;0;3;1;0;0;0;0;0;0;2;3;0;2;2"
            };
            context.Maps.Add(map);
            var map2 = new MapDB()
            {
                Width = 3,
                Height = 3,
                CreateDate = DateTime.Now,
                Name = "Basic Map no. 2",
                DefenceMultiplier = "1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0",
                JuiceMultiplier = "1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0",
                GoldMultiplier = "1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0;1,0",
                GummiesMultiplier = "1;1;1;1;1;1;1;1;1",
                GummiesNumber = "0;0;0;0;0;0;0;0;0;0",
                GummiesType = "0;0;0;0;0;0;0;0;0;0",
                Owner = "1;0;0;0;0;0;0;0;2"
            };
            context.Maps.Add(map2);

            context.SaveChanges();
        }
    }
}
