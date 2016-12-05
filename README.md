# UWP-Project
An application that I developed on Visual studio in c# for UWP that provides the user with the local weather.

###Initial Goals
- To use an API
- Use GeoLocations
- Apply Async/await

###Extensions
added:
- window mobile extensions for uwp
- Newtonsoft.Json
Thid can be done through Manage NuGet Packages in the Reference of the solution Another way is to install through the Package Manager Console using the following command: PM> Install-Package Newtonsoft.Json -Version 9.0.1

###Keeping Track
I used Github issues to monitor and keep track of the work 

###Summary of API call
API call from the geographic coordinates: api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}
Where lon = longitude and lat = latitude

To get API calls copy http://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid= "Enter key here"
this will generate json formmated weather attributes
I then formatted the json to c# into getters and setters in the class weatherAttributes

**note:** you must register to access your API key

### Technical Summary
**XAML**:I divided the page with Grid definitions 
```xaml
  <Grid.RowDefinitions>
                <RowDefinition Height="*" />
                <RowDefinition Height="*" />
                <RowDefinition Height="*" />
                <RowDefinition Height="*" />
    </Grid.RowDefinitions>
```
This structures the app into a readilble format with the bitmap image in the upper centre.

I used a progress ring as I ran into difficultly with the progress bar to show that data is being loaded. This progress ring needs to be set:
```c#
progressRing.IsActive = true;
```
In the MainPage.xaml.cs page before the data is being loaded and set to false after the data is loaded.
I used stackpanels and TextBloacks to display weather data here is an example:
```xaml
<StackPanel Grid.Row="2" Orientation="Vertical"
                        VerticalAlignment="Center"
                        HorizontalAlignment="Center"
                        >
                <TextBlock x:Name="txtDescription"
                           Text=""
                           FontWeight="SemiBold"
                           FontSize="20"
                           Foreground="Black"
                           TextAlignment="Center"
                           HorizontalAlignment="Center"/>
```
In this example the txtDescription is linked to the mainpage.xaml.cs where data is being formed.
```c#
txtDescription.Text = $"{data.weather[0].description}";
```
The data is using async/await to retrieve data from online in the "Helper" class
```
var data = await Helper.Helper.GetWeather(Lat, Lng);
```
The GetWeather is from the get/set class with weather attributes which was converted from JSON to c# from the openweather website.
```json
{  
   "coord":{  
      "lon":138.93,
      "lat":34.97
   },
   "weather":[  
      {  
         "id":803,
         "main":"Clouds",
         "description":"broken clouds",
         "icon":"04n"
      }
   ],
   "base":"stations",
   "main":{  
      "temp":289.006,
      "pressure":1013.37,
      "humidity":100,
      "temp_min":289.006,
      "temp_max":289.006,
      "sea_level":1022.88,
      "grnd_level":1013.37
   },
   "wind":{  
      "speed":10.25,
      "deg":264.001
   },
   "clouds":{  
      "all":80
   },
   "dt":1480961959,
   "sys":{  
      "message":0.056,
      "country":"JP",
      "sunrise":1480887470,
      "sunset":1480923149
   },
   "id":1851632,
   "name":"Shuzenji",
   "cod":200
}
```
I then converted this to C# and you can see in my mainpage.xaml.cs how i incorporated these into my app.


###References
- https://openweathermap.org/ For accesing API
- https://www.dotnetperls.com/httpclient accessing online
- http://www.wpftutorial.net/gridlayout.html  XAML code assitance
- http://stackoverflow.com/questions/24238373/geolocation-in-c-sharp geolocation
- [Channel9 Tutorial for weather app](https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-058-UWP-Weather-Setup-and-Working-with-the-Weather-API)
- https://www.dotnetperls.com/httpclient for httpClient
- http://stackoverflow.com/questions/24238373/geolocation-in-c-sharp - for geolocation
- http://stackoverflow.com/questions/249760/how-to-convert-a-unix-timestamp-to-datetime-and-vice-versa - for timestamp
- https://msdn.microsoft.com/en-us/library/aa970269(v=vs.110).aspx - bitmap image
