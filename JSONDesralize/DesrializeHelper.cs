using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections.Generic;
using JSONDesralize.Model;

namespace JSONDesralize
{
    class DesrializeHelper
    {
        private static string CityDetailsJSONPath = "../../CititesInfo.json";
        
        public static void Desrialize()
        {
            using (StreamReader reader=new StreamReader(CityDetailsJSONPath))
            {
                var data = reader.ReadToEnd();
                var result = JsonConvert.DeserializeObject<List<City>>(data);
                var resultCity = result.FindAll(m => 
                   
                   m.CityId == 102
                );

                if (resultCity != null)
                {
                    foreach (var item in resultCity)
                    {
                        System.Console.WriteLine($"The Capital is {item.Capital} and langualge spoken is {item.Language}");

                    }


                }



            }
        }
    }
}
