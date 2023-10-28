using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class PersonAddress
{
    [Required] public int PersonId { get; set; }
    [Required] public int AddressId { get; set; }
}