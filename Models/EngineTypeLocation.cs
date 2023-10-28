using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class EngineTypeLocation
{
    [Required] public long EngineTypeLocationId {get; set;}
    [Required][MaxLength(70)] public string EngineLocationTypeName {get; set;}
}