using System;
using System.IO;
using ResumeBuilder.Data;
using ResumeBuilder.Droid; 
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalFilerHelper))]
namespace ResumeBuilder.Droid
{
    public class LocalFilerHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "library", "databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}
