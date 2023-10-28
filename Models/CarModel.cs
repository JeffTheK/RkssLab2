using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class CarModel
{
    [Required] public long CarModelId {get; set;}
    [Required][MaxLength(50)] public string CarModelName {get; set;}
}