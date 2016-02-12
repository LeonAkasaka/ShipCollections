using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace ShipCollections
{
    public class ShipType
    {
        /// <summary>
        /// 艦種を識別する一意な値です。
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 艦船の種類を表す名前です。
        /// </summary>
        public string Name { get; set; }

        public static ShipType[] LoadAll()
        {
            var json = File.ReadAllText("Assets/ShipTypes.json");
            var types = JsonConvert.DeserializeObject<ShipType[]>(json);
            return types;
        }

        public static ShipType[] LoadFromOriginalData(string json)
        {
            var r = (JObject)JsonConvert.DeserializeObject(json);
            var data = r["api_data"];
            var masters = data["api_mst_stype"];

            var types = new List<ShipType>();
            foreach (var master in masters)
            {
                types.Add(new ShipType()
                {
                    Id = int.Parse(master["api_id"].ToString()),
                    Name = master["api_name"].ToString(),

                });
            };
            return types.ToArray();
        }
    }
}
