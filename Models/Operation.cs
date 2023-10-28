using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models;

public class Operation
{
	[Required] public int OperationId { get; set; }
	[Required] public int CarId { get; set; }
	[Required] public int PersonId { get; set; }
	[Required] public int TypeOfOperationId { get; set; }
	[Required] public int EmployeeId {get; set;}
	[Required] public int CarSalonId { get; set; }
	[Required] public int NoteId { get; set; }
	[Required] public DateTime OperationDate { get; set; }
}