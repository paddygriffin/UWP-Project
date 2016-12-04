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


###References
- https://openweathermap.org/ For accesing API
- https://www.dotnetperls.com/httpclient accessing online
- http://www.wpftutorial.net/gridlayout.html  XAML code assitance
- http://stackoverflow.com/questions/24238373/geolocation-in-c-sharp geolocation
