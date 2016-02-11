using Newtonsoft.Json;
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
    }
}
