using System.Threading.Tasks;
using RestSharp;
using System;

namespace Garden.Models
{
  class ApiHelper
  {
    public static async Task<string> Get(int zipcode)
    {
      RestClient client = new RestClient("https://localhost:5004/api");
      RestRequest request = new RestRequest($"ZipZones?zipcode={zipcode}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetSeeds()
    {
      RestClient client = new RestClient("https://localhost:5004/api");
      RestRequest request = new RestRequest("Seeds", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetSeed(int id)
    {
      RestClient client = new RestClient("http://localhost:5004/api/Seeds");
      RestRequest request = new RestRequest($"{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      System.Console.WriteLine("OAIJODAIJDOAIWJDOAIWJDOIAW" + response.Content);
      return response.Content;
    }
  }
}

//api/ZipZone?zipcode=97035