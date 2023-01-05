//write a method that takes an number arry and return average of those


class Methodpractice
{
    public double AverageCalculate(int[] numbers)//if we use like: (params inf[] numbers) then we can direct put aour valu while call function.
    {
        var sum1= 0;
        /*for(int i=0; i <= 5; i++)
        {
             sum1 =  numbers[i];

        }
        double aveg= sum1 / numbers.Length;

        return aveg;*/

        foreach(var num in numbers)
        {
            sum1 = sum1 + num;
        }
        var average = sum1/ numbers.Length;
        return average;

    }
    // Write a method that takes bunch of numbers and returns minimum among them

    public double getminimum(params int[] numbers)
    {
        var min= numbers[0]; //[3, 5, 1, 8, 9]
        foreach (var num in numbers)
        {
            if(num<min)
            {
                min= num;
            }
            
        }
        return min;
    }
    // Write a metod to finds sum and product of two numbers

    public (int, int ) GetSumAndProduct(byte n1, byte n2)
    {
        var s= n1 + n2;
        var p= n1 * n2;
        return (s, p);

    }
  


}