using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class TypeOfOperation
{
    [Required] public int TypeOfOperationId { get; set; }
    [Required][MaxLength(50)] public string TypeName { get; set; }
}