using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class WorkDays
{
    [Required] public int WorkDaysId { get; set; }
    [Required][MaxLength(50)] public string DayName { get; set; }
}