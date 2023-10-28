using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class PersonContact
{
    [Required] public int PersonContacId { get; set; }
    [Required] public int PersonId { get; set;}
    [Required] public int ContactTypeId { get; set; }
    [Required][MaxLength(100)] public string ContactValue { get; set; }
}