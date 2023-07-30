using Domain.Models;

namespace Infrostructure.Services;

public class CountryService
{
    private List<Country> countries;

    public CountryService()
    {
        countries=new List<Country>();
    }
    
    public List<Country> GetCountry()
    {
        return countries;
    }

    public void AddCountry(Country coutry)
    {
        countries.Add(coutry);
    }
    public int CountCountry()
    {
        return countries.Count;
    }
    
}
