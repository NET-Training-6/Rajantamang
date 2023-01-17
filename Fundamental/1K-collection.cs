// List of somethinbg

using System;
using System.Collections.Generic;

class CollectionLearner
{
    public void learnLists()
    {
        /* List<int> numbers = new List<int>(){12457, 1212, 1213};
         numbers.Add(2342);
         numbers.Add(1234);
         numbers.Add(2145);
         numbers.Add(12456);
         numbers.Remove(1234);

         foreach(var num in numbers)
         {
             // Console.WriteLine(num);
         }*/

        List<string> namespeople = new List<string>() { "Rajan ", "Ramesh yonjan", "Ipshika Bhattarai", "Puja ", "Sagar KC", "Aaryan Maharjan", "Santosh Karki", "Muna Shrestha", "Harke-Kanchha", "Haku-Kale" };

        foreach (var name in namespeople)
        {
            //Console.WriteLine(name.ToUpper());

            if (name.Length <= 6)
            {
                // Console.WriteLine(name.ToUpper());
            }
        }
        // Create list of at least 10 numbers abd print in console only the numbers multiple of 3 and 5.

        List<int> numbers = new List<int>() { 15, 25, 12, 21, 30, 60, 17, 180, 66, 75 };


        foreach (var num in numbers)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine(num);
            }
        }
        // Create list of date of births of 8 people. Print those dobs in console oldest first.

        List<DateTime> Birth = new List<DateTime>();
        





    }
}