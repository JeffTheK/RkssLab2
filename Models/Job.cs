using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Job
{
    [Required] public long JobId {get; set;}
    public string JobName {get; set;}
}