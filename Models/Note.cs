using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Note
{
    [Required] public int NoteId { get; set; }
    [Required][MaxLength(20)] public string NoteName { get; set; }
}