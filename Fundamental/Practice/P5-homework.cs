
/*
Class 1 should has some fields and methods
Class 2 inherits Class 1
Class 3 has some fields on it
Interface 1 have some method definitions
Class 2 and Class 3 implements Interface 1
*/

class Production
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
}

class Marketing:Production
{
    
    public Marketing(int td, int dp, int wh): base (td, dp,wh)
    {
       
    }

}
class HRM
{
    
}