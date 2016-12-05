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
        public static async Task<WeatherAttributes> GetWeather(string lat, string lon)
        {
            //httpRequest 
            /*using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page)) ;
            
             */
            //https://www.dotnetperls.com/httpclient - Adapted from here

            using (var httpClient = new HttpClient()) // using HttpClient initialize a new instance
            {
                var response = await httpClient.GetAsync(Common.APIclass.APIAccess(lat, lon)); //result that wants to be displayed by GET request
                var resultText = await response.Content.ReadAsStringAsync(); //sets the content of the response message

                if (response.StatusCode == System.Net.HttpStatusCode.OK) 
                {
                    try
                    {
                        var users = JsonConvert.DeserializeObject<WeatherAttributes>(resultText); //Newtonsoft.Json that we installed
                        return users;
                    }
                    catch (Exception)
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
