using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore.Extensions;
using System.Data.Entity;
using Lab2.Models;

namespace Lab2
{
    public class CarSalonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<CarSalon> CarSalons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (optionsBuilder.IsConfigured)
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    optionsBuilder.UseMySQL("server=localhost;database=car_salon_cs;user=root;password=123;CharSet=utf8;");

        //}

        public bool IsEmpty()
        {
            try
            {
                return Persons.Count() == 0 && CarSalons.Count() == 0 && Employees.Count() == 0 && Jobs.Count() == 0;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
