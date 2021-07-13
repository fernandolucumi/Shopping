
namespace Shop.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.AspNetCore.Identity;
    //using Shop.Web.Helpers;

    public class SeedDB
    {
        private readonly DataContext _context;
        //private readonly IUserHelper userHelper;
        // private readonly UserManager<User> userManager;
        private readonly Random random;
       // public SeedDB(DataContext context, IUserHelper userHelper)
        public SeedDB(DataContext context)
        {
            _context = context;
            // this.userHelper = userHelper;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            //var user = await this.userHelper.GetUserByEmailAsync("jzuluaga55@gmail.com");
            //if (user == null)
            //{
            //    user = new User
            //    { 
            //        FirstName = "Juan",
            //        LastName = "Zuluaga",
            //        Email = "jzuluaga55@gmail.com",
            //        UserName = "jzuluaga55@gmail.com",
            //        PhoneNumber = "3506342747"
            //    };

            //    var result = await this.userHelper.AddUserAsync(user, "123456");
            //    if (result != IdentityResult.Success)
            //    {
            //        throw new InvalidOperationException("It could not create the user in seeder");
            //    }
            //}


            if (!_context.Products.Any())
            {
                //this.AddProduct("iPhone x", user);
                //this.AddProduct("Magic Mouse", user);
                //this.AddProduct("iWatch Series 4", user);
                //await this.context.SaveChangesAsync();

                this.AddProduct("iPhone x");
                this.AddProduct("Magic Mouse");
                this.AddProduct("iWatch Series 4");
                await _context.SaveChangesAsync();
            }
        }

        //private void AddProduct(string name, User user)
        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(1000),
                IsAvailable = true,
                Stock = this.random.Next(100),
                //User = user
            });
        }
    }
}

