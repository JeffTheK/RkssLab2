using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class TechnicalDetails
{
    [Required] public long TechnicalDetailsId {get; set;}
    [Required] public long BodyTypeId {get; set;}
    [Required] public BodyType BodyType {get; set;}
    [Required] public long EngineTypeId {get; set;}
    [Required] public EngineType EngineType {get; set;}
    [Required] public long EngineTypeLocationId {get; set;}
    [Required] public EngineTypeLocation EngineTypeLocation {get; set;}
    [Required] public int NumberOfDoors {get; set;}
    [Required] public int NumberOfSeats {get; set;}
    [Required] public int EngineDisplacement {get; set;}
}