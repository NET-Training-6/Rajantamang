/*Create appropriate data strcuture for following:
Hold names of 10 people and print them to standard console.
Store salaries of 6 people in a variable and print only the largest to console.*/

class Program
{
    static void Main(string[] args)
    {
        List<Name> people = new List<Name>();

        Console.Write("How many people are to be stored?: ");

        int personCount = Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=personCount; i++)
        {
            Console.Write("Name of person "+ i + ":");
            string nameInput=Console.ReadLine();
            Console.Write("Age of "+ nameInput +": ");
            int ageInput= Convert.ToInt32(Console.ReadLine());
            Console.Write("Height of " + nameInput + ": ");
            double heightInput = Convert.ToDouble (Console.ReadLine());
            people.Add(new Name(nameInput, ageInput, heightInput));
        }

        // here goes (i think) the code to type info stored in list

        Console.WriteLine("Press ENTER to close.");

        Console.ReadLine();
    }
