using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Garden.Models
{
  public class ZipZone
  {
    public int ZipZoneId { get; set;}
    public int ZipCode { get; set; }
    public int Zone { get; set; }

    public static ZipZone Get(int zipcode)
    {
      var apiCallTask = ApiHelper.Get(zipcode);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ZipZone zipzone = JsonConvert.DeserializeObject<ZipZone>(jsonResponse["results"].ToString());

      return zipzone;
    }
  }
}