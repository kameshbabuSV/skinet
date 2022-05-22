using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser{
                    DisplayName = "Kamesh",
                    Email = "kamesh@test.com",
                    UserName = "kamesh@test.com",
                    Address = new Address{
                        FirstName = "Kamesh",
                        LastName = "SV",
                        Street = "10th Street",
                        City = "Madurai",
                        State = "TN",
                        ZipCode = "625012"
                    }
                };
                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}