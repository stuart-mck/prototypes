using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class DataContext
    {


        public Article GetAutoTransArticle()
        {
            return new autoTransmissionArticle();
        }


        public static string GetContent(string fileName)
        {
            var path =  Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "bin", "Resources");
            var thisFile = Path.Combine(path, fileName + ".txt");
            if (File.Exists(thisFile))
                return File.ReadAllText(Path.Combine(path, thisFile));
            return "File Not Found";
        }

        public Article GetEngineManagementArticle()
        {
            return new engineManagement();
        }

        public Article GetTechTalkArticle()
        {
            return new TechTalk();
        }

        public Article GetServiceScheduleArticle()
        {
            return new fordService();
        }
    }
}
