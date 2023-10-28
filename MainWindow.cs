using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;
using Lab2.Models;

namespace Lab2
{
    public class MainWindow : Window
    {
        public TableEditWindow<Person> personTableWindow;
        public ErrorsWindow errorsWindow;

        public MainWindow() : base("Лабораторна 2 - Автор Колібабчук Дмитро")
        {
            SetupTabs();

            // Connect the Destroy event to close the application
            DeleteEvent += (o, args) => Application.Quit();
        }

        public void SetupTabs()
        {
            var db = new CarSalonContext();
            if (db.IsEmpty())
            {
                db.Database.Delete();
            }
            // Create a notebook to hold the tabs
            Notebook notebook = new Notebook();

            // Create and add tabs to the notebook
            Label tabLabel1 = new Label("Employee");
            Label tabLabel2 = new Label("CarSalon");
            Label tabLabel3 = new Label("Person");
            Label tabLabel4 = new Label("Job");
            Label errorsWindowTabLabel = new Label("Системні Повідомлення");

            this.errorsWindow = new ErrorsWindow(this);

            // Add widgets or content to the tabs
            var employeeTableWindow = new EmployeeTableEdit(db, db.Employees, this.errorsWindow);
            employeeTableWindow.table.OnTableModified += (row, column) => { tabLabel1.Text = tabLabel1.Text.Replace("*", "") + "*"; };
            employeeTableWindow.OnTableSaved += () => { tabLabel1.Text = tabLabel1.Text.Replace("*", ""); };

            var carSalonTableWindow = new CarSalonTableEdit(db, db.CarSalons, this.errorsWindow);
            carSalonTableWindow.table.OnTableModified += (row, column) => { tabLabel2.Text = tabLabel2.Text.Replace("*", "") + "*"; };
            carSalonTableWindow.OnTableSaved += () => { tabLabel2.Text = tabLabel2.Text.Replace("*", ""); };

            var personTableWindow = new PersonTableEdit(db, db.Persons, this.errorsWindow);
            personTableWindow.table.OnTableModified += (row, column) => { tabLabel3.Text = tabLabel3.Text.Replace("*", "") + "*"; };
            personTableWindow.OnTableSaved += () => { tabLabel3.Text = tabLabel3.Text.Replace("*", ""); };

            var jobTableWindow = new JobTableEdit(db, db.Jobs, this.errorsWindow);
            jobTableWindow.table.OnTableModified += (row, column) => { tabLabel4.Text = tabLabel4.Text.Replace("*", "") + "*"; };
            jobTableWindow.OnTableSaved += () => { tabLabel4.Text = tabLabel4.Text.Replace("*", ""); };

            // Append tabs to the notebook
            notebook.AppendPage(employeeTableWindow, tabLabel1);
            notebook.AppendPage(carSalonTableWindow, tabLabel2);
            notebook.AppendPage(personTableWindow, tabLabel3);
            notebook.AppendPage(jobTableWindow, tabLabel4);
            notebook.AppendPage(errorsWindow, errorsWindowTabLabel);

            // Add the notebook to the window
            Add(notebook);

            Resize(600, 600);
        }
    }
}
