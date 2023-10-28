using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Region
{
    [Required] public int RegionId { get; set; }
    [Required] public int CountryId { get; set; }
    [Required][MaxLength(70)] public string RegionName { get; set; }
}