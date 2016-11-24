using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UWP_Project.Common;
using UWP_Project.Model;

namespace UWP_Project.Helper
{
    public class Helper
    {
        public static async Task<WeatherAttributes> GetWeather(string latitude, string longitude)
        {
            //httpRequest 
            /*using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page)) ;
            
             */
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Common.APIclass.APIAccess(latitude, longitude));
                var resultText = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK) 
                {
                    try
                    {
                        var users = JsonConvert.DeserializeObject<WeatherAttributes>(resultText); //Newtonsoft.Json that we installed
                        return users;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(resultText);
                        return null;
                    }
                }
                return null;
            }
        }
    }
}
