using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class WorkSchedule
{
    [Required] public int WorkScheduleId { get; set; }
    [Required] public int CarSalonId { get; set; }
}