using System;
using System.IO;
using HomeBookKeep.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosDbPath))]
namespace HomeBookKeep.iOS
{
    public class IosDbPath : IPath
    {
        public string GetDatabasePath(string sqliteFilename)
        {
            // определяем путь к бд
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", sqliteFilename);
        }
    }
}