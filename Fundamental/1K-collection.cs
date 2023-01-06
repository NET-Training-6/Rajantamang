// I have a string variable called address=  "Tinkune, kathmandu, Nepal"
//1. print country locality
//2. print city name
//3. print country name

class Add
{


    public void Name()
    {
        /*string address = "Tinkune, Kathmandu, Nepal";

        var name = address.Split(", ");
        var locality = name[0] ;
        var city = name[1];
        var country = name[2];

        Console.WriteLine($"The Name of locality is {locality} ");
        Console.WriteLine($"The city name is {city} " );
        Console.WriteLine($"The country name is {country} ");
        */

        string address = "Tinkune, Kathmandu-Nepal";

        char[] delimiterChars = { ' ', ',',  '-' };

        var name = address.Split(delimiterChars );
        var locality = name[0] ;
        var city = name[1];
        var country = name[2];

        Console.WriteLine($"The Name of locality is {locality} ");
        Console.WriteLine($"The city name is {city} " );
        Console.WriteLine($"The country name is {country} ");


    }
}