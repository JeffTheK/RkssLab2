using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Color
{
    [Required] public long ColorId {get; set;}
    [Required][MaxLength(70)] public string ColorName {get; set;}
}