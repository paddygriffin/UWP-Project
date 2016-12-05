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
        public static string Link = "http://api.openweathermap.org/data/2.5/weather";//might have to fix
        public static string Key = "5cd8eff4bbf4bb6f393a6b8c101a45d2"; //allows people to access without giving out the password  lat={lat}&lon={lon}

        public static string APIAccess(string lat, string lon)
        {
            //represesnt many characters and helps runtime by using the same mutable objects for manipulations 
            StringBuilder builder = new StringBuilder(Link);
            builder.AppendFormat("?lat={0}&lon={1}&APPID={2}&units=metric", lat, lon, Key); //taken from the above link,processing a composite format string
            //return value 
            return builder.ToString();
        }

        //adapted from- http://stackoverflow.com/questions/249760/how-to-convert-a-unix-timestamp-to-datetime-and-vice-versa
        public static DateTime ConvertUnixTimeToDateTime(double unix)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dt = dt.AddSeconds(unix).ToLocalTime();
            return dt;
        }


    }
}
