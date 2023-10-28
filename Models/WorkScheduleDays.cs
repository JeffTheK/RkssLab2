using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class WorkScheduleDays
{
    [Required] public int WorkScheduleId { get; set; }
    [Required] public int CarSalonId { get; set; }
}