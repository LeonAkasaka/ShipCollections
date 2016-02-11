using Newtonsoft.Json;
using System.IO;

namespace ShipCollections
{
    public class Ship
    {
        /// <summary>
        /// この艦船を識別する一意な値です。
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// この艦船を改造した結果となる艦船の ID です。
        /// 改造できない場合は 0 を返します。
        /// </summary>
        public int AfterShip { get; set; }

        /// <summary>
        /// この艦船の名前です。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// この艦船の種類を指す ShipType の ID です。
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// この艦船の名前の読みです。
        /// </summary>
        public string Yomi { get; set; }

        public static Ship[] LoadAll()
        {
            var json = File.ReadAllText("Assets/Ships.json");
            var ships = JsonConvert.DeserializeObject<Ship[]>(json);
            return ships;
        }
    }
}
