using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PiwoBack.Repository.ApplicationDbContext;
using PiwoBack.Data.Models;

namespace PiwoBack.Repository.DbInitializer
{
    public class DbInitializer
    {
        public static void Initialize(PiwoDbContext context)
        {
            context.Database.EnsureCreated();
            
            /*
            if (context.BeerRates.Any())
            {
                return;   // DB has been seeded
            }
            */
            var brewingGroups = new BrewingGroup[]
            {
                new BrewingGroup{ Address="miedna 4/2", Name="Warka browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Tyskie browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Okocim browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Lezajsk browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Specjal browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Kasztelan browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Debowe mocne browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Perla browary"},
                new BrewingGroup{ Address="miedna 4/2", Name="Elo siemanero browary"},
            };
            foreach(BrewingGroup group in brewingGroups)
            {
                context.BrewingGroups.Add(group);
            }

            var breweries = new Brewery[]
            {
                new Brewery{ Name="Warka"},
                new Brewery{ Name="Tyskie"},
                new Brewery{ Name="Okocim"},
                new Brewery{ Name="Lezajsk"},
                new Brewery{ Name="Specjal"},
                new Brewery{ Name="Kasztelan"},
                new Brewery{ Name="Debowe mocne"},
                new Brewery{ Name="Perla browary"},
                new Brewery{ Name="Elo siemanero"},
            };
            foreach(Brewery brewery in breweries)
            {
                context.Breweries.Add(brewery);
            }

            var beers = new Beer[]
            {
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"},
                new Beer{ Name="Warka", Alcohol = 5.34, Price=5.34, Description =" Dobre piwo"}
            };
            foreach (Beer beer in beers)
            {
                context.Beers.Add(beer);
            }

            var rates = new BeerRate[]
            {
                new BeerRate { Rate = 5, Beer = beers.ElementAt(0) }
            };
            foreach(BeerRate beerRate in rates)
            {
                context.BeerRates.Add(beerRate);
            }

           

            context.SaveChanges();
        }
    }
}
