using System;

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
        public String Name { get; set; }

        public static ShipType[] LoadAll()
        {
            return new[] {
	            new ShipType {
		            Id = 1,
		            Name = "海防艦",
	            },
	            new ShipType {
		            Id = 2,
		            Name = "駆逐艦",
	            },
	            new ShipType {
		            Id = 3,
		            Name = "軽巡洋艦",
	            },
	            new ShipType {
		            Id = 4,
		            Name = "重雷装巡洋艦",
	            },
	            new ShipType {
		            Id = 5,
		            Name = "重巡洋艦",
	            },
	            new ShipType {
		            Id = 6,
		            Name = "航空巡洋艦",
	            },
	            new ShipType {
		            Id = 7,
		            Name = "軽空母",
	            },
	            new ShipType {
		            Id = 8,
		            Name = "戦艦",
	            },
	            new ShipType {
		            Id = 9,
		            Name = "戦艦",
	            },
	            new ShipType {
		            Id = 10,
		            Name = "航空戦艦",
	            },
	            new ShipType {
		            Id = 11,
		            Name = "正規空母",
	            },
	            new ShipType {
		            Id = 12,
		            Name = "超弩級戦艦",
	            },
	            new ShipType {
		            Id = 13,
		            Name = "潜水艦",
	            },
	            new ShipType {
		            Id = 14,
		            Name = "潜水空母",
	            },
	            new ShipType {
		            Id = 15,
		            Name = "補給艦",
	            },
	            new ShipType {
		            Id = 16,
		            Name = "水上機母艦",
	            }
            };
        }
    }
}
