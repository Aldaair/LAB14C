using LAB14C.DataContext;
using LAB14C.Interfaces;
using LAB14C.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LAB14C
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new ListCoursesView();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
