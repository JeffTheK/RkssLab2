using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2
{
    public class EmployeeTableEdit : TableEditWindow<Employee>
    {
        public EmployeeTableEdit(CarSalonContext carSalonContext, DbSet<Employee> dbset, ErrorsWindow errorsWindow) :
            base(carSalonContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.NonIncrementedId,
                EntryType.NonIncrementedId,
                EntryType.NonIncrementedId
            }, new List<string>()
            {
                "",
                "PersonId",
                "CarSalonId",
                "JobId"
            }
                )
        {
            if (carSalonContext.IsEmpty())
            {
                AddRow(this, null);
            }
            else
            {
                foreach (var entity in dbset.ToList())
                {
                    table.AddRow(new List<string>() {
                        entity.EmployeeId.ToString(),
                        entity.PersonId.ToString(),
                        entity.CarSalonId.ToString(),
                        entity.JobId.ToString()
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = carSalonContext.Employees.ToList();
                carSalonContext.Employees.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var employee = new Employee()
                    {
                        EmployeeId = int.Parse(row[0].Text),
                        PersonId = int.Parse(row[1].Text),
                        CarSalonId = int.Parse(row[2].Text),
                        JobId = int.Parse(row[3].Text)
                    };
                    carSalonContext.Employees.Add(employee);
                    Console.Write(".");
                }
                base.OnSaveButtonClicked(sender, e);
            }
            catch (Exception ex)
            {
                errorsWindow.Report(ex.ToString());
            }
        }
    }
}