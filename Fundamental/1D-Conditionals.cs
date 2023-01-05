class ConditionalLearner
{
    //Ask user to enter his/her total percentage and greet him/her as following:
    // if his total marks less than 60%, print "you passed with second division".
    // if his total marks greater than 60% and less than 80%, print "you passed with First division".
    // if his total marks greater than 80%, print "you passed with Distiction".

    public void task1()
    {
        Console.Write("Enter your total percentage: ");
        var markText = Console.ReadLine();
        var totalMark = double.Parse(markText);

        if (totalMark < 60)
        {
            Console.WriteLine("You passed with Second division");

        }

        else if (totalMark > 60 && totalMark < 80)
        {
            Console.WriteLine("You passed with First division");

        }
        else if (totalMark > 80 && totalMark < 100)
        {
            Console.WriteLine("You passed with Disction");

        }
        else
        {
            Console.WriteLine("You Enter invalid marks");

        }



    }

}