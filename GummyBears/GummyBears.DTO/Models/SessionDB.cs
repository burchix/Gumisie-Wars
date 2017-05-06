using System;

namespace GummyBears.DTO.Models
{
    public class SessionDB
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionHandle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
