using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class BodyType
{
    [Required] public int BodyTypeId {get; set;}
    [Required][MaxLength(50)] public string BodyTypeName {get; set;}
}