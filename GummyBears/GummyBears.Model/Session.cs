using System;

namespace GummyBears.Model
{
    public class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionHandle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
