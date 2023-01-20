// Language Integrated Query -LINQ
//Way/Technique to query collection

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = { 2, 3, 4, 5, 56, 78, 10, 12, 23, 45, 67 };

    List<string> names = new() { "Bishnu", "Sagar", "Rajan", "Ram", "Pooja", "Ipshikha", "Aaryan" };

    List<Employee> employees = new()
    {  
        new Employee {Name= "Rajan Tamang", Age= 21, Department= "HR", Designation = "Software Engineer"},
        new Employee {Name= "Shyam Rana", Age= 20, Department= "HR", Designation = "Software Engineer"},
        new Employee {Name= "Sagar KC", Age= 28, Department= "R & D", Designation = "QA"},
        new Employee {Name= "Aaryan Maharjan", Age= 27, Department= "IT", Designation = "IT Officer"},
        new Employee {Name= "Ipshika Bhattarai", Age= 22, Department= "Marketing", Designation = "Marketing Manager"}  
        
    };
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

        //var evenNums = numbers.Where(num1 => num1 % 2 == 0);

        var evenNums = from num in numbers
                    where num%2 ==0
                    select num;
        foreach (var n in evenNums)
        {
            //Console.WriteLine(n);
        }
        //Console.WriteLine("And The Odd Numbers are follows: ");

        var oddNums = numbers.Where(num => num % 2 == 1); //method syntax

        oddNums = from num in numbers       // Expression Syntax
                    where num%2==1
                    select num;
        foreach (var odd in oddNums)
        {
            //Console.WriteLine(odd);
        }

        var numEnding = numbers.Where(num => num.ToString().EndsWith("0")); // method syntax
        numEnding = from num in numbers                 // Expression syntax
                    where num.ToString().EndsWith("0")
                    select num;

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

    public void LINQDay2()
    {
        //1. find if "numbers" array contain any even number

        var hasEven = numbers.Any(n => n % 2 == 0); //Quantifiers: Any, All

        //2. find if "numbers" array has all even number
        var AllEven = numbers.All(n => n % 2 == 0);

        //3. Get first 5 elements from "numbers"
        var takeFive = numbers.Take(5);


        //4. Get 5 elements skipping first 2 from "numbers"
        var skipTake = numbers.Skip(2).Take(5);
    }
    public void LearnToQuery()
    {
        //1. Get all employee in HR department

        var HREmployee = employees.Where(emp => emp.Department == "HR");

        //2. Get names of employee in HR department
        var EmployeeName = employees.Where(emp => emp.Department == "HR").Select(emp => emp.Name);
        EmployeeName = from emp in employees
                        where emp.Department=="HR"
                        select emp.Name;
        
        foreach(var em in employees)
        { 
            //Console.WriteLine($"name: {em.Name} ");  

        }
        //3. Get all Software Engineers under age of 22
        var post = employees.Where(emp => emp.Designation == "Software Engineer" && emp.Age<22);

        foreach(var em in post)
        {
           // Console.WriteLine($"Name: {em.Name}\nDepartment: {em.Department}\nDesignation:{em.Designation} \nand Age is:  {em.Age}\n");
            
        }


    }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string Department { get; set; }
    public string Designation { get; set; }





}