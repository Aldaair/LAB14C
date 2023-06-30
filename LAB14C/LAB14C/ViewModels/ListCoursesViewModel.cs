using System.Collections.ObjectModel;
using LAB14C.Model;
using LAB14C.Services;

namespace LAB14C.ViewModels
{
    public class ListCoursesViewModel : BaseViewModel
    {
        private ObservableCollection<Course> courses;
        private readonly CourseService courseService;

        public ObservableCollection<Course> Courses
        {
            get { return courses; }
            set { SetValue(ref courses, value); }
        }

        public ListCoursesViewModel()
        {
            courseService = new CourseService();

            // Aquí puedes obtener la lista de cursos desde tu servicio o cualquier otra fuente de datos.
            // Por ejemplo, puedes llamar al método Get() del servicio CourseService para obtener los cursos.
            // Luego, asigna la lista de cursos a la propiedad "Courses" para que se muestren en la vista.

            LoadCourses();
        }

        private void LoadCourses()
        {
            // Obtener todos los cursos utilizando el servicio CourseService
            Courses = new ObservableCollection<Course>(courseService.Get());
        }
    }
}
