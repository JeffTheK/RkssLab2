using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Employee
{
    [Required] public long EmployeeId {get; set;}
    [Required] public long PersonId {get; set;}
    //[Required] public Person Person {get; set;}
    [Required] public long CarSalonId {get; set;}
    //[Required] public CarSalon CarSalon {get; set;}
    [Required] public long JobId {get; set;}
    //[Required] public Job Job {get; set;}
}