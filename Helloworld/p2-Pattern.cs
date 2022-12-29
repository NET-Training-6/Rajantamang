class NumPattern
{
    public void PatternNumber()
    {
        int i, j;
        for(i=1; i<=6; i++)
        {
            for (j=1;j<=i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        for(i=6; i>=1; i--)
        {
            for (j=i;j<=6; j--)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.Read();
    }
}