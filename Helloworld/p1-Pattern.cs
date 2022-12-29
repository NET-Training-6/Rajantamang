class Pattern
{
    public void LearnPattern()
    {
        int x, y;               //OutPut:
         for(x=1; x<=6; x++)    // ######
         {                      // ######
            for(y=1; y<=x; y++) // ######
            {
                Console.Write("#"); // ######
            }
            Console.WriteLine();
         }

        for(x=1; x<=5; x++)
        {
            for(y=x; y<=5; y++)
            {                   // ######
            Console.Write("#"); // ######
            }
            Console.WriteLine();
         }

                
         Console.Read();       

    }

}