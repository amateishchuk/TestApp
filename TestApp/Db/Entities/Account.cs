using System;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Db.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }

    }
}
