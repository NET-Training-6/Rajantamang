class Cigeratte
{
    string vendor;

    // Full property definition 
    double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value > 0)
                price = value;
        }
    }
    //public string vendor { get; set; } //auto-implemented property
    public string vendor1 { get; private set; }
    public string vendor2 { get; }
}

class GJHGLJ
{
    void Test()
    {
        Cigeratte khill1 = new();
        khill1.Price = -20;
    }
}