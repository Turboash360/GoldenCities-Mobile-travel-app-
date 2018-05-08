using System;
using System.IO;
using Xamarin.Forms;
using GoldenCities.iOS;
using GoldenCities.ClassModels;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace GoldenCities.iOS
{
    public class LocalFileHelper: ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if(!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}
