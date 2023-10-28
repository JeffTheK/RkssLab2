using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2
{
    public class JobTableEdit : TableEditWindow<Job>
    {
        public JobTableEdit(CarSalonContext carSalonContext, DbSet<Job> dbset, ErrorsWindow errorsWindow) :
            base(carSalonContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.String
            }, new List<string>()
            {
                "",
                "Назва роботи"
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
                        entity.JobId.ToString(),
                        entity.JobName
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = carSalonContext.Jobs.ToList();
                carSalonContext.Jobs.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var job = new Job()
                    {
                        JobId = int.Parse(row[0].Text),
                        JobName = row[1].Text
                    };
                    carSalonContext.Jobs.Add(job);
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