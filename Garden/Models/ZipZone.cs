using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System;


namespace Garden.Models
{
  public class ZipZone
  {
    public ZipZone()
    {

    }

    public ZipZone(int zipzoneid, int zipcode, int zone)
    {
      ZipZoneId = zipzoneid;
      ZipCode = zipcode;
      Zone = zone;
    }

    public int ZipZoneId { get; set;}
    public int ZipCode { get; set; }
    public int Zone { get; set; }

    public static ZipZone Get(int zipcode)
    {
      var apiCallTask = ApiHelper.Get(zipcode);
      var result = apiCallTask.Result;
      Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
      if(result != null)
      {
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ZipZone zipzone = JsonConvert.DeserializeObject<ZipZone>(jsonResponse.ToString());

      Console.WriteLine("Result is Null");
      return zipzone;
      }
      Console.WriteLine("8888888888888888888888888888888888888888888");
      return new ZipZone(1, 00000, 0);
    }
  }
}


