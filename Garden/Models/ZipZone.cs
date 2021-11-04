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
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<ZipZone> zipzoneList = JsonConvert.DeserializeObject<List<ZipZone>>(jsonResponse.ToString());

      return zipzoneList[0];
    }
  }
}



