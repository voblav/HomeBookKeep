using HomeBookKeep.Models;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HomeBookKeep
{
    public partial class App : Application
    {
        public const string DBFILENAME = "koshel2.db";
        public App()
        {
            InitializeComponent();

            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DBFILENAME);
            using (var db = new ApplicationContext(dbPath))
            {
                // Создаем бд, если она отсутствует/ If DB is not found, then we create it
                db.Database.EnsureCreated();
                if (db.Units.Count() == 0)
                {
                    db.Units.Add(new Unit { Name = "штук" });
                    db.Units.Add(new Unit { Name = "литры" });
                    db.Units.Add(new Unit { Name = "килограммы" });
                    db.Units.Add(new Unit { Name = "м2" });
                    db.Units.Add(new Unit { Name = "банка" });
                    db.SaveChanges();
                }
            }

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
