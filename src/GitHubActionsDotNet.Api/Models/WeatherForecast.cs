namespace GitHubActionsDotNet.Api.Models;

public record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }

<<<<<<< HEAD
    public string? Observatory { get; init; }
=======
	public string? Observatory { get; init; }
>>>>>>> 2bc5d15 (add CI (update))
}
