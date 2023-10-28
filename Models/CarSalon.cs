using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class CarSalon
{
    [Required] public long CarSalonId {get; set;}
    [Required] public string SalonName {get; set;}
}