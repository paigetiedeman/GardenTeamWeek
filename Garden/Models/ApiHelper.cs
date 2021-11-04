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
      RestClient client = new RestClient("https://localhost:5004/api/Seeds");
      RestRequest request = new RestRequest($"{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

     public static async Task Post(string newSeed)
    {
      RestClient client = new RestClient("https://localhost:5004/api");
      RestRequest request = new RestRequest($"Seeds", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newSeed);
      var response = await client.ExecuteTaskAsync(request);
    }

     public static async Task Put(int id, string newSeed)
    {
      RestClient client = new RestClient("https://localhost:5004/api");
      RestRequest request = new RestRequest($"Seeds/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newSeed);
      var response = await client.ExecuteTaskAsync(request);
    }

     public static async Task Delete(int id)
    {
      RestClient client = new RestClient("https://localhost:5004/api");
      RestRequest request = new RestRequest($"Seeds/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}

//api/ZipZone?zipcode=97035

// C:\Users\Becket\Desktop\GardenTeamWeek\Garden\Controllers\SeedsController.cs(49,28)
// : error CS1503: Argument 1: cannot convert from 'int' to 'Garden.Models.Seed' 
// [C:\Users\Becket\Desktop\GardenTeamWeek\Garden\G
// arden.csproj]
// C:\Users\Becket\Desktop\GardenTeamWeek\Garden\Controllers\SeedsController.
// cs(49,11): error CS0815: Cannot assign void to an implicitly-typed variable 
// [C:\Users\Becket\Desktop\GardenTeamWeek\Garden\Garden.cspro
// j]