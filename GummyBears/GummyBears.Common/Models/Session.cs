using GummyBears.Common.Interfaces;
using System;

namespace GummyBears.Common.Models
{
    public class Session : IObjWithId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionHandle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
