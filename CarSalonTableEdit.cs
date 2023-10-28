using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2
{
    public class CarSalonTableEdit : TableEditWindow<CarSalon>
    {
        public CarSalonTableEdit(CarSalonContext carSalonContext, DbSet<CarSalon> dbset, ErrorsWindow errorsWindow) : 
            base(carSalonContext, dbset, errorsWindow, 3, new List<EntryType>() { 
                EntryType.IncrementedId,
                EntryType.String
            }, new List<string>()
            {
                "",
                "Назва салону"
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
                        entity.CarSalonId.ToString(),
                        entity.SalonName
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = carSalonContext.CarSalons.ToList();
                carSalonContext.CarSalons.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var carSalon = new CarSalon()
                    {
                        CarSalonId = int.Parse(row[0].Text),
                        SalonName = row[1].Text
                    };
                    carSalonContext.CarSalons.Add(carSalon);
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
