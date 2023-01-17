// I have a string variable called address=  "Tinkune, kathmandu, Nepal"
//1. print country locality
//2. print city name
//3. print country name

using System;

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

        /*string address = "Tinkune, Kathmandu-Nepal";

        char[] delimiterChars = { ' ', ',',  '-' };

        var name = address.Split(delimiterChars );
        var locality = name[0] ;
        var city = name[1];
        var country = name[2];

        Console.WriteLine($"The Name of locality is {locality} ");
        Console.WriteLine($"The city name is {city} " );
        Console.WriteLine($"The country name is {country} ");*/


        // we have paragraph 
        string story = @"One day, a fox became very hungry as he went to search for some food.\\
        He searched high and low, but couldn’t find something that he could eat.\\
        Finally, as his stomach rumbled, he stumbled upon a farmer’s wall.";

        //char[] delimiterChars = { ' ', ',',  '.' };
        //count number of words, sentence and character
        int wrd, l, s, sent;
        l = 0;
        wrd = 1;
        s=0;
        sent = 0;
        while (l <= story.Length - 1)
        {
            if (story[l] == ' '|| story[l]=='\t' || story[l]=='\\' )
            {
                wrd++;
            }

            l++;

        }
        Console.Write("Total number of words in the story is : {0}\n", wrd);

        while (s <= story.Length -1)
        {
            if (story[s] == '.'|| story[s]=='?' )
            {
                sent++;
            }

            s++;

        }
        Console.Write("Total number of sentence in the story is : {0}\n", sent);



    }
}