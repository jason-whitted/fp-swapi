using System.Net.Http;
using Newtonsoft.Json;

namespace Swapi
{
  public static class RestApi
  {
    public static T Get<T>(string url)
    {
      var client = new HttpClient();
      var response = client.GetAsync(url).Result;
      var json = response.Content.ReadAsStringAsync().Result;
      return JsonConvert.DeserializeObject<T>(json);
    }
  }
}