using LAB14C.Model;
using LAB14C.Services;
using LAB14C.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace LAB14C.ViewModels
{
    public class InsertCourseViewModel : BaseViewModel
    {
        private string name;
        private string description;
        private decimal credit;
        private DateTime startDate;
        private ICommand insertCommand;
        private readonly CourseService courseService;
        
        public InsertCourseViewModel()
        {
            courseService = new CourseService();
            InsertCommand = new Command(InsertCourse);
        }
        
        public string Name
        {
            get { return name; }
            set { SetValue(ref name, value); }
        }

        public string Description
        {
            get { return description; }
            set { SetValue(ref description, value); }
        }

        public decimal Credit
        {
            get { return credit; }
            set { SetValue(ref credit, value); }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { SetValue(ref startDate, value); }
        }

        public ICommand InsertCommand
        {
            get { return insertCommand; }
            set { SetValue(ref insertCommand, value); }
        }

        

        private void InsertCourse()
        {
            // Crear una instancia de Course con los datos ingresados
            Course course = new Course
            {
                Name = Name,
                Description = Description,
                Credit = Credit,
                StartDate = StartDate
            };

            // Insertar el curso utilizando el servicio CourseService
            bool isInserted = courseService.Create(course);

            if (isInserted)
            {
                // Realizar las acciones necesarias después de insertar el curso, si las hay
            }
            else
            {
                // Mostrar un mensaje de error en caso de fallo en la inserción
                // Puedes implementar la lógica para mostrar mensajes de error según tus necesidades
                // Ejemplo: DisplayAlert("Error", "Error al insertar el curso", "Aceptar");
            }
        }
    }
}
