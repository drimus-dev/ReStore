namespace API
{
    public class WeatherForecast
    {
        public DateOnly Date {get; set;}
        public int TemperatureC {get; set;}
        public int TemperatureF {get; set;}
        public string Summary {get; set;}

        public WeatherForecast(DateOnly date, int temp1, string summary)
        {
            Date = date;
            TemperatureC = temp1;
            Summary = summary;
        }
    }
}