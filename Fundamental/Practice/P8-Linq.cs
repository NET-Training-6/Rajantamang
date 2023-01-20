using System;
using System.Collections.Generic;
using System.Linq;

public class Country1
{

    //Create a class called "Country" with fields "Name", "Area", "Continent" and "GDP". Then create list of 10 countries like:
    List<Country> countries = new()
    {
        new Country{Name = "Nepal",Continent = "Asia", Area = 17823783.23, GDP = 84728},
        new Country{Name = "USA", Continent = "North America", Area = 9817823783.23, GDP = 9999997823798472},
        new Country{Name = "England", Continent = "Europe", Area = 130279000, GDP = 9999997822},
        new Country{Name = "Germany", Continent = "Europe", Area = 9817823783.23, GDP = 823798472},
        new Country{Name = "Brasil", Continent = "South America", Area = 9817823783.23, GDP = 9798472},
        new Country{Name = "Argentina", Continent = "South America", Area = 9817823783.23, GDP = 9999997823798472},
        new Country{Name = "UAE", Continent = "Asia", Area = 9817823783.23, GDP = 9999997823798472},
        new Country{Name = "South Africa", Continent = "Africa", Area = 9817823783.23, GDP = 9999997823798472},
        new Country{Name = "Japan", Continent = "Asia", Area = 37797330.23, GDP = 798472},
        new Country{Name = "New Zealand", Continent = "Australia", Area = 9817823783.23, GDP = 823798472}

    };

    public void QueryCountry()
    {
        //1. Find all asian countries.
        var AllCountry = countries.Where(c => c.Continent == "Asia");//.Select(c => c.Name); //method syntax
        // AllCountry = from c in countries
        //              where c.Continent == "Asia"
        //              select c.Name;

        foreach (var con in AllCountry)
        {
            //Console.WriteLine($"The Asian countries name are: {con.Name} ");

        }

        // Find top 5 poorest countries. (Use OrderBy())
        var poorCountry = countries.OrderBy(c=> c.GDP).Take(5);

        foreach (var pc in poorCountry)
        {
            Console.WriteLine(pc.Name);
        }


    }


}
public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }

    public double Area { get; set; }
    public double GDP { get; set; }

}




// And answer following in both method and expression syntax:

