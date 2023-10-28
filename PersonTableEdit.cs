using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Lab2.Models;

namespace Lab2
{
    public class PersonTableEdit : TableEditWindow<Person>
    {
        public PersonTableEdit(CarSalonContext carSalonContext, 
            DbSet<Person> dbset, 
            ErrorsWindow errorsWindow ) : base(
                carSalonContext, dbset, errorsWindow, 3, 
                new List<EntryType>(){
                    EntryType.IncrementedId,
                    EntryType.String,
                    EntryType.String,
                    EntryType.String,
                    EntryType.String, EntryType.NonIncrementedId,
                    EntryType.String
                }, new List<string>()
            {
                "",
                "Ім'я",
                "По Батькове",
                "Прізвище",
                "1900-01-01",
                "",
                ""
            })
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
                        entity.PersonId.ToString(),
                        entity.FirstName,
                        entity.MiddleName,
                        entity.LastName,
                        entity.BirthDate.ToString("yyyy-MM-dd"),
                        entity.SexId.ToString()
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = carSalonContext.Persons.ToList();
                carSalonContext.Persons.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var person = new Person()
                    {
                        PersonId = int.Parse(row[0].Text),
                        FirstName = row[1].Text,
                        MiddleName = row[2].Text,
                        LastName = row[3].Text,
                        BirthDate = DateTime.ParseExact(row[4].Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        SexId = int.Parse(row[5].Text)
                    };
                    carSalonContext.Persons.Add(person);
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
