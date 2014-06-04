using System;

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
        /// </summary>
        public int AfterShip { get; set; }

        /// <summary>
        /// この艦船の名前です。
        /// </summary>
        public String Name { get; set; }

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
            var ships = new[]
            {
                new Ship
                {
                    Id = 1,
                    AfterShip = 254,
                    Name = "睦月",
                    Type = 2,
                    Yomi = "むつき",
                },
                new Ship
                {
                    Id = 2,
                    AfterShip = 255,
                    Name = "如月",
                    Type = 2,
                    Yomi = "きさらぎ",
                },
                new Ship
                {
                    Id = 3,
                    AfterShip = 224,
                    Name = "S那珂",
                    Type = 3,
                    Yomi = "なか",
                },
                new Ship
                {
                    Id = 6,
                    AfterShip = 258,
                    Name = "長月",
                    Type = 2,
                    Yomi = "ながつき",
                },
                new Ship
                {
                    Id = 7,
                    AfterShip = 260,
                    Name = "三日月",
                    Type = 2,
                    Yomi = "みかづき",
                },
                new Ship
                {
                    Id = 9,
                    AfterShip = 201,
                    Name = "吹雪",
                    Type = 2,
                    Yomi = "ふぶき",
                },
                new Ship
                {
                    Id = 10,
                    AfterShip = 202,
                    Name = "白雪",
                    Type = 2,
                    Yomi = "しらゆき",
                },
                new Ship
                {
                    Id = 11,
                    AfterShip = 204,
                    Name = "深雪",
                    Type = 2,
                    Yomi = "みゆき",
                },
                new Ship
                {
                    Id = 12,
                    AfterShip = 206,
                    Name = "磯波",
                    Type = 2,
                    Yomi = "いそなみ",
                },
                new Ship
                {
                    Id = 13,
                    AfterShip = 207,
                    Name = "綾波",
                    Type = 2,
                    Yomi = "あやなみ",
                },
                new Ship
                {
                    Id = 14,
                    AfterShip = 208,
                    Name = "敷波",
                    Type = 2,
                    Yomi = "しきなみ",
                },
                new Ship
                {
                    Id = 15,
                    AfterShip = 231,
                    Name = "曙",
                    Type = 2,
                    Yomi = "あけぼの",
                },
                new Ship
                {
                    Id = 16,
                    AfterShip = 233,
                    Name = "潮",
                    Type = 2,
                    Yomi = "うしお",
                },
                new Ship
                {
                    Id = 17,
                    AfterShip = 225,
                    Name = "陽炎",
                    Type = 2,
                    Yomi = "かげろう",
                },
                new Ship
                {
                    Id = 18,
                    AfterShip = 226,
                    Name = "不知火",
                    Type = 2,
                    Yomi = "しらぬい",
                },
                new Ship
                {
                    Id = 19,
                    AfterShip = 227,
                    Name = "黒潮",
                    Type = 2,
                    Yomi = "くろしお",
                },
                new Ship
                {
                    Id = 20,
                    AfterShip = 228,
                    Name = "雪風",
                    Type = 2,
                    Yomi = "ゆきかぜ",
                },
                new Ship
                {
                    Id = 21,
                    AfterShip = 218,
                    Name = "長良",
                    Type = 3,
                    Yomi = "ながら",
                },
                new Ship
                {
                    Id = 22,
                    AfterShip = 219,
                    Name = "五十鈴",
                    Type = 3,
                    Yomi = "いすず",
                },
                new Ship
                {
                    Id = 23,
                    AfterShip = 220,
                    Name = "由良",
                    Type = 3,
                    Yomi = "ゆら",
                },
                new Ship
                {
                    Id = 24,
                    AfterShip = 57,
                    Name = "大井",
                    Type = 3,
                    Yomi = "おおい",
                },
                new Ship
                {
                    Id = 25,
                    AfterShip = 58,
                    Name = "北上",
                    Type = 3,
                    Yomi = "きたかみ",
                },
                new Ship
                {
                    Id = 26,
                    AfterShip = 286,
                    Name = "扶桑",
                    Type = 9,
                    Yomi = "ふそう",
                },
                new Ship
                {
                    Id = 27,
                    AfterShip = 287,
                    Name = "山城",
                    Type = 9,
                    Yomi = "やましろ",
                },
                new Ship
                {
                    Id = 28,
                    AfterShip = 256,
                    Name = "皐月",
                    Type = 2,
                    Yomi = "さつき",
                },
                new Ship
                {
                    Id = 29,
                    AfterShip = 257,
                    Name = "文月",
                    Type = 2,
                    Yomi = "ふみづき",
                },
                new Ship
                {
                    Id = 30,
                    AfterShip = 259,
                    Name = "菊月",
                    Type = 2,
                    Yomi = "きくづき",
                },
                new Ship
                {
                    Id = 31,
                    AfterShip = 261,
                    Name = "望月",
                    Type = 2,
                    Yomi = "もちづき",
                },
                new Ship
                {
                    Id = 32,
                    AfterShip = 203,
                    Name = "初雪",
                    Type = 2,
                    Yomi = "はつゆき",
                },
                new Ship
                {
                    Id = 33,
                    AfterShip = 205,
                    Name = "叢雲",
                    Type = 2,
                    Yomi = "むらくも",
                },
                new Ship
                {
                    Id = 34,
                    AfterShip = 234,
                    Name = "暁",
                    Type = 2,
                    Yomi = "あかつき",
                },
                new Ship
                {
                    Id = 35,
                    AfterShip = 235,
                    Name = "響",
                    Type = 2,
                    Yomi = "ひびき",
                },
                new Ship
                {
                    Id = 36,
                    AfterShip = 236,
                    Name = "雷",
                    Type = 2,
                    Yomi = "いかづち",
                },
                new Ship
                {
                    Id = 37,
                    AfterShip = 237,
                    Name = "電",
                    Type = 2,
                    Yomi = "いなづま",
                },
                new Ship
                {
                    Id = 38,
                    AfterShip = 238,
                    Name = "初春",
                    Type = 2,
                    Yomi = "はつはる",
                },
                new Ship
                {
                    Id = 39,
                    AfterShip = 239,
                    Name = "子日",
                    Type = 2,
                    Yomi = "ねのひ",
                },
                new Ship
                {
                    Id = 40,
                    AfterShip = 240,
                    Name = "若葉",
                    Type = 2,
                    Yomi = "わかば",
                },
                new Ship
                {
                    Id = 41,
                    AfterShip = 241,
                    Name = "初霜",
                    Type = 2,
                    Yomi = "はつしも",
                },
                new Ship
                {
                    Id = 42,
                    AfterShip = 242,
                    Name = "白露",
                    Type = 2,
                    Yomi = "しらつゆ",
                },
                new Ship
                {
                    Id = 43,
                    AfterShip = 243,
                    Name = "時雨",
                    Type = 2,
                    Yomi = "しぐれ",
                },
                new Ship
                {
                    Id = 44,
                    AfterShip = 244,
                    Name = "村雨",
                    Type = 2,
                    Yomi = "むらさめ",
                },
                new Ship
                {
                    Id = 45,
                    AfterShip = 245,
                    Name = "夕立",
                    Type = 2,
                    Yomi = "ゆうだち",
                },
                new Ship
                {
                    Id = 46,
                    AfterShip = 246,
                    Name = "五月雨",
                    Type = 2,
                    Yomi = "さみだれ",
                },
                new Ship
                {
                    Id = 47,
                    AfterShip = 247,
                    Name = "涼風",
                    Type = 2,
                    Yomi = "すずかぜ",
                },
                new Ship
                {
                    Id = 48,
                    AfterShip = 252,
                    Name = "霰",
                    Type = 2,
                    Yomi = "あられ",
                },
                new Ship
                {
                    Id = 49,
                    AfterShip = 253,
                    Name = "霞",
                    Type = 2,
                    Yomi = "かすみ",
                },
                new Ship
                {
                    Id = 50,
                    AfterShip = 229,
                    Name = "島風",
                    Type = 2,
                    Yomi = "しまかぜ",
                },
                new Ship
                {
                    Id = 51,
                    AfterShip = 213,
                    Name = "天龍",
                    Type = 3,
                    Yomi = "てんりゅう",
                },
                new Ship
                {
                    Id = 52,
                    AfterShip = 214,
                    Name = "龍田",
                    Type = 3,
                    Yomi = "たつた",
                },
                new Ship
                {
                    Id = 53,
                    AfterShip = 221,
                    Name = "名取",
                    Type = 3,
                    Yomi = "なとり",
                },
                new Ship
                {
                    Id = 54,
                    AfterShip = 222,
                    Name = "川内",
                    Type = 3,
                    Yomi = "せんだい",
                },
                new Ship
                {
                    Id = 55,
                    AfterShip = 223,
                    Name = "神通",
                    Type = 3,
                    Yomi = "じんつう",
                },
                new Ship
                {
                    Id = 56,
                    AfterShip = 224,
                    Name = "那珂",
                    Type = 3,
                    Yomi = "なか",
                },
                new Ship
                {
                    Id = 57,
                    AfterShip = 118,
                    Name = "大井改",
                    Type = 4,
                    Yomi = "おおい",
                },
                new Ship
                {
                    Id = 58,
                    AfterShip = 119,
                    Name = "北上改",
                    Type = 4,
                    Yomi = "きたかみ",
                },
                new Ship
                {
                    Id = 59,
                    AfterShip = 262,
                    Name = "古鷹",
                    Type = 5,
                    Yomi = "ふるたか",
                },
                new Ship
                {
                    Id = 60,
                    AfterShip = 263,
                    Name = "加古",
                    Type = 5,
                    Yomi = "かこ",
                },
                new Ship
                {
                    Id = 61,
                    AfterShip = 264,
                    Name = "青葉",
                    Type = 5,
                    Yomi = "あおば",
                },
                new Ship
                {
                    Id = 62,
                    AfterShip = 265,
                    Name = "妙高",
                    Type = 5,
                    Yomi = "みょうこう",
                },
                new Ship
                {
                    Id = 63,
                    AfterShip = 266,
                    Name = "那智",
                    Type = 5,
                    Yomi = "なち",
                },
                new Ship
                {
                    Id = 64,
                    AfterShip = 267,
                    Name = "足柄",
                    Type = 5,
                    Yomi = "あしがら",
                },
                new Ship
                {
                    Id = 65,
                    AfterShip = 268,
                    Name = "羽黒",
                    Type = 5,
                    Yomi = "はぐろ",
                },
                new Ship
                {
                    Id = 66,
                    AfterShip = 269,
                    Name = "高雄",
                    Type = 5,
                    Yomi = "たかお",
                },
                new Ship
                {
                    Id = 67,
                    AfterShip = 270,
                    Name = "愛宕",
                    Type = 5,
                    Yomi = "あたご",
                },
                new Ship
                {
                    Id = 68,
                    AfterShip = 271,
                    Name = "摩耶",
                    Type = 5,
                    Yomi = "まや",
                },
                new Ship
                {
                    Id = 69,
                    AfterShip = 272,
                    Name = "鳥海",
                    Type = 5,
                    Yomi = "ちょうかい",
                },
                new Ship
                {
                    Id = 70,
                    AfterShip = 73,
                    Name = "最上",
                    Type = 5,
                    Yomi = "もがみ",
                },
                new Ship
                {
                    Id = 71,
                    AfterShip = 273,
                    Name = "利根",
                    Type = 5,
                    Yomi = "とね",
                },
                new Ship
                {
                    Id = 72,
                    AfterShip = 274,
                    Name = "筑摩",
                    Type = 5,
                    Yomi = "ちくま",
                },
                new Ship
                {
                    Id = 73,
                    AfterShip = 0,
                    Name = "最上改",
                    Type = 6,
                    Yomi = "もがみ",
                },
                new Ship
                {
                    Id = 74,
                    AfterShip = 282,
                    Name = "祥鳳",
                    Type = 7,
                    Yomi = "しょうほう",
                },
                new Ship
                {
                    Id = 75,
                    AfterShip = 283,
                    Name = "飛鷹",
                    Type = 7,
                    Yomi = "ひよう",
                },
                new Ship
                {
                    Id = 76,
                    AfterShip = 281,
                    Name = "龍驤",
                    Type = 7,
                    Yomi = "りゅうじょう",
                },
                new Ship
                {
                    Id = 77,
                    AfterShip = 82,
                    Name = "伊勢",
                    Type = 9,
                    Yomi = "いせ",
                },
                new Ship
                {
                    Id = 78,
                    AfterShip = 209,
                    Name = "金剛",
                    Type = 8,
                    Yomi = "こんごう",
                },
                new Ship
                {
                    Id = 79,
                    AfterShip = 211,
                    Name = "榛名",
                    Type = 8,
                    Yomi = "はるな",
                },
                new Ship
                {
                    Id = 80,
                    AfterShip = 275,
                    Name = "長門",
                    Type = 9,
                    Yomi = "ながと",
                },
                new Ship
                {
                    Id = 81,
                    AfterShip = 276,
                    Name = "陸奥",
                    Type = 9,
                    Yomi = "むつ",
                },
                new Ship
                {
                    Id = 82,
                    AfterShip = 0,
                    Name = "伊勢改",
                    Type = 10,
                    Yomi = "いせ",
                },
                new Ship
                {
                    Id = 83,
                    AfterShip = 277,
                    Name = "赤城",
                    Type = 11,
                    Yomi = "あかぎ",
                },
                new Ship
                {
                    Id = 84,
                    AfterShip = 278,
                    Name = "加賀",
                    Type = 11,
                    Yomi = "かが",
                },
                new Ship
                {
                    Id = 85,
                    AfterShip = 212,
                    Name = "霧島",
                    Type = 8,
                    Yomi = "きりしま",
                },
                new Ship
                {
                    Id = 86,
                    AfterShip = 210,
                    Name = "比叡",
                    Type = 8,
                    Yomi = "ひえい",
                },
                new Ship
                {
                    Id = 87,
                    AfterShip = 88,
                    Name = "日向",
                    Type = 9,
                    Yomi = "ひゅうが",
                },
                new Ship
                {
                    Id = 88,
                    AfterShip = 0,
                    Name = "日向改",
                    Type = 10,
                    Yomi = "ひゅうが",
                },
                new Ship
                {
                    Id = 89,
                    AfterShip = 285,
                    Name = "鳳翔",
                    Type = 7,
                    Yomi = "ほうしょう",
                },
                new Ship
                {
                    Id = 90,
                    AfterShip = 279,
                    Name = "蒼龍",
                    Type = 11,
                    Yomi = "そうりゅう",
                },
                new Ship
                {
                    Id = 91,
                    AfterShip = 280,
                    Name = "飛龍",
                    Type = 11,
                    Yomi = "ひりゅう",
                },
                new Ship
                {
                    Id = 92,
                    AfterShip = 284,
                    Name = "隼鷹",
                    Type = 7,
                    Yomi = "じゅんよう",
                },
                new Ship
                {
                    Id = 93,
                    AfterShip = 230,
                    Name = "朧",
                    Type = 2,
                    Yomi = "おぼろ",
                },
                new Ship
                {
                    Id = 94,
                    AfterShip = 232,
                    Name = "漣",
                    Type = 2,
                    Yomi = "さざなみ",
                },
                new Ship
                {
                    Id = 95,
                    AfterShip = 248,
                    Name = "朝潮",
                    Type = 2,
                    Yomi = "あさしお",
                },
                new Ship
                {
                    Id = 96,
                    AfterShip = 249,
                    Name = "大潮",
                    Type = 2,
                    Yomi = "おおしお",
                },
                new Ship
                {
                    Id = 97,
                    AfterShip = 250,
                    Name = "満潮",
                    Type = 2,
                    Yomi = "みちしお",
                },
                new Ship
                {
                    Id = 98,
                    AfterShip = 251,
                    Name = "荒潮",
                    Type = 2,
                    Yomi = "あらしお",
                },
                new Ship
                {
                    Id = 99,
                    AfterShip = 215,
                    Name = "球磨",
                    Type = 3,
                    Yomi = "くま",
                },
                new Ship
                {
                    Id = 100,
                    AfterShip = 216,
                    Name = "多摩",
                    Type = 3,
                    Yomi = "たま",
                },
                new Ship
                {
                    Id = 101,
                    AfterShip = 217,
                    Name = "木曾",
                    Type = 3,
                    Yomi = "きそ",
                },
                new Ship
                {
                    Id = 102,
                    AfterShip = 104,
                    Name = "千歳",
                    Type = 16,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 103,
                    AfterShip = 105,
                    Name = "千代田",
                    Type = 16,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 104,
                    AfterShip = 106,
                    Name = "千歳改",
                    Type = 16,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 105,
                    AfterShip = 107,
                    Name = "千代田改",
                    Type = 16,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 106,
                    AfterShip = 108,
                    Name = "千歳甲",
                    Type = 16,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 107,
                    AfterShip = 109,
                    Name = "千代田甲",
                    Type = 16,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 108,
                    AfterShip = 291,
                    Name = "千歳航",
                    Type = 7,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 109,
                    AfterShip = 292,
                    Name = "千代田航",
                    Type = 7,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 110,
                    AfterShip = 288,
                    Name = "翔鶴",
                    Type = 11,
                    Yomi = "しょうかく",
                },
                new Ship
                {
                    Id = 111,
                    AfterShip = 112,
                    Name = "瑞鶴",
                    Type = 11,
                    Yomi = "ずいかく",
                },
                new Ship
                {
                    Id = 112,
                    AfterShip = 0,
                    Name = "瑞鶴改",
                    Type = 11,
                    Yomi = "ずいかく",
                },
                new Ship
                {
                    Id = 113,
                    AfterShip = 289,
                    Name = "鬼怒",
                    Type = 3,
                    Yomi = "きぬ",
                },
                new Ship
                {
                    Id = 114,
                    AfterShip = 290,
                    Name = "阿武隈",
                    Type = 3,
                    Yomi = "あぶくま",
                },
                new Ship
                {
                    Id = 115,
                    AfterShip = 293,
                    Name = "夕張",
                    Type = 3,
                    Yomi = "ゆうばり",
                },
                new Ship
                {
                    Id = 116,
                    AfterShip = 117,
                    Name = "瑞鳳",
                    Type = 7,
                    Yomi = "ずいほう",
                },
                new Ship
                {
                    Id = 117,
                    AfterShip = 0,
                    Name = "瑞鳳改",
                    Type = 7,
                    Yomi = "ずいほう",
                },
                new Ship
                {
                    Id = 118,
                    AfterShip = 0,
                    Name = "大井改二",
                    Type = 4,
                    Yomi = "おおい",
                },
                new Ship
                {
                    Id = 119,
                    AfterShip = 0,
                    Name = "北上改二",
                    Type = 4,
                    Yomi = "きたかみ",
                },
                new Ship
                {
                    Id = 120,
                    AfterShip = 121,
                    Name = "三隈",
                    Type = 5,
                    Yomi = "みくま",
                },
                new Ship
                {
                    Id = 121,
                    AfterShip = 0,
                    Name = "三隈改",
                    Type = 6,
                    Yomi = "みくま",
                },
                new Ship
                {
                    Id = 122,
                    AfterShip = 294,
                    Name = "舞風",
                    Type = 2,
                    Yomi = "まいかぜ",
                },
                new Ship
                {
                    Id = 123,
                    AfterShip = 295,
                    Name = "衣笠",
                    Type = 5,
                    Yomi = "きぬがさ",
                },
                new Ship
                {
                    Id = 124,
                    AfterShip = 129,
                    Name = "鈴谷",
                    Type = 5,
                    Yomi = "すずや",
                },
                new Ship
                {
                    Id = 125,
                    AfterShip = 130,
                    Name = "熊野",
                    Type = 5,
                    Yomi = "くまの",
                },
                new Ship
                {
                    Id = 126,
                    AfterShip = 398,
                    Name = "伊168",
                    Type = 13,
                    Yomi = "い168",
                },
                new Ship
                {
                    Id = 127,
                    AfterShip = 399,
                    Name = "伊58",
                    Type = 13,
                    Yomi = "い58",
                },
                new Ship
                {
                    Id = 128,
                    AfterShip = 400,
                    Name = "伊8",
                    Type = 13,
                    Yomi = "い8",
                },
                new Ship
                {
                    Id = 129,
                    AfterShip = 0,
                    Name = "鈴谷改",
                    Type = 6,
                    Yomi = "すずや",
                },
                new Ship
                {
                    Id = 130,
                    AfterShip = 0,
                    Name = "熊野改",
                    Type = 6,
                    Yomi = "くまの",
                },
                new Ship
                {
                    Id = 131,
                    AfterShip = 136,
                    Name = "大和",
                    Type = 9,
                    Yomi = "やまと",
                },
                new Ship
                {
                    Id = 132,
                    AfterShip = 301,
                    Name = "秋雲",
                    Type = 2,
                    Yomi = "あきぐも",
                },
                new Ship
                {
                    Id = 133,
                    AfterShip = 302,
                    Name = "夕雲",
                    Type = 2,
                    Yomi = "ゆうぐも",
                },
                new Ship
                {
                    Id = 134,
                    AfterShip = 303,
                    Name = "巻雲",
                    Type = 2,
                    Yomi = "まきぐも",
                },
                new Ship
                {
                    Id = 135,
                    AfterShip = 304,
                    Name = "長波",
                    Type = 2,
                    Yomi = "ながなみ",
                },
                new Ship
                {
                    Id = 136,
                    AfterShip = 0,
                    Name = "大和改",
                    Type = 9,
                    Yomi = "やまと",
                },
                new Ship
                {
                    Id = 137,
                    AfterShip = 305,
                    Name = "阿賀野",
                    Type = 3,
                    Yomi = "あがの",
                },
                new Ship
                {
                    Id = 138,
                    AfterShip = 306,
                    Name = "能代",
                    Type = 3,
                    Yomi = "のしろ",
                },
                new Ship
                {
                    Id = 139,
                    AfterShip = 307,
                    Name = "矢矧",
                    Type = 3,
                    Yomi = "やはぎ",
                },
                new Ship
                {
                    Id = 140,
                    AfterShip = 314,
                    Name = "酒匂",
                    Type = 3,
                    Yomi = "さかわ",
                },
                new Ship
                {
                    Id = 141,
                    AfterShip = 0,
                    Name = "五十鈴改二",
                    Type = 3,
                    Yomi = "いすず",
                },
                new Ship
                {
                    Id = 142,
                    AfterShip = 0,
                    Name = "衣笠改二",
                    Type = 5,
                    Yomi = "きぬがさ",
                },
                new Ship
                {
                    Id = 143,
                    AfterShip = 148,
                    Name = "武蔵",
                    Type = 9,
                    Yomi = "むさし",
                },
                new Ship
                {
                    Id = 144,
                    AfterShip = 0,
                    Name = "夕立改二",
                    Type = 2,
                    Yomi = "ゆうだち",
                },
                new Ship
                {
                    Id = 145,
                    AfterShip = 0,
                    Name = "時雨改二",
                    Type = 2,
                    Yomi = "しぐれ",
                },
                new Ship
                {
                    Id = 146,
                    AfterShip = 0,
                    Name = "木曾改二",
                    Type = 4,
                    Yomi = "きそ",
                },
                new Ship
                {
                    Id = 147,
                    AfterShip = 0,
                    Name = "Верный",
                    Type = 2,
                    Yomi = "ひびき",
                },
                new Ship
                {
                    Id = 148,
                    AfterShip = 0,
                    Name = "武蔵改",
                    Type = 9,
                    Yomi = "むさし",
                },
                new Ship
                {
                    Id = 149,
                    AfterShip = 0,
                    Name = "金剛改二",
                    Type = 8,
                    Yomi = "こんごう",
                },
                new Ship
                {
                    Id = 150,
                    AfterShip = 0,
                    Name = "比叡改二",
                    Type = 8,
                    Yomi = "ひえい",
                },
                new Ship
                {
                    Id = 152,
                    AfterShip = 0,
                    Name = "霧島改二",
                    Type = 8,
                    Yomi = "きりしま",
                },
                new Ship
                {
                    Id = 153,
                    AfterShip = 156,
                    Name = "大鳳",
                    Type = 18,
                    Yomi = "たいほう",
                },
                new Ship
                {
                    Id = 155,
                    AfterShip = 403,
                    Name = "伊401",
                    Type = 14,
                    Yomi = "い401",
                },
                new Ship
                {
                    Id = 156,
                    AfterShip = 0,
                    Name = "大鳳改",
                    Type = 18,
                    Yomi = "たいほう",
                },
                new Ship
                {
                    Id = 157,
                    AfterShip = 0,
                    Name = "龍驤改二",
                    Type = 7,
                    Yomi = "りゅうじょう",
                },
                new Ship
                {
                    Id = 159,
                    AfterShip = 0,
                    Name = "神通改二",
                    Type = 3,
                    Yomi = "じんつう",
                },
                new Ship
                {
                    Id = 160,
                    AfterShip = 0,
                    Name = "那珂改二",
                    Type = 3,
                    Yomi = "なか",
                },
                new Ship
                {
                    Id = 161,
                    AfterShip = 166,
                    Name = "あきつ丸",
                    Type = 17,
                    Yomi = "あきつまる",
                },
                new Ship
                {
                    Id = 163,
                    AfterShip = 402,
                    Name = "まるゆ",
                    Type = 13,
                    Yomi = "まるゆ",
                },
                new Ship
                {
                    Id = 164,
                    AfterShip = 308,
                    Name = "弥生",
                    Type = 2,
                    Yomi = "やよい",
                },
                new Ship
                {
                    Id = 165,
                    AfterShip = 309,
                    Name = "卯月",
                    Type = 2,
                    Yomi = "うづき",
                },
                new Ship
                {
                    Id = 166,
                    AfterShip = 0,
                    Name = "あきつ丸改",
                    Type = 17,
                    Yomi = "あきつまる",
                },
                new Ship
                {
                    Id = 168,
                    AfterShip = 317,
                    Name = "浦風",
                    Type = 2,
                    Yomi = "うらかぜ",
                },
                new Ship
                {
                    Id = 169,
                    AfterShip = 313,
                    Name = "谷風",
                    Type = 2,
                    Yomi = "たにかぜ",
                },
                new Ship
                {
                    Id = 170,
                    AfterShip = 312,
                    Name = "浜風",
                    Type = 2,
                    Yomi = "はまかぜ",
                },
                new Ship
                {
                    Id = 171,
                    AfterShip = 172,
                    Name = "Bismarck",
                    Type = 8,
                    Yomi = "ビスマルク",
                },
                new Ship
                {
                    Id = 172,
                    AfterShip = 173,
                    Name = "Bismarck改",
                    Type = 8,
                    Yomi = "ビスマルク",
                },
                new Ship
                {
                    Id = 173,
                    AfterShip = 0,
                    Name = "Bismarck zwei",
                    Type = 8,
                    Yomi = "ビスマルク",
                },
                new Ship
                {
                    Id = 174,
                    AfterShip = 310,
                    Name = "Z1",
                    Type = 2,
                    Yomi = "レーベレヒト・マース",
                },
                new Ship
                {
                    Id = 175,
                    AfterShip = 311,
                    Name = "Z3",
                    Type = 2,
                    Yomi = "マックス・シュルツ",
                },
                new Ship
                {
                    Id = 179,
                    AfterShip = 0,
                    Name = "Z1 zwei",
                    Type = 2,
                    Yomi = "レーベレヒト・マース",
                },
                new Ship
                {
                    Id = 180,
                    AfterShip = 0,
                    Name = "Z3 zwei",
                    Type = 2,
                    Yomi = "マックス・シュルツ",
                },
                new Ship
                {
                    Id = 181,
                    AfterShip = 316,
                    Name = "天津風",
                    Type = 2,
                    Yomi = "あまつかぜ",
                },
                new Ship
                {
                    Id = 182,
                    AfterShip = 187,
                    Name = "明石",
                    Type = 19,
                    Yomi = "あかし",
                },
                new Ship
                {
                    Id = 183,
                    AfterShip = 0,
                    Name = "ハルナ",
                    Type = 8,
                    Yomi = "アルはるな",
                },
                new Ship
                {
                    Id = 187,
                    AfterShip = 0,
                    Name = "明石改",
                    Type = 19,
                    Yomi = "あかし",
                },
                new Ship
                {
                    Id = 188,
                    AfterShip = 0,
                    Name = "利根改二",
                    Type = 6,
                    Yomi = "とね",
                },
                new Ship
                {
                    Id = 189,
                    AfterShip = 0,
                    Name = "筑摩改二",
                    Type = 6,
                    Yomi = "ちくま",
                },
                new Ship
                {
                    Id = 190,
                    AfterShip = 300,
                    Name = "初風",
                    Type = 2,
                    Yomi = "はつかぜ",
                },
                new Ship
                {
                    Id = 191,
                    AfterShip = 401,
                    Name = "伊19",
                    Type = 13,
                    Yomi = "い19",
                },
                new Ship
                {
                    Id = 194,
                    AfterShip = 0,
                    Name = "羽黒改二",
                    Type = 5,
                    Yomi = "はぐろ",
                },
                new Ship
                {
                    Id = 201,
                    AfterShip = 0,
                    Name = "吹雪改",
                    Type = 2,
                    Yomi = "ふぶき",
                },
                new Ship
                {
                    Id = 202,
                    AfterShip = 0,
                    Name = "白雪改",
                    Type = 2,
                    Yomi = "しらゆき",
                },
                new Ship
                {
                    Id = 203,
                    AfterShip = 0,
                    Name = "初雪改",
                    Type = 2,
                    Yomi = "はつゆき",
                },
                new Ship
                {
                    Id = 204,
                    AfterShip = 0,
                    Name = "深雪改",
                    Type = 2,
                    Yomi = "みゆき",
                },
                new Ship
                {
                    Id = 205,
                    AfterShip = 0,
                    Name = "叢雲改",
                    Type = 2,
                    Yomi = "むらくも",
                },
                new Ship
                {
                    Id = 206,
                    AfterShip = 0,
                    Name = "磯波改",
                    Type = 2,
                    Yomi = "いそなみ",
                },
                new Ship
                {
                    Id = 207,
                    AfterShip = 0,
                    Name = "綾波改",
                    Type = 2,
                    Yomi = "あやなみ",
                },
                new Ship
                {
                    Id = 208,
                    AfterShip = 0,
                    Name = "敷波改",
                    Type = 2,
                    Yomi = "しきなみ",
                },
                new Ship
                {
                    Id = 209,
                    AfterShip = 149,
                    Name = "金剛改",
                    Type = 8,
                    Yomi = "こんごう",
                },
                new Ship
                {
                    Id = 210,
                    AfterShip = 150,
                    Name = "比叡改",
                    Type = 8,
                    Yomi = "ひえい",
                },
                new Ship
                {
                    Id = 211,
                    AfterShip = 0,
                    Name = "榛名改",
                    Type = 8,
                    Yomi = "はるな",
                },
                new Ship
                {
                    Id = 212,
                    AfterShip = 152,
                    Name = "霧島改",
                    Type = 8,
                    Yomi = "きりしま",
                },
                new Ship
                {
                    Id = 213,
                    AfterShip = 0,
                    Name = "天龍改",
                    Type = 3,
                    Yomi = "てんりゅう",
                },
                new Ship
                {
                    Id = 214,
                    AfterShip = 0,
                    Name = "龍田改",
                    Type = 3,
                    Yomi = "たつた",
                },
                new Ship
                {
                    Id = 215,
                    AfterShip = 0,
                    Name = "球磨改",
                    Type = 3,
                    Yomi = "くま",
                },
                new Ship
                {
                    Id = 216,
                    AfterShip = 0,
                    Name = "多摩改",
                    Type = 3,
                    Yomi = "たま",
                },
                new Ship
                {
                    Id = 217,
                    AfterShip = 146,
                    Name = "木曾改",
                    Type = 3,
                    Yomi = "きそ",
                },
                new Ship
                {
                    Id = 218,
                    AfterShip = 0,
                    Name = "長良改",
                    Type = 3,
                    Yomi = "ながら",
                },
                new Ship
                {
                    Id = 219,
                    AfterShip = 141,
                    Name = "五十鈴改",
                    Type = 3,
                    Yomi = "いすず",
                },
                new Ship
                {
                    Id = 220,
                    AfterShip = 0,
                    Name = "由良改",
                    Type = 3,
                    Yomi = "ゆら",
                },
                new Ship
                {
                    Id = 221,
                    AfterShip = 0,
                    Name = "名取改",
                    Type = 3,
                    Yomi = "なとり",
                },
                new Ship
                {
                    Id = 222,
                    AfterShip = 0,
                    Name = "川内改",
                    Type = 3,
                    Yomi = "せんだい",
                },
                new Ship
                {
                    Id = 223,
                    AfterShip = 159,
                    Name = "神通改",
                    Type = 3,
                    Yomi = "じんつう",
                },
                new Ship
                {
                    Id = 224,
                    AfterShip = 160,
                    Name = "那珂改",
                    Type = 3,
                    Yomi = "なか",
                },
                new Ship
                {
                    Id = 225,
                    AfterShip = 0,
                    Name = "陽炎改",
                    Type = 2,
                    Yomi = "かげろう",
                },
                new Ship
                {
                    Id = 226,
                    AfterShip = 0,
                    Name = "不知火改",
                    Type = 2,
                    Yomi = "しらぬい",
                },
                new Ship
                {
                    Id = 227,
                    AfterShip = 0,
                    Name = "黒潮改",
                    Type = 2,
                    Yomi = "くろしお",
                },
                new Ship
                {
                    Id = 228,
                    AfterShip = 0,
                    Name = "雪風改",
                    Type = 2,
                    Yomi = "ゆきかぜ",
                },
                new Ship
                {
                    Id = 229,
                    AfterShip = 0,
                    Name = "島風改",
                    Type = 2,
                    Yomi = "しまかぜ",
                },
                new Ship
                {
                    Id = 230,
                    AfterShip = 0,
                    Name = "朧改",
                    Type = 2,
                    Yomi = "おぼろ",
                },
                new Ship
                {
                    Id = 231,
                    AfterShip = 0,
                    Name = "曙改",
                    Type = 2,
                    Yomi = "あけぼの",
                },
                new Ship
                {
                    Id = 232,
                    AfterShip = 0,
                    Name = "漣改",
                    Type = 2,
                    Yomi = "さざなみ",
                },
                new Ship
                {
                    Id = 233,
                    AfterShip = 0,
                    Name = "潮改",
                    Type = 2,
                    Yomi = "うしお",
                },
                new Ship
                {
                    Id = 234,
                    AfterShip = 0,
                    Name = "暁改",
                    Type = 2,
                    Yomi = "あかつき",
                },
                new Ship
                {
                    Id = 235,
                    AfterShip = 147,
                    Name = "響改",
                    Type = 2,
                    Yomi = "ひびき",
                },
                new Ship
                {
                    Id = 236,
                    AfterShip = 0,
                    Name = "雷改",
                    Type = 2,
                    Yomi = "いかづち",
                },
                new Ship
                {
                    Id = 237,
                    AfterShip = 0,
                    Name = "電改",
                    Type = 2,
                    Yomi = "いなづま",
                },
                new Ship
                {
                    Id = 238,
                    AfterShip = 0,
                    Name = "初春改",
                    Type = 2,
                    Yomi = "はつはる",
                },
                new Ship
                {
                    Id = 239,
                    AfterShip = 0,
                    Name = "子日改",
                    Type = 2,
                    Yomi = "ねのひ",
                },
                new Ship
                {
                    Id = 240,
                    AfterShip = 0,
                    Name = "若葉改",
                    Type = 2,
                    Yomi = "わかば",
                },
                new Ship
                {
                    Id = 241,
                    AfterShip = 0,
                    Name = "初霜改",
                    Type = 2,
                    Yomi = "はつしも",
                },
                new Ship
                {
                    Id = 242,
                    AfterShip = 0,
                    Name = "白露改",
                    Type = 2,
                    Yomi = "しらつゆ",
                },
                new Ship
                {
                    Id = 243,
                    AfterShip = 145,
                    Name = "時雨改",
                    Type = 2,
                    Yomi = "しぐれ",
                },
                new Ship
                {
                    Id = 244,
                    AfterShip = 0,
                    Name = "村雨改",
                    Type = 2,
                    Yomi = "むらさめ",
                },
                new Ship
                {
                    Id = 245,
                    AfterShip = 144,
                    Name = "夕立改",
                    Type = 2,
                    Yomi = "ゆうだち",
                },
                new Ship
                {
                    Id = 246,
                    AfterShip = 0,
                    Name = "五月雨改",
                    Type = 2,
                    Yomi = "さみだれ",
                },
                new Ship
                {
                    Id = 247,
                    AfterShip = 0,
                    Name = "涼風改",
                    Type = 2,
                    Yomi = "すずかぜ",
                },
                new Ship
                {
                    Id = 248,
                    AfterShip = 0,
                    Name = "朝潮改",
                    Type = 2,
                    Yomi = "あさしお",
                },
                new Ship
                {
                    Id = 249,
                    AfterShip = 0,
                    Name = "大潮改",
                    Type = 2,
                    Yomi = "おおしお",
                },
                new Ship
                {
                    Id = 250,
                    AfterShip = 0,
                    Name = "満潮改",
                    Type = 2,
                    Yomi = "みちしお",
                },
                new Ship
                {
                    Id = 251,
                    AfterShip = 0,
                    Name = "荒潮改",
                    Type = 2,
                    Yomi = "あらしお",
                },
                new Ship
                {
                    Id = 252,
                    AfterShip = 0,
                    Name = "霰改",
                    Type = 2,
                    Yomi = "あられ",
                },
                new Ship
                {
                    Id = 253,
                    AfterShip = 0,
                    Name = "霞改",
                    Type = 2,
                    Yomi = "かすみ",
                },
                new Ship
                {
                    Id = 254,
                    AfterShip = 0,
                    Name = "睦月改",
                    Type = 2,
                    Yomi = "むつき",
                },
                new Ship
                {
                    Id = 255,
                    AfterShip = 0,
                    Name = "如月改",
                    Type = 2,
                    Yomi = "きさらぎ",
                },
                new Ship
                {
                    Id = 256,
                    AfterShip = 0,
                    Name = "皐月改",
                    Type = 2,
                    Yomi = "さつき",
                },
                new Ship
                {
                    Id = 257,
                    AfterShip = 0,
                    Name = "文月改",
                    Type = 2,
                    Yomi = "ふみづき",
                },
                new Ship
                {
                    Id = 258,
                    AfterShip = 0,
                    Name = "長月改",
                    Type = 2,
                    Yomi = "ながつき",
                },
                new Ship
                {
                    Id = 259,
                    AfterShip = 0,
                    Name = "菊月改",
                    Type = 2,
                    Yomi = "きくづき",
                },
                new Ship
                {
                    Id = 260,
                    AfterShip = 0,
                    Name = "三日月改",
                    Type = 2,
                    Yomi = "みかづき",
                },
                new Ship
                {
                    Id = 261,
                    AfterShip = 0,
                    Name = "望月改",
                    Type = 2,
                    Yomi = "もちづき",
                },
                new Ship
                {
                    Id = 262,
                    AfterShip = 0,
                    Name = "古鷹改",
                    Type = 5,
                    Yomi = "ふるたか",
                },
                new Ship
                {
                    Id = 263,
                    AfterShip = 0,
                    Name = "加古改",
                    Type = 5,
                    Yomi = "かこ",
                },
                new Ship
                {
                    Id = 264,
                    AfterShip = 0,
                    Name = "青葉改",
                    Type = 5,
                    Yomi = "あおば",
                },
                new Ship
                {
                    Id = 265,
                    AfterShip = 0,
                    Name = "妙高改",
                    Type = 5,
                    Yomi = "みょうこう",
                },
                new Ship
                {
                    Id = 266,
                    AfterShip = 0,
                    Name = "那智改",
                    Type = 5,
                    Yomi = "なち",
                },
                new Ship
                {
                    Id = 267,
                    AfterShip = 0,
                    Name = "足柄改",
                    Type = 5,
                    Yomi = "あしがら",
                },
                new Ship
                {
                    Id = 268,
                    AfterShip = 194,
                    Name = "羽黒改",
                    Type = 5,
                    Yomi = "はぐろ",
                },
                new Ship
                {
                    Id = 269,
                    AfterShip = 0,
                    Name = "高雄改",
                    Type = 5,
                    Yomi = "たかお",
                },
                new Ship
                {
                    Id = 270,
                    AfterShip = 0,
                    Name = "愛宕改",
                    Type = 5,
                    Yomi = "あたご",
                },
                new Ship
                {
                    Id = 271,
                    AfterShip = 0,
                    Name = "摩耶改",
                    Type = 5,
                    Yomi = "まや",
                },
                new Ship
                {
                    Id = 272,
                    AfterShip = 0,
                    Name = "鳥海改",
                    Type = 5,
                    Yomi = "ちょうかい",
                },
                new Ship
                {
                    Id = 273,
                    AfterShip = 188,
                    Name = "利根改",
                    Type = 5,
                    Yomi = "とね",
                },
                new Ship
                {
                    Id = 274,
                    AfterShip = 189,
                    Name = "筑摩改",
                    Type = 5,
                    Yomi = "ちくま",
                },
                new Ship
                {
                    Id = 275,
                    AfterShip = 0,
                    Name = "長門改",
                    Type = 9,
                    Yomi = "ながと",
                },
                new Ship
                {
                    Id = 276,
                    AfterShip = 0,
                    Name = "陸奥改",
                    Type = 9,
                    Yomi = "むつ",
                },
                new Ship
                {
                    Id = 277,
                    AfterShip = 0,
                    Name = "赤城改",
                    Type = 11,
                    Yomi = "あかぎ",
                },
                new Ship
                {
                    Id = 278,
                    AfterShip = 0,
                    Name = "加賀改",
                    Type = 11,
                    Yomi = "かが",
                },
                new Ship
                {
                    Id = 279,
                    AfterShip = 0,
                    Name = "蒼龍改",
                    Type = 11,
                    Yomi = "そうりゅう",
                },
                new Ship
                {
                    Id = 280,
                    AfterShip = 0,
                    Name = "飛龍改",
                    Type = 11,
                    Yomi = "ひりゅう",
                },
                new Ship
                {
                    Id = 281,
                    AfterShip = 157,
                    Name = "龍驤改",
                    Type = 7,
                    Yomi = "りゅうじょう",
                },
                new Ship
                {
                    Id = 282,
                    AfterShip = 0,
                    Name = "祥鳳改",
                    Type = 7,
                    Yomi = "しょうほう",
                },
                new Ship
                {
                    Id = 283,
                    AfterShip = 0,
                    Name = "飛鷹改",
                    Type = 7,
                    Yomi = "ひよう",
                },
                new Ship
                {
                    Id = 284,
                    AfterShip = 0,
                    Name = "隼鷹改",
                    Type = 7,
                    Yomi = "じゅんよう",
                },
                new Ship
                {
                    Id = 285,
                    AfterShip = 0,
                    Name = "鳳翔改",
                    Type = 7,
                    Yomi = "ほうしょう",
                },
                new Ship
                {
                    Id = 286,
                    AfterShip = 0,
                    Name = "扶桑改",
                    Type = 10,
                    Yomi = "ふそう",
                },
                new Ship
                {
                    Id = 287,
                    AfterShip = 0,
                    Name = "山城改",
                    Type = 10,
                    Yomi = "やましろ",
                },
                new Ship
                {
                    Id = 288,
                    AfterShip = 0,
                    Name = "翔鶴改",
                    Type = 11,
                    Yomi = "しょうかく",
                },
                new Ship
                {
                    Id = 289,
                    AfterShip = 0,
                    Name = "鬼怒改",
                    Type = 3,
                    Yomi = "きぬ",
                },
                new Ship
                {
                    Id = 290,
                    AfterShip = 0,
                    Name = "阿武隈改",
                    Type = 3,
                    Yomi = "あぶくま",
                },
                new Ship
                {
                    Id = 291,
                    AfterShip = 296,
                    Name = "千歳航改",
                    Type = 7,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 292,
                    AfterShip = 297,
                    Name = "千代田航改",
                    Type = 7,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 293,
                    AfterShip = 0,
                    Name = "夕張改",
                    Type = 3,
                    Yomi = "ゆうばり",
                },
                new Ship
                {
                    Id = 294,
                    AfterShip = 0,
                    Name = "舞風改",
                    Type = 2,
                    Yomi = "まいかぜ",
                },
                new Ship
                {
                    Id = 295,
                    AfterShip = 142,
                    Name = "衣笠改",
                    Type = 5,
                    Yomi = "きぬがさ",
                },
                new Ship
                {
                    Id = 296,
                    AfterShip = 0,
                    Name = "千歳航改二",
                    Type = 7,
                    Yomi = "ちとせ",
                },
                new Ship
                {
                    Id = 297,
                    AfterShip = 0,
                    Name = "千代田航改二",
                    Type = 7,
                    Yomi = "ちよだ",
                },
                new Ship
                {
                    Id = 300,
                    AfterShip = 0,
                    Name = "初風改",
                    Type = 2,
                    Yomi = "はつかぜ",
                },
                new Ship
                {
                    Id = 301,
                    AfterShip = 0,
                    Name = "秋雲改",
                    Type = 2,
                    Yomi = "あきぐも",
                },
                new Ship
                {
                    Id = 302,
                    AfterShip = 0,
                    Name = "夕雲改",
                    Type = 2,
                    Yomi = "ゆうぐも",
                },
                new Ship
                {
                    Id = 303,
                    AfterShip = 0,
                    Name = "巻雲改",
                    Type = 2,
                    Yomi = "まきぐも",
                },
                new Ship
                {
                    Id = 304,
                    AfterShip = 0,
                    Name = "長波改",
                    Type = 2,
                    Yomi = "ながなみ",
                },
                new Ship
                {
                    Id = 305,
                    AfterShip = 0,
                    Name = "阿賀野改",
                    Type = 3,
                    Yomi = "あがの",
                },
                new Ship
                {
                    Id = 306,
                    AfterShip = 0,
                    Name = "能代改",
                    Type = 3,
                    Yomi = "のしろ",
                },
                new Ship
                {
                    Id = 307,
                    AfterShip = 0,
                    Name = "矢矧改",
                    Type = 3,
                    Yomi = "やはぎ",
                },
                new Ship
                {
                    Id = 308,
                    AfterShip = 0,
                    Name = "弥生改",
                    Type = 2,
                    Yomi = "やよい",
                },
                new Ship
                {
                    Id = 309,
                    AfterShip = 0,
                    Name = "卯月改",
                    Type = 2,
                    Yomi = "うづき",
                },
                new Ship
                {
                    Id = 310,
                    AfterShip = 179,
                    Name = "Z1改",
                    Type = 2,
                    Yomi = "レーベレヒト・マース",
                },
                new Ship
                {
                    Id = 311,
                    AfterShip = 180,
                    Name = "Z3改",
                    Type = 2,
                    Yomi = "マックス・シュルツ",
                },
                new Ship
                {
                    Id = 312,
                    AfterShip = 0,
                    Name = "浜風改",
                    Type = 2,
                    Yomi = "はまかぜ",
                },
                new Ship
                {
                    Id = 313,
                    AfterShip = 0,
                    Name = "谷風改",
                    Type = 2,
                    Yomi = "たにかぜ",
                },
                new Ship
                {
                    Id = 314,
                    AfterShip = 0,
                    Name = "酒匂改",
                    Type = 3,
                    Yomi = "さかわ",
                },
                new Ship
                {
                    Id = 316,
                    AfterShip = 0,
                    Name = "天津風改",
                    Type = 2,
                    Yomi = "あまつかぜ",
                },
                new Ship
                {
                    Id = 317,
                    AfterShip = 0,
                    Name = "浦風改",
                    Type = 2,
                    Yomi = "うらかぜ",
                },
                new Ship
                {
                    Id = 398,
                    AfterShip = 0,
                    Name = "伊168改",
                    Type = 13,
                    Yomi = "い168",
                },
                new Ship
                {
                    Id = 399,
                    AfterShip = 0,
                    Name = "伊58改",
                    Type = 14,
                    Yomi = "い58",
                },
                new Ship
                {
                    Id = 400,
                    AfterShip = 0,
                    Name = "伊8改",
                    Type = 14,
                    Yomi = "い8",
                },
                new Ship
                {
                    Id = 401,
                    AfterShip = 0,
                    Name = "伊19改",
                    Type = 14,
                    Yomi = "い19",
                },
                new Ship
                {
                    Id = 402,
                    AfterShip = 0,
                    Name = "まるゆ改",
                    Type = 13,
                    Yomi = "まるゆ",
                },
                new Ship
                {
                    Id = 403,
                    AfterShip = 0,
                    Name = "伊401改",
                    Type = 14,
                    Yomi = "い401",
                },
                new Ship
                {
                    Id = 501,
                    AfterShip = 0,
                    Name = "駆逐イ級",
                    Type = 2,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 502,
                    AfterShip = 0,
                    Name = "駆逐ロ級",
                    Type = 2,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 503,
                    AfterShip = 0,
                    Name = "駆逐ハ級",
                    Type = 2,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 504,
                    AfterShip = 0,
                    Name = "駆逐ニ級",
                    Type = 2,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 505,
                    AfterShip = 0,
                    Name = "軽巡ホ級",
                    Type = 3,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 506,
                    AfterShip = 0,
                    Name = "軽巡ヘ級",
                    Type = 3,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 507,
                    AfterShip = 0,
                    Name = "軽巡ト級",
                    Type = 3,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 508,
                    AfterShip = 0,
                    Name = "雷巡チ級",
                    Type = 4,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 509,
                    AfterShip = 0,
                    Name = "重巡リ級",
                    Type = 5,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 510,
                    AfterShip = 0,
                    Name = "軽母ヌ級",
                    Type = 7,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 511,
                    AfterShip = 0,
                    Name = "戦艦ル級",
                    Type = 9,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 512,
                    AfterShip = 0,
                    Name = "空母ヲ級",
                    Type = 11,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 513,
                    AfterShip = 0,
                    Name = "輸送ワ級",
                    Type = 15,
                    Yomi = "-",
                },
                new Ship
                {
                    Id = 514,
                    AfterShip = 0,
                    Name = "駆逐イ級",
                    Type = 2,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 515,
                    AfterShip = 0,
                    Name = "駆逐ロ級",
                    Type = 2,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 516,
                    AfterShip = 0,
                    Name = "駆逐ハ級",
                    Type = 2,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 517,
                    AfterShip = 0,
                    Name = "駆逐ニ級",
                    Type = 2,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 518,
                    AfterShip = 0,
                    Name = "軽巡ホ級",
                    Type = 3,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 519,
                    AfterShip = 0,
                    Name = "軽巡ヘ級",
                    Type = 3,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 520,
                    AfterShip = 0,
                    Name = "軽巡ト級",
                    Type = 3,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 521,
                    AfterShip = 0,
                    Name = "雷巡チ級",
                    Type = 4,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 522,
                    AfterShip = 0,
                    Name = "重巡リ級",
                    Type = 5,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 523,
                    AfterShip = 0,
                    Name = "軽母ヌ級",
                    Type = 7,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 524,
                    AfterShip = 0,
                    Name = "戦艦ル級",
                    Type = 9,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 525,
                    AfterShip = 0,
                    Name = "空母ヲ級",
                    Type = 11,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 526,
                    AfterShip = 0,
                    Name = "輸送ワ級",
                    Type = 15,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 527,
                    AfterShip = 0,
                    Name = "重巡リ級",
                    Type = 5,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 528,
                    AfterShip = 0,
                    Name = "空母ヲ級",
                    Type = 11,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 529,
                    AfterShip = 0,
                    Name = "戦艦ル級",
                    Type = 9,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 530,
                    AfterShip = 0,
                    Name = "潜水カ級",
                    Type = 13,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 531,
                    AfterShip = 0,
                    Name = "潜水ヨ級",
                    Type = 13,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 532,
                    AfterShip = 0,
                    Name = "潜水カ級",
                    Type = 13,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 533,
                    AfterShip = 0,
                    Name = "潜水ヨ級",
                    Type = 13,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 534,
                    AfterShip = 0,
                    Name = "潜水カ級",
                    Type = 13,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 535,
                    AfterShip = 0,
                    Name = "潜水ヨ級",
                    Type = 13,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 536,
                    AfterShip = 0,
                    Name = "浮遊要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 537,
                    AfterShip = 0,
                    Name = "浮遊要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 538,
                    AfterShip = 0,
                    Name = "浮遊要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 539,
                    AfterShip = 0,
                    Name = "泊地棲鬼",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 540,
                    AfterShip = 0,
                    Name = "泊地棲姫",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 541,
                    AfterShip = 0,
                    Name = "戦艦タ級",
                    Type = 8,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 542,
                    AfterShip = 0,
                    Name = "戦艦タ級",
                    Type = 8,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 543,
                    AfterShip = 0,
                    Name = "戦艦タ級",
                    Type = 8,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 544,
                    AfterShip = 0,
                    Name = "装甲空母鬼",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 545,
                    AfterShip = 0,
                    Name = "装甲空母姫",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 546,
                    AfterShip = 0,
                    Name = "南方棲鬼",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 547,
                    AfterShip = 0,
                    Name = "南方棲戦鬼",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 548,
                    AfterShip = 0,
                    Name = "南方棲戦姫",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 549,
                    AfterShip = 0,
                    Name = "護衛要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 550,
                    AfterShip = 0,
                    Name = "護衛要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 551,
                    AfterShip = 0,
                    Name = "護衛要塞",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 552,
                    AfterShip = 0,
                    Name = "駆逐ロ級",
                    Type = 2,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 553,
                    AfterShip = 0,
                    Name = "駆逐ハ級",
                    Type = 2,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 554,
                    AfterShip = 0,
                    Name = "軽巡ホ級",
                    Type = 3,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 555,
                    AfterShip = 0,
                    Name = "軽巡ヘ級",
                    Type = 3,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 556,
                    AfterShip = 0,
                    Name = "飛行場姫",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 557,
                    AfterShip = 0,
                    Name = "戦艦棲姫",
                    Type = 9,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 558,
                    AfterShip = 0,
                    Name = "輸送ワ級",
                    Type = 15,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 559,
                    AfterShip = 0,
                    Name = "雷巡チ級",
                    Type = 4,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 560,
                    AfterShip = 0,
                    Name = "軽母ヌ級",
                    Type = 7,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 561,
                    AfterShip = 0,
                    Name = "戦艦レ級",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 562,
                    AfterShip = 0,
                    Name = "戦艦レ級",
                    Type = 10,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 564,
                    AfterShip = 0,
                    Name = "駆逐イ級",
                    Type = 2,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 565,
                    AfterShip = 0,
                    Name = "空母ヲ級改",
                    Type = 11,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 566,
                    AfterShip = 0,
                    Name = "重巡リ級改",
                    Type = 5,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 567,
                    AfterShip = 0,
                    Name = "戦艦ル級改",
                    Type = 9,
                    Yomi = "flagship",
                },
                new Ship
                {
                    Id = 570,
                    AfterShip = 0,
                    Name = "潜水ソ級",
                    Type = 13,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 571,
                    AfterShip = 0,
                    Name = "潜水ソ級",
                    Type = 13,
                    Yomi = "elite",
                },
                new Ship
                {
                    Id = 573,
                    AfterShip = 0,
                    Name = "港湾棲姫",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 574,
                    AfterShip = 0,
                    Name = "離島棲鬼",
                    Type = 10,
                    Yomi = "",
                },
                new Ship
                {
                    Id = 581,
                    AfterShip = 0,
                    Name = "ナガラ級",
                    Type = 3,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 582,
                    AfterShip = 0,
                    Name = "タカオ",
                    Type = 5,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 583,
                    AfterShip = 0,
                    Name = "マヤ",
                    Type = 5,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 584,
                    AfterShip = 0,
                    Name = "ハルナ",
                    Type = 8,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 585,
                    AfterShip = 0,
                    Name = "キリシマ",
                    Type = 8,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 586,
                    AfterShip = 0,
                    Name = "コンゴウ",
                    Type = 8,
                    Yomi = "mist",
                },
                new Ship
                {
                    Id = 587,
                    AfterShip = 0,
                    Name = "ナガラ級*",
                    Type = 3,
                    Yomi = "mist*",
                },
                new Ship
                {
                    Id = 588,
                    AfterShip = 0,
                    Name = "タカオ*",
                    Type = 5,
                    Yomi = "mist*",
                },
                new Ship
                {
                    Id = 589,
                    AfterShip = 0,
                    Name = "マヤ*",
                    Type = 5,
                    Yomi = "mist*",
                },
                new Ship
                {
                    Id = 590,
                    AfterShip = 0,
                    Name = "ハルナ*",
                    Type = 8,
                    Yomi = "mist*",
                },
                new Ship
                {
                    Id = 591,
                    AfterShip = 0,
                    Name = "キリシマ*",
                    Type = 8,
                    Yomi = "mist*",
                },
                new Ship
                {
                    Id = 592,
                    AfterShip = 0,
                    Name = "コンゴウ*",
                    Type = 8,
                    Yomi = "mist*",
                },
            };
            return ships;
        }
    }
}
