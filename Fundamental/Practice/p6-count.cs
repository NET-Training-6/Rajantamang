using System;

public class Exercise5
{

    string story = @"One day, a fox became very hungry as he went to search for some food.\\
        He searched high and low, but couldn’t find something that he could eat.\\
        Finally, as his stomach rumbled, he stumbled upon a farmer’s wall.";
    public void countsentences()
    {
        var delimiterChars = new char[] { '.', '?' };
        var paragraph = story.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

        int Sentences = paragraph.Length;

        Console.WriteLine("Total number of sentence in the story is: " + Sentences);

        var seprator = new char[] { ' ', '\n' };
        var Specialchar = new char[] { '.', '?', ',', '-' };
        var sent = story.Split(seprator, StringSplitOptions.RemoveEmptyEntries);
        int word = sent.Length;
        Console.WriteLine("Total number of sentence in the story is: " + word);

        foreach (var w in sent)
        {
            var sabda = w;
            Console.WriteLine("#######################################");

            foreach (char sc in Specialchar)
            {
                if (sabda.Contains(sc))
                {
                    sabda = sabda.Replace(sc.ToString(), "");
                }
            }
            Console.WriteLine(sabda);

        }



    }
    public void CountCharacters()
    {
        int x = story.Length;
        int noOfSpaces = 0;
        foreach (var c in story)
        {
            if (c == ' ')
            {
                noOfSpaces++;
            }
            else
            {
                Console.Write($"{c}\t");
            }
        }
        Console.WriteLine($"Character Counts: {x - noOfSpaces} and characters are following:");
    }
}