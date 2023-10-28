using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Address
{
    [Required] public int AddressId { get; set; }
    [Required] public int AddressTypeId { get; set; }
    [Required] public int StreetId { get; set; }
    [Required][MaxLength(10)] public string BuildingNumber { get; set; }
    [MaxLength(10)] public string FlatNumbe { get; set; }
}