using System;

namespace Specification.ClientAdministrator.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
