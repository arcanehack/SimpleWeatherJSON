using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using System.Web.Script.Serialization;
using System.Net.Http;
using Newtonsoft.Json;

namespace LectureActivity6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = @"http://api.openweathermap.org/data/2.5/weather?q=Phoenix,us&appid=0933ac873dfdcdd6dce05fb419ec13dc";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();



            Console.WriteLine(responsereader);


            RootObject weatherObject = JsonConvert.DeserializeObject<RootObject>(responsereader);
        }
    }
}
