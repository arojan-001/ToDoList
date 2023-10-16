namespace toDoList.Data
{

    public class WeatherForecastService
    {
        public async Task<WeatherForecast[]> GetWeatherForecastsAsync()
        {
            // In a real application, this is where you would make an actual HTTP request to fetch data from an external source.
            // For simplicity, we'll simulate data retrieval here.
            await Task.Delay(1000); // Simulate a delay (e.g., network request)
            var forecasts = new[]
            {
            new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 20,
                Summary = "Sunny"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = 25,
                Summary = "Cloudy"
            },
            // Additional forecast data...
        };
            return forecasts;
        }
    }

}
