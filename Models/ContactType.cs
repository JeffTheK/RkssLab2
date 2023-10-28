using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class ContactTyp
{
    [Required] public int ContactTypeId { get; set; }
    [Required][MaxLength(60)] public string ContactTypeName { get; set; }
}