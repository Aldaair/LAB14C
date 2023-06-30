using LAB14C.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LAB14C.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCoursesView : ContentPage
    {
        public ListCoursesView()
        {
            InitializeComponent();
            this.BindingContext = new ListCoursesViewModel();
        }
    }
}