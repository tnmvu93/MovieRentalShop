using System;

namespace MovieRentalShop.Handler.Entities
{
    public class User : BaseClass
    {
        public string Fullname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
    }
}
