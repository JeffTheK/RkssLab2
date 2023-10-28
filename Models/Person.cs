using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Person
{
    [Required] public long PersonId {get; set;}
    [Required] public string FirstName {get; set;}
    public string MiddleName {get; set;}
    [Required] public string LastName {get; set;}
    [Required] public DateTime BirthDate {get; set;}
    [Required] public long SexId {get; set;}
    //public Sex Sex {get; set;}
}