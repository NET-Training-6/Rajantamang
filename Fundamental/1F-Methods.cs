
using System;

class MethodLearn
{
    //method that returns nothing and takes no arguements

    public void print()
    {
        Console.WriteLine("Hello There");
        Console.WriteLine("I am inside simplest possible method");
    }


    //method that returns nothing and takes some arguements
    public void print(string message)  //if we put same method name like as Print its called method overlading
    {                                  // but we need different type of argument and datatype because same parameters not acces to overloading method

        Console.WriteLine("Hello There");
        Console.WriteLine(message);
    }

    //method that returns something and takes some arguements

    public double Sum(double a, double b)
    {
        var s = a +b;
        return s;
    }

    //Write a method takes number as a argument and returns if number is evern or odd
    public bool iseven( int number)
    {
        //Implementation 1
        
        /*if (number % 2== 0)
        {
            return true;
        }
        else
        {
            return false;
        }*/
        //Implementation 2
        var y= number %2==0? true: false;
        return y;

        //Implementation 3
        //return number %2==0;

        //Implementation 4
        // return (number &1)==0;

    
    }
    public double CalculateAverage(int num1, int num2, int num3=0)//num 3 is optional arguement
    {
        var sum =num1 + num2 +num3;
        var avg= sum/3;
        return avg;
    }
    
    // Expression bodied number
        public double Prod(double a, double b) =>  a *b;
     



}
