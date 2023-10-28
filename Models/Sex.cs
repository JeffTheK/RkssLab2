using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Sex
{
    [Required] public long SexId {get; set;}
    public string Description {get;set;}
}