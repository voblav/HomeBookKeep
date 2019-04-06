using HomeBookKeep.UWP;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(UwpDbPath))]
namespace HomeBookKeep.UWP
{
    public class UwpDbPath : IPath
    {
        public string GetDatabasePath(string sqliteFilename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
        }
    }
}
