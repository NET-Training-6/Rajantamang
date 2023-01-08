public class Exercise5
{
    public  void stories()
    {
        string story = "One day, a fox became very hungry as he went to search for some food. He searched high and low, but couldn’t find something that he could eat. Finally, as his stomach rumbled, he stumbled upon a farmer’s wall.";
         
        int  wrd, l;

        // Console.Write("\n\nCount the total number of words in a string :\n");
        // Console.Write("------------------------------------------------------\n");
        // Console.Write("Input the string : ");
        // story = Console.ReadLine();

        l = 0;
        wrd = 1;

        /* loop till end of string */
        while (l <= story.Length - 1)
        {
            /* check whether the current character is white space or new line or tab character*/
            if (story[l] == ' ' || story[l] == '\n' || story[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
    }
}