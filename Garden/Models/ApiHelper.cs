using System.Threading.Tasks;
using RestSharp;

namespace Garden.Models
{
  class ApiHelper
  {
    public static async Task<string> Get(int zipcode)
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"zipcode", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}

//api/zipzone?zipcode=39485