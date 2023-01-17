// Language Integrated Query -LINQ
//Way/Technique to query collection

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = { 2, 3, 4, 5, 56, 78, 10, 12, 23, 45, 67 };

    List<string> names = new() { "Bishnu", "Sagar", "Rajan", "Ram", "Pooja", "Ipshikha", "Aaryan" };

    public void Test()
    {
        //Get all even numbers in "numbers"
        //get all odd numbers in "numbers"
        //get all numbers which end with "0"

        //Imperative way
        List<int> evenNumbers = new List<int>();

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }
        //At this poing"evenNumbers"

        var evenNums = numbers.Where(num1 => num1 % 2 == 0);
        foreach (var n in evenNums)
        {
            //Console.WriteLine(n);
        }
        //Console.WriteLine("And The Odd Numbers are follows: ");

        var oddNums = numbers.Where(num => num % 2 == 1);
        foreach (var odd in oddNums)
        {
            //Console.WriteLine(odd);
        }

        var numEnding = numbers.Where(num => num.ToString().EndsWith("0"));

        foreach (var end in numEnding)
        {
            //Console.WriteLine(end);
        }
        //Projections
        //4. Get square of all numbers in "numbers" array.
        var squares = numbers.Select(num => num * num);

        foreach (var n in squares)
        {
            // Console.WriteLine(n);
        }

        //5. Get squares of elements which are greater than 50

        var SquareGreater = numbers.Where(num => num > 50).Select(num => num * num);
        foreach (var n in SquareGreater)
        {
            Console.WriteLine(n);
        }

        //6. Get all person names which starts with Letter 'A' in "Names" List

        var people = names.Where(naam => naam.StartsWith('A'));
        foreach (var pname in people)
        {
            Console.WriteLine(pname);
        }

        //7.Get all person names with less than 4 characters and convert them to uppercase
        var person = names.Where(n => n.Length < 4).Select(n => n.ToUpper());

        foreach (string name in person)
        {
            Console.WriteLine(name);
        }












    }

}