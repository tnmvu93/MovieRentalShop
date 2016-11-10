
namespace MovieRentalShop.Handler.Queries.Users
{
    public class LoginQuery : IQuery
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
