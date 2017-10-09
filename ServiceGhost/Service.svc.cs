using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RedditSharp;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace ServiceGhost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public void LogIn(string user, string pass)
        {
        }

        public void GetSub()
        {
            var r = new Reddit();
            var x = r.GetPopularSubreddits(5);
            Console.WriteLine(x);
        }

        public int GetSync()
        {
            Random r = new Random();
            var num = r.Next(1, 100);
            return num;
        }

        public async Task<int> GetAsync()
        {
            await Task.Delay(0);
            Random r = new Random();
            var num = r.Next(1, 100);
            return num;
        }
    }
}
