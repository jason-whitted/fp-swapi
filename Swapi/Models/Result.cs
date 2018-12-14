using System.Collections.Generic;
using Newtonsoft.Json;

namespace Swapi
{
  public class ResultSet<T>
  {
    [JsonProperty("count")]
    public int Count { get; set; }

    [JsonProperty("next")]
    public string NextUrl { get; set; }

    [JsonProperty("previous")]
    public string PreviousUrl { get; set; }

    [JsonProperty("results")]
    public List<T> Results { get; set; }
  }
}