using QuickReserve.Domain.Entities;
using QuickReserve.Infrastructure.Persistence;

namespace QuickReserve.Infrastructure.Seeders
{
    public class RestaurantSeeder
    {
        private readonly QuickReserveDbContext _dbContext;

        public RestaurantSeeder(QuickReserveDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = new List<Restaurant>()
                    {
                        new Restaurant(){
                        Name = "McDonald's",
                        Description = "McDonald's Corporation (McDonald's) is one of the world's largest" +
                        " and most recognized fast-food chains, known for its hamburgers, french fries," +
                        " and name-brand sandwiches such as the Big Mac, Quarter Pounder, and Egg McMuffin, as well as the child-focused Happy Meal.",
                        TypeOfRestaurant = "Fast food",
                        DoesItDeliver = true,
                        ContancDetails = new()
                        {
                            City = "Warsaw",
                            PhoneNumber = "+48123456789",
                            Street = "Świętokrzyska",
                            PostalCode = "00-360"
                        }
                        },
                        new Restaurant(){
                        Name = "KFC",
                        Description = "KFC (abbreviation of Kentucky Fried Chicken) is an American chain of fast food restaurants" +
                        " known for their fried chicken. It was started by Colonel Sanders in Corbin, Kentucky in 1952. They are now" +
                        " all over the world. They not only sell chicken, but also other food like salads and french fries.",
                        TypeOfRestaurant = "Fast food",
                        DoesItDeliver = true,
                        ContancDetails = new()
                        {
                            City = "Warsaw",
                            PhoneNumber = "+48123098765",
                            Street = "Wołoska",
                            PostalCode = "02-583"
                        }
                        },
                        new Restaurant(){
                        Name = "Lily’s Bistro",
                        Description = "Lily's Bistro, located at 137 Świderska Street in Warsaw's Białołęka district, is a restaurant serving" +
                        " international and Italian cuisine. The menu includes, among others: pizzas, burgers and various main dishes. The restaurant" +
                        " also offers lunch from Monday to Friday from 12:00 to 16:00. Due to the variety of dishes served and the form of service, Lily's" +
                        " Bistro is not classified as fast food.\r\n\r\n",
                        TypeOfRestaurant = "Casual dining",
                        DoesItDeliver = false,
                        ContancDetails = new()
                        {
                            City = "Warsaw",
                            PhoneNumber = "+48456789123",
                            Street = "Świderska",
                            PostalCode = "03-128"
                        }
                        }
                    };

                    _dbContext.Restaurants.AddRange(restaurants);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
