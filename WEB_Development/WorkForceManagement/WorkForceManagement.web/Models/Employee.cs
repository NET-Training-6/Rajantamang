using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WorkForceManagement.web.Enum;

namespace WorkForceManagement.web.Models;

public class Employee
{
	public int Id { get; set; }
	[Required (ErrorMessage = "Please Enter your Name"), MinLength(2, ErrorMessage = "Atleast 2 letter")]
	public string Name	 { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	public Gender Gender { get; set; }
	[DisplayName("Date of Birth"), DataType(DataType.Date)]
	public DateTime Dob { get; set; }
	public string Contact { get; set; } = string.Empty;
	[DisplayName("Join Date"), DataType(DataType.Date)]
	public DateTime JoinDate { get; set; }
	public string Department { get; set; } = string.Empty;
	public string Designation { get; set; } = string.Empty;
	[NotMapped]
	[DisplayName ("Upload Your Profile Image")]
	public IFormFile? ProfileImage { get; set; }

	public string ProfileImagePath { get; set; }= string.Empty;
}
