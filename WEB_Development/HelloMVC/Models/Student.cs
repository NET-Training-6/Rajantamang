namespace HelloMVC.Models;

public class Student
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTime Dob { get; set; }
    public Sex Gender { get; set; } = Sex.Male;

}

public enum Sex
{
    Male,
    Female,
    Others
}
