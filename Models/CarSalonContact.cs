using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class CarSalonContact
{
    [Required] public int CarSalonId { get; set; }
    [Required] public int ContactTypeId { get; set; }
    [Required][MaxLength(100)] public string ContactValue { get; set; }
}