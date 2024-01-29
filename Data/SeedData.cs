using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lab4.Data
{
    public static class SeedData{

    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
    }

    public static List<City> GetCities()
    {
    List<City> cities = new List<City>() 
    {
        new City { CityId = 1, CityName = "Vancouver", Population = 675218, ProvinceCode = "BC" },
        new City { CityId = 2, CityName = "Surrey", Population = 517887, ProvinceCode = "BC" },
        new City { CityId = 3, CityName = "Burnaby", Population = 249197, ProvinceCode = "BC" },
        new City { CityId = 4, CityName = "Calgary", Population = 1239220, ProvinceCode = "AB" },
        new City { CityId = 5, CityName = "Edmonton", Population = 932546, ProvinceCode = "AB" },
        new City { CityId = 6, CityName = "Red Deer", Population = 100418, ProvinceCode = "AB" },
        new City { CityId = 7, CityName = "Toronto", Population = 2731571, ProvinceCode = "ON" },
        new City { CityId = 8, CityName = "Ottawa", Population = 934243, ProvinceCode = "ON" },
        new City { CityId = 9, CityName = "Mississauga", Population = 721599, ProvinceCode = "ON" }
    };

    return cities;
    }


    public static List<Province> GetProvinces()
    {
    List<Province> provinces = new List<Province>() 
    {
        new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
        new Province { ProvinceCode = "AB", ProvinceName = "Alberta" },
        new Province { ProvinceCode = "ON", ProvinceName = "Ontario" }
    };

    return provinces;
    }


    // {
    //     public static void Initialize(IServiceProvider serviceProvider)
    //     {
    //         using (var context = new ApplicationDbContext(
    //             serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
    //         {
    //             // Look for any provinces.
    //             if (context.Provinces.Any())
    //             {
    //                 return;   // DB has been seeded
    //             }

    //             var provinces = new Province[]
    //             {
    //                 new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
    //                 new Province { ProvinceCode = "AB", ProvinceName = "Alberta" },
    //                 new Province { ProvinceCode = "ON", ProvinceName = "Ontario" }
    //             };

    //             foreach (Province p in provinces)
    //             {
    //                 context.Provinces.Add(p);
    //             }
    //             context.SaveChanges();

    //             var cities = new City[]
    //             {
    //                 new City { CityName = "Vancouver", Population = 675218, ProvinceCode = provinces[0].ProvinceCode },
    //                 new City { CityName = "Surrey", Population = 517887, ProvinceCode = provinces[0].ProvinceCode },
    //                 new City { CityName = "Burnaby", Population = 249197, ProvinceCode = provinces[0].ProvinceCode },

    //                 new City { CityName = "Calgary", Population = 1239220, ProvinceCode = provinces[1].ProvinceCode },
    //                 new City { CityName = "Edmonton", Population = 932546, ProvinceCode = provinces[1].ProvinceCode },
    //                 new City { CityName = "Red Deer", Population = 100418, ProvinceCode = provinces[1].ProvinceCode },

    //                 new City { CityName = "Toronto", Population = 2731571, ProvinceCode = provinces[2].ProvinceCode },
    //                 new City { CityName = "Ottawa", Population = 934243, ProvinceCode = provinces[2].ProvinceCode },
    //                 new City { CityName = "Mississauga", Population = 721599, ProvinceCode = provinces[2].ProvinceCode }
    //             };

    //             foreach (City c in cities)
    //             {
    //                 context.Cities.Add(c);
    //             }
    //             context.SaveChanges();
    //         }
    //     }
    // }
    }
}