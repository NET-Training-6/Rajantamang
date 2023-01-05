//managed and Unmanged code
//Memory management

class Animal1
{
    //Default parameterless Constructor
    public Animal1()  
    {

    }

    //Parameterized Constructor
    public Animal1(string name,int legs, bool id)
    {
        animalName = name;
        isDomestic = id;
        noOfLegs= legs;
    }



    public string animalName;
    public int noOfLegs;
    public bool isDomestic;
}

class Test
{
    void Test1()
    {
        Animal1 animal1 =new Animal1(name:"Dog",legs:4,id:true );

        Animal1 animal2 =new();
        Animal1 animal3 =new();
        Animal1 animal4 =new();
    }
}