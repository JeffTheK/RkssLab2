using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class EngineType
{
    [Required] public long EngineTypeId {get; set;}
    [Required][MaxLength(50)] public string EngineTypeName {get; set;}
}