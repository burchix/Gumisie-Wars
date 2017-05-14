using GummyBears.Common.Interfaces;
using System.Collections.Generic;

namespace GummyBears.Common.Models
{
    public class User : IObjWithId
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
