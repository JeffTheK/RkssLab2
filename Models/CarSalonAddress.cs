using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class CarSalonAddress
{
    [Required] public int CarSalonId { get; set; }
    [Required] public int AddressId { get; set; }
}