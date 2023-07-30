using Domain.Models;
using Infrostructure.Services;

var countrService=new CountryService();
var count=countrService.GetCountry();

for (int i =0; i <= count.Count(); i++)
{
    var countr=new Country();
    System.Console.WriteLine($"Counry{i}");
    System.Console.Write("Enter the name of country : ");
    countr.Name=Console.ReadLine();
    System.Console.Write("Enter the name of capital : ");
    countr.Capital=Console.ReadLine();
    System.Console.Write("Enter the language of country : ");
    countr.Language=Console.ReadLine();
    System.Console.Write("Enter the population of country : ");
    countr.Population=Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the cities of country : ");
    countr.Cities=Convert.ToInt32(Console.ReadLine());

    countrService.AddCountry(countr);
    List<Country> listOfCounries = countrService.GetCountry();
    foreach (var country in listOfCounries)
    {
        System.Console.WriteLine();
        System.Console.Write("Country: ");
        System.Console.WriteLine(country.Name);
        System.Console.Write("Capital: ");
        System.Console.WriteLine(country.Capital);
        System.Console.Write("Language: ");
        System.Console.WriteLine(country.Language);
        System.Console.Write("Population: ");
        System.Console.WriteLine(country.Population);
        System.Console.Write("Cities: ");
        System.Console.WriteLine(country.Cities);
        System.Console.WriteLine("-----------------");
    }
}
