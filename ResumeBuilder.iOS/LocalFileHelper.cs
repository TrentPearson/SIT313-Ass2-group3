using System;
using System.IO;
using Xamarin.Forms;
using ResumeBuilder.Droid;
using ResumeBuilder.Data;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace ResumeBuilder.Droid
{
    public class LocalFileHelper : ILocalFileHelper
    {

        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "library", "databases");
            if(!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}
