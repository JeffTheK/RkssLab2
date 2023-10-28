using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class CarBrand
{
    [Required] public long CarBrandId {get; set;}
    [Required][MaxLength(50)] public string CarBrandName {get; set;}
}