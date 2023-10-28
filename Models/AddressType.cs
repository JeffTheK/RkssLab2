using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class AddressType
{
    [Required] public int AddressTypeId { get; set; }
    [Required][MaxLength(80)] public string AddressTypeName { get; set; }
}