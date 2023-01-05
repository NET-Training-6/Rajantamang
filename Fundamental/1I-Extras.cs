
//Constants

class Car
{
    string vendor;
    string category;
    double price;
    const byte numberOfWheel = 4; //this is constant for number of wheel which  cant change on objects. compile-time
    readonly byte gear = 5; // Run time constant which value can be change on run-time.

    static byte seats = 4; //static fields can be access direct on class level. /constant is by default static.

    void test ()
    {
       Car car1 = new();
       car1.vendor  = "TATA";

       Car.seats = 5; 

    }
}