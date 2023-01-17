
using System;

class Generic{


    public void print (string message)
    {
        Console.WriteLine(message);
    }

    public void print<T> (T message)  //data type can write as argument.. where T take any type of data type which we want to use 
    {
        Console.WriteLine(message);
    }

    void test()
    {
        print <string>("Nepal is beautiful");
        print <byte>(23);
        print <double>(4545.56);
        print <bool>(true);
        print <DateTime>(DateTime.Now);
        print <Animal1>(new Animal1());
        
    }




}