using CasaDiscuri.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDiscuri.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                   new Product
                   {
                       Name = "In Memoriam",
                       Description = "Compilatie cu cele mai iubite melodi",
                       Artist = "Ion Dolanescu",
                       Category = "Populara",
                       Price = 25
                   },
                    new Product
                    {
                        Name = "Reign in Blood",
                        Description = "Albumul de referinta pentru Thrash Metal",
                        Artist = "Slayer",
                        Category = "Metal",
                        Price = 28.95m
                    },
                    new Product
                    {
                        Name = "Fata din Vis",
                        Description = "Unul dintre cele mai bune albume de muzica Rock Romaneasca",
                        Artist = "Compact",
                        Category = "Rock",
                        Price = 29.50m
                    },
                    new Product
                    {
                        Name = "Rosu si Negru",
                        Description = "Compilatie cu cele mai renumite melodii ale formatiei Rosu si Negru",
                        Artist = "Rosu si Negru",
                        Category = "Rock",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Dorul Basarabiei",
                        Description = "Un album care te iti va atinge in mod direct sufletul",
                        Artist = "Ion Paladi",
                        Category = "Populara",
                        Price = 50m
                    },
                    new Product
                    {
                        Name = "Peace Sells",
                        Description = "Album agresiv d.p.d.v. textier si melodic",
                        Artist = "Megadeth",
                        Category = "Metal",
                        Price = 56m
                    },
                    new Product
                    {
                        Name = "Voi Canta",
                        Description = "Albumul de debut al Mirabelei Daur",
                        Artist = "Mirabela Daur",
                        Category = "Usoara",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Best Of Dan Spataru",
                        Description = "Cele mai apreciate melodi ale lui Dan Spataru",
                        Artist = "Dan Spataru",
                        Category = "Usoara",
                        Price = 45m
                    },
                    new Product
                    {
                        Name = "Cand eram in Satul meu",
                        Description = "Relansat si remasterizat in 2007",
                        Artist = "Benone Sinulescu",
                        Category = "Populara",
                        Price = 55m
                    },
                    new Product
                    {
                        Name = "Cat e Siriul de MAre",
                        Description = "Relansat si remasterizat in 2004",
                        Artist = "Benone Sinulescu",
                        Category = "Populara",
                        Price = 56m
                    },
                    new Product
                    {
                        Name = "Still Reigning",
                        Description = "Interpretarea live a albumului Reign in Blood",
                        Artist = "Slayer",
                        Category = "Metal",
                        Price = 30.95m

                    });
                context.SaveChanges();
            }
        }
    }
}