using System;

class Loop
{
    public void LearnLoop()
{
   /*for(byte counter=1; counter<=100; counter++)
   {
    Console.WriteLine($"{counter}  ");

   }*/

   char input ='y';
   while(input== 'y')
   {
    Console.Write("Run Again? press: y or n:  ");
    input = Console.ReadKey().KeyChar;

   }

//    byte[] ages= {23, 25, 22, 12, 55};

//    foreach(var age in ages)
//    {
//     Console.WriteLine(age);
   }


}


