
/*
Class 1 should has some fields and methods
Class 2 inherits Class 1
Class 3 has some fields on it
Interface 1 have some method definitions
Class 2 and Class 3 implements Interface 1
*/

using System;

class Production : Staff
{
    string NameOfStaff;
    byte NumberOfStaff;
    int DaysOfPresent;
    int TotalDays, WeekHoliday;


    public Production(string ns, int td, int dp, int wh)
    {
        NameOfStaff= ns;
        TotalDays = td;
        DaysOfPresent = dp;
        WeekHoliday = wh;
         
    }
    public int Calculateleave()=> TotalDays- (WeekHoliday+DaysOfPresent);
    public virtual void Details() => Console.WriteLine($"the staff  {NameOfStaff} have take {Calculateleave()} leave and his total present is {DaysOfPresent} days. ");
}

class Marketing:Production
{
    
    public Marketing(string ns,int td, int dp, int wh): base (ns,td, dp,wh)
    {
       
    }

}
class HRM : Staff
{
    public string NameOfDept;
    public string NameOfStaff;
    byte NumberOfStaff;


    public void Details()
    {
        Console.WriteLine($"the staff name= {NameOfStaff} who is belong to department= {NameOfDept} have ");
    }
}


interface Staff 
{
    public void Details()
    {
      

    }
}