using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Garden.Models
{
  public class Seed
  {
    public Seed()
    {

    }

    public int SeedId { get; set; }
    [Required]
    public string SeedName { get; set; }
    public int SqFootPlant { get; set; }
    public int DaysTillHarvest { get; set; }
    public int WaterInterval { get; set; }
    public int DaysTillSprout { get; set; }
    public string Companions { get; set; }
    public string Enemies { get; set; }
    public string Notes { get; set;}
    public string Zone { get; set;}


    public Seed(int seedid, string seedname, int daystillharvest, int waterinterval,
              int daystillsprout, string companions, string enemies, string notes,
              string zone)
    {
      SeedId = seedid;
      SeedName = seedname;
      DaysTillHarvest = daystillharvest;
      WaterInterval = waterinterval; 
      DaysTillSprout = daystillsprout;
      Companions = companions;
      Enemies = enemies;
      Notes = Notes;
      Zone = zone;
    }
    public static List<Seed> Get()
    {
      var apiCallTask = ApiHelper.GetSeeds();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Seed> seedList = JsonConvert.DeserializeObject<List<Seed>>(jsonResponse.ToString());
      return seedList;
    }

    public static Seed GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetSeed(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Seed seed= JsonConvert.DeserializeObject<Seed>(jsonResponse.ToString());
      return seed;
    }

    public static void Post(Seed seed)
    {
      string jsonSeed = JsonConvert.SerializeObject(seed);
      var apiCallTask = ApiHelper.Post(jsonSeed);
    }

    public static void Put(Seed seed)
    {
      string jsonSeed = JsonConvert.SerializeObject(seed);
      var apiCallTask = ApiHelper.Put(seed.SeedId, jsonSeed);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }

    
  }
}

// {
//   "seedId": 4,
//   "seedName": "corn",
//   "sqFootPlant": 4,
//   "daysTillHarvest": 100,
//   "waterInterval": 5,
//   "daysTillSprout": 14,
//   "companions": "borage, cucumber, dill, melon, marigold, pole beans, nasturtium",
//   "enemies": "cabbage, broccoli, fennel, kale, pepper, eggplant, brussel sprouts, cauliflower, collards, kholrabi,",
//   "notes": "full sun, start indoors and transplant or direct seed outdoors",
//   "zone": "4, 5, 6, 7, 8, 9"
// }