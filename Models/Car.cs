using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Car
{
    [Required] public long CarId { get; set; }
    [Required] public long CarBrandId {get; set;}
    [Required] public CarBrand CarBrand {get; set;}
    [Required] public long CountryId {get; set;}
    [Required] public Country Country {get; set;}
    [Required] public long CarModelId {get; set;}
    [Required] public CarModel CarModel {get; set;}
    [Required] public long ColorId {get; set;}
    [Required] public Color Color {get; set;}
    [Required] public long TechnicalDetailsId {get; set;}
    [Required] public TechnicalDetails TechnicalDetails {get; set;}
    public DateTime PublishedYears {get;set;}
    public bool Availability {get; set;}
}
