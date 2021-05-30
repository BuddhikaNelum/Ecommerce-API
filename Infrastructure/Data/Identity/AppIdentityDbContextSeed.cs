using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Buddhika",
                    Email = "buddhika@test.com",
                    UserName = "buddhika@test.com",
                    Address = new Address
                    {
                        FirstName = "Buddhika",
                        LastName = "Nelum",
                        Street = "10 th street",
                        City = "Galle",
                        State = "Southern",
                        ZipCode = "80044"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
