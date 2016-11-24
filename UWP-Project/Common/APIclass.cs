using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Project.Common
{
    public class APIclass //make public as we will be implementing the APL key + link 
    {
        //API Link and Key 
        public static string Link = "http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}";
        public static string Key = "5cd8eff4bbf4bb6f393a6b8c101a45d2";
    }
}
