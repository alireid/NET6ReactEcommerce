using Microsoft.AspNetCore.Identity;

namespace NET6ReactEcommerce.Entities
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}