using Newtonsoft.Json;

namespace Swapi.Models
{
  public class Root
  {
    [JsonProperty("films")]
    public string FilmsUrl { get; set; }

    [JsonProperty("people")]
    public string PeopleUrl { get; set; }

    [JsonProperty("planets")]
    public string PlanetsUrl { get; set; }

    [JsonProperty("species")]
    public string SpeciesUrl { get; set; }

    [JsonProperty("starships")]
    public string StarshipsUrl { get; set; }

    [JsonProperty("vehicles")]
    public string VehiclesUrl { get; set; }
  }
}