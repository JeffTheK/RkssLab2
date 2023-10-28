using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Country
{
    [Required] public long CountryId {get; set;}
    [Required][MaxLength(50)] public string CountryName {get; set;}
}