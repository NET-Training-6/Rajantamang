// Write a class for rectangle, this class should have methods/implementation to calculate
// area and perimeter

using System;

class Rectangle : IShape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double CalculatArea() => length * width;

    public double CalPerimeter() => 2 * (length + width);
     public virtual void PrintDetails()
    {
        Console.WriteLine($"I am rectangle with l={length} and w= {width}.");
    } 
}

// Write a class for square, this class should be have methods to calculate area and perimeters

class Square : Rectangle
{
    double side;

    public Square(double s) : base(s, s)
    {
        side =s;

    }
    public override void PrintDetails()
    {
        Console.WriteLine($"I am Square with s = {side}");
    } 
}

class Triangle : IShape
{
    double a,b,c;

    public Triangle(double a, double b, double c)
    {
        this.a =a;
        this.b =b;
        this.c =c;

    }

    public double CalPerimeter() => a +b +c;

    public double CalculatArea()
    {
        var s = ( a + b +c)/2;

        var area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        return area;

    }
    public void PrintDetails()
    {
        Console.WriteLine($"I am triangle with side A={a}, B={b} and C = {c}.");
    } 

}
// Display details of all the 2D shapes

interface IShape
{
    public void PrintDetails();
}
