using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;

public static class AllCards
{
    #region level1
    //Pack price 750, 10-13, +0
    public static Card Geezard = new Card(1, "Geezard", 1, new Rank(1, 4, 5, 1), 650);//11 - 650
    public static Card Funguar = new Card(2, "Funguar", 1, new Rank(5, 1, 1, 3), 100);//10 - 100
    public static Card BiteBug = new Card(3, "Bite Bug", 1, new Rank(1, 3, 3, 5), 1300);//12 -1300
    public static Card RedBat = new Card(4, "Red Bat", 1, new Rank(6, 1, 1, 2), 100);//10 - 100
    public static Card Blobra = new Card(5, "Blobra", 1, new Rank(2, 3, 1, 5), 650);//11 - 650
    public static Card Gayla = new Card(6, "Gayla", 1, new Rank(2, 1, 4, 4), 650, Element.Lightning);//11 - 650
    public static Card Gesper = new Card(7, "Gesper", 1, new Rank(1, 5, 4, 1), 100);//11 - 650
    public static Card FastitocalonF = new Card(8, "Fastitocalon-F", 1, new Rank(3, 5, 2, 1), 1300, Element.Earth);//12 - 1300
    public static Card BloodSoul = new Card(9, "Blood Soul", 1, new Rank(2, 1, 6, 1), 100);//10 - 100
    public static Card Caterchipillar = new Card(10, "Caterchipillar", 1, new Rank(4, 2, 4, 3), 2050);//13 - 2050
    public static Card Cockatrice = new Card(11, "Cockatrice", 1, new Rank(2, 1, 2, 6), 650, Element.Lightning);//11 - 650
    #endregion

    #region level2
    //Pack price 3000, 12-15, +200
    public static Card Grat = new Card(12, "Grat", 2, new Rank(7, 1, 3, 1), 1500);//12 -1300
    public static Card Buel = new Card(13, "Buel", 2, new Rank(6, 2, 2, 3), 2250);//13 - 2050 - 2050
    public static Card Mesmerize = new Card(14, "Mesmerize", 2, new Rank(5, 3, 3, 4), 4050);//15 - 3850
    public static Card GlacialEye = new Card(15, "Glacial Eye", 2, new Rank(6, 1, 4, 3), 3100,Element.Ice);//14 - 2900
    public static Card Belhelmel = new Card(16, "Belhelmel", 2, new Rank(3, 4, 5, 3), 4050);//15 - 3850
    public static Card Thrustaevis = new Card(17, "Thrustaevis", 2, new Rank(5, 3, 2, 5), 4050,Element.Wind);//15 - 3850
    public static Card Anacondaur = new Card(18, "Anacondaur", 2, new Rank(5, 1, 3, 5), 3100,Element.Poison);//14 - 2900
    public static Card Creeps = new Card(19, "Creeps", 2, new Rank(5, 2, 5, 2), 3100,Element.Lightning);//14 - 2900
    public static Card Grendel = new Card(20, "Grendel", 2, new Rank(4, 4, 5, 2), 4050,Element.Lightning);//15 - 3850
    public static Card Jelleye = new Card(21, "Jelleye", 2, new Rank(3, 2, 1, 7), 2250);//13 - 2050
    public static Card GrandMantis = new Card(22, "Grand Mantis", 2, new Rank(5, 2, 5, 3), 4050);//15 - 3850
    #endregion

    #region level3
    //Pack price 5850, 16-18, +300
    public static Card Forbidden = new Card(23, "Forbidden", 3, new Rank(6, 6, 3, 2), 6350);//17 - 6050
    public static Card Armadodo = new Card(24, "Armadodo", 3, new Rank(6, 3, 1, 6), 5200,Element.Earth);//16 - 4900
    public static Card TriFace = new Card(25, "Tri-Face", 3, new Rank(3, 5, 5, 5), 7600,Element.Poison);//18 - 7300
    public static Card Fastitocalon = new Card(26, "Fastitocalon", 3, new Rank(7, 5, 1, 3), 5200,Element.Earth);//16 - 4900
    public static Card SnowLion = new Card(27, "Snow Lion", 3, new Rank(7, 1, 5, 3), 5200,Element.Ice);//16 - 4900
    public static Card Ochu = new Card(28, "Ochu", 3, new Rank(5, 6, 3, 3), 6350);//17 - 6050
    public static Card Sam08G = new Card(29, "SAM08G", 3, new Rank(5, 6, 2, 4), 6350,Element.Fire);//17 - 6050
    public static Card DeathClaw = new Card(30, "Death Claw", 3, new Rank(4, 4, 7, 2), 6350,Element.Fire);//17 - 6050
    public static Card Cactuar = new Card(31, "Cactuar", 3, new Rank(6, 2, 6, 3), 6350);//17 - 6050
    public static Card Tonberry = new Card(32, "Tonberry", 3, new Rank(3, 6, 4, 4), 6350);//17 - 6050
    public static Card AbyssWorm = new Card(33, "Abyss Worm", 3, new Rank(7, 2, 3, 5), 6350,Element.Earth);//17 - 6050
    #endregion

    #region level4
    //Pack price 8000, 17-20 +400
    public static Card Turtapod = new Card(34, "Turtapod", 4, new Rank(2, 3, 6, 7), 7700);//18 - 7300
    public static Card Vysage = new Card(35, "Vysage", 4, new Rank(6, 5, 4, 5), 10500);//20 - 10100
    public static Card TRexaur = new Card(36, "T-Rexaur", 4, new Rank(4, 6, 2, 7), 9050);//19 - 8650
    public static Card Bomb = new Card(37, "Bomb", 4, new Rank(2, 7, 6, 3), 7700,Element.Fire);//18 - 7300
    public static Card Blitz = new Card(38, "Blitz", 4, new Rank(1, 6, 4, 7), 7700,Element.Lightning);//18 - 7300
    public static Card Wendigo = new Card(39, "Wendigo", 4, new Rank(7, 3, 1, 6), 6450);//17 - 6050
    public static Card Torama = new Card(40, "Torama", 4, new Rank(7, 4, 4, 4), 9050);//19 - 8650
    public static Card Imp = new Card(41, "Imp", 4, new Rank(3, 7, 3, 6), 9050);//19 - 8650
    public static Card BlueDragon = new Card(42, "Blue Dragon", 4, new Rank(6, 2, 7, 3), 7700,Element.Poison);//18 - 7300
    public static Card Adamantoise = new Card(43, "Adamantoise", 4, new Rank(4, 5, 5, 6), 10500,Element.Earth);//20 - 10100
    public static Card Hexadragon = new Card(44, "Hexadragon", 4, new Rank(7, 5, 4, 3), 9050,Element.Fire);//19 - 8650
    #endregion

    #region level5
    //Pack price 10900, 16-22, +500
    public static Card IronGiant = new Card(45, "Iron Giant", 5, new Rank(6, 5, 6, 5), 13800);//22 - 13300
    public static Card Behemoth = new Card(46, "Behemoth", 5, new Rank(3, 6, 5, 7), 12150);//21 - 11650
    public static Card Chimera = new Card(47, "Chimera", 5, new Rank(7, 6, 5, 3), 12150,Element.Water);//21 - 11650
    public static Card PuPu = new Card(48, "PuPu", 5, new Rank(3, 10, 2, 1), 5400);//16 - 4900
    public static Card Elastoid = new Card(49, "Elastoid", 5, new Rank(6, 2, 6, 7), 12150);//21 - 11650
    public static Card Gim47N = new Card(50, "GIM47N", 5, new Rank(5, 5, 7, 4), 12150);//21 - 11650
    public static Card Malboro = new Card(51, "Malboro", 5, new Rank(7, 7, 4, 2), 10600,Element.Poison);//20 - 10100
    public static Card RubyDragon = new Card(52, "Ruby Dragon", 5, new Rank(7, 2, 7, 4), 10600,Element.Fire);//20 - 10100
    public static Card Elnoyle = new Card(53, "Elnoyle", 5, new Rank(5, 3, 7, 6), 12150);//21 - 11650
    public static Card TonberryKing = new Card(54, "Tonberry King", 5, new Rank(4, 6, 7, 4), 12150);//21 - 11650
    public static Card BiggsWedge = new Card(55, "Biggs, Wedge", 5, new Rank(6, 6, 2, 7), 12150);//21 - 11650
    #endregion

    #region level6
    //Pack price 12900, 20-23, +600
    public static Card FujinRaijin = new Card(56, "Rujin, Raijin", 6, new Rank(2, 8, 8, 4), 13900);//22 - 13300
    public static Card Elvoret = new Card(57, "Elvoret", 6, new Rank(7, 8, 3, 4), 13900,Element.Wind);//22 - 13300
    public static Card XAtm092 = new Card(58, "X-ATM092", 6, new Rank(4, 8, 7, 3), 13900);//22 - 13300
    public static Card Granaldo = new Card(59, "Granaldo", 6, new Rank(7, 2, 8, 5), 13900);//22 - 13300
    public static Card Gerogero = new Card(60, "Gerogero", 6, new Rank(1, 8, 8, 3), 10700,Element.Poison);//20 - 10100
    public static Card Iguion = new Card(61, "Iguion", 6, new Rank(8, 2, 8, 2), 10700);//20 - 10100
    public static Card Abadon = new Card(62, "Abadon", 6, new Rank(6, 8, 4, 5), 15650);//23 - 15050
    public static Card Trauma = new Card(63, "Trauma", 6, new Rank(4, 8, 5, 6), 15650);//23 - 15050
    public static Card Oilboyle = new Card(64, "Oilboyle", 6, new Rank(1, 8, 4, 8), 12250);//21 - 11650
    public static Card ShumiTribe = new Card(65, "Shumi Tribe", 6, new Rank(6, 5, 8, 4), 15650);//23 - 15050
    public static Card Krysta = new Card(66, "Krysta", 6, new Rank(7, 5, 8, 1), 12250);//21 - 11650
    #endregion

    #region level7
    //Pack price 19000, 23-25, +700
    public static Card Propagator = new Card(67, "Propagator", 7, new Rank(8, 4, 4, 8), 17600);//24 - 16900
    public static Card JumboCactuar = new Card(68, "Jumbo Cactuar", 7, new Rank(8, 8, 4, 4), 17600);//24 - 16900
    public static Card TriPoint = new Card(69, "Tri-Point", 7, new Rank(8, 5, 2, 8), 15750, Element.Lightning);//23 - 15050
    public static Card Gargantua = new Card(70, "Gargantua", 7, new Rank(5, 6, 6, 8), 19550);//25 - 18850
    public static Card MobileType8 = new Card(71, "Mobile Type 8", 7, new Rank(8, 6, 7, 3), 17600);//24 - 16900
    public static Card Sphinxara = new Card(72, "Sphinxara", 7, new Rank(8, 3, 5, 8), 17600);//24 - 16900
    public static Card Tiamat = new Card(73, "Tiamat", 7, new Rank(8, 8, 5, 4), 19550);//25 - 18850
    public static Card Bgh251F2 = new Card(74, "BGH251F2", 7, new Rank(5, 7, 8, 5), 19550);//25 - 18850
    public static Card RedGiant = new Card(75, "Red Giant", 7, new Rank(6, 8, 4, 7), 19550);//25 - 18850
    public static Card Catoblepas = new Card(76, "Catoblepas", 7, new Rank(1, 8, 7, 7), 15750);//23 - 15050
    public static Card UltimaWeapon = new Card(77, "Ultima Weapon", 7, new Rank(7, 7, 2, 8), 17600);//24 - 16900
    #endregion

    #region level8
    //Pack price (18500)21500, 23-26, +800
    public static Card ChubbyChocobo = new Card(78, "Chubby Chocobo", 8, new Rank(4, 4, 8, 9), 19650);//25 - 18850
    public static Card Angelo = new Card(79, "Angelo", 8, new Rank(9, 6, 7, 3), 19650);//25 - 18850
    public static Card Gilgamesh = new Card(80, "Gilgamesh", 8, new Rank(3, 7, 9, 6), 19650);//25 - 18850
    public static Card MiniMog = new Card(81, "MiniMog", 8, new Rank(9, 3, 9, 2), 15850);//23 - 15050
    public static Card Chicobo = new Card(82, "Chicobo", 8, new Rank(9, 4, 8, 4), 19650);//25 - 18850
    public static Card Quezacotl = new Card(83, "Quezacotl", 8, new Rank(2, 9, 9, 4), 17700, Element.Lightning);//24 - 16900
    public static Card Shiva = new Card(84, "Shiva", 8, new Rank(6, 7, 4, 9), 21700, Element.Ice);//26 - 20900
    public static Card Ifrit = new Card(85, "Ifrit", 8, new Rank(9, 6, 2, 8), 19650, Element.Fire);//25 - 18850
    public static Card Siren = new Card(86, "Siren", 8, new Rank(8, 9, 6, 2), 19650);//25 - 18850
    public static Card Sacred = new Card(87, "Sacred", 8, new Rank(5, 1, 9, 9), 17700, Element.Earth);//24 - 16900
    public static Card Minotaur = new Card(88, "Minotaur", 8, new Rank(9, 5, 2, 9), 19650, Element.Earth);//25 - 18850
    #endregion

    #region level9
    //Pack price (19500)24050, 24-27, +900
    public static Card Carbuncle = new Card(89, "Carbuncle", 9, new Rank(8, 4, 10, 4), 21800);//26 - 20900
    public static Card Diablos = new Card(90, "Diablos", 9, new Rank(5, 10, 8, 3), 21800);//26 - 20900
    public static Card Leviathan = new Card(91, "Leviathan", 9, new Rank(7, 10, 1, 7), 19750, Element.Water);//25 - 18850
    public static Card Odin = new Card(92, "Odin", 9, new Rank(8, 10, 3, 5), 21800);//26 - 20900
    public static Card Pandemona = new Card(93, "Pandemona", 9, new Rank(10, 1, 7, 7), 19750, Element.Wind);//25 - 18850
    public static Card Cerberus = new Card(94, "Cerberus", 9, new Rank(7, 4, 6, 10), 23950);//27 - 23050
    public static Card Alexander = new Card(95, "Alexander", 9, new Rank(9, 10, 4, 2), 19750,Element.Holy);//25 - 18850
    public static Card Phoenix = new Card(96, "Phoenix", 9, new Rank(7, 2, 7, 10), 21800, Element.Fire);//26 - 20900
    public static Card Bahamut = new Card(97, "Bahamut", 9, new Rank(10, 8, 2, 6), 21800);//26 - 20900
    public static Card Doomtrain = new Card(98, "Doomtrain", 9, new Rank(3, 1, 10, 10), 17800, Element.Poison);//24 - 16900
    public static Card Eden = new Card(99, "Eden", 9, new Rank(4, 4, 9, 10), 23950);//27 - 23050
    #endregion

    #region level10
    //Pack price (??), 26-29, +special
    public static Card Ward = new Card(100, "Ward", 10, new Rank(10, 7, 2, 8), 27000);//27 - 23050
    public static Card Kiros = new Card(101, "Kiros", 10, new Rank(6, 7, 6, 10), 30000);//29 - 27650
    public static Card Laguna = new Card(102, "Laguna", 10, new Rank(5, 10, 3, 9), 27000);//27 - 23050
    public static Card Selphie = new Card(103, "Selphie", 10, new Rank(10, 8, 6, 4), 28500);//28 - 25300
    public static Card Quistis = new Card(104, "Quistis", 10, new Rank(9, 6, 10, 2), 27000);//27 - 23050
    public static Card Irvine = new Card(105, "Irvine", 10, new Rank(2, 6, 9, 10), 27000);//27 - 23050
    public static Card Zell = new Card(106, "Zell", 10, new Rank(8, 5, 10, 6), 30000);//29 - 27650
    public static Card Rinoa = new Card(107, "Rinoa", 10, new Rank(4, 10, 2, 10), 30000);//29 - 27650
    public static Card Edea = new Card(108, "Edea", 10, new Rank(10, 10, 3, 3), 26500);//26 - 20900
    public static Card Seifer = new Card(109, "Seifer", 10, new Rank(6, 9, 10, 4), 30000);//29 - 27650
    public static Card Squall = new Card(110, "Squall", 10, new Rank(10, 4, 6, 9), 30000);//29 - 27650
    #endregion

    static AllCards()
    {
        var list = new List<Card>()
            {
                #region level 1
                Geezard,
                Funguar,
                BiteBug,
                RedBat,
                Blobra,
                Gayla,
                Gesper,
                FastitocalonF,
                BloodSoul,
                Caterchipillar,
                Cockatrice,
                #endregion
                #region level 2
                Grat,
                Buel,
                Mesmerize,
                GlacialEye,
                Belhelmel,
                Thrustaevis,
                Anacondaur,
                Creeps,
                Grendel,
                Jelleye,
                GrandMantis,
                #endregion
                #region level 3
                Forbidden,
                Armadodo,
                TriFace,
                Fastitocalon,
                SnowLion,
                Ochu,
                Sam08G,
                DeathClaw,
                Cactuar,
                Tonberry,
                AbyssWorm,
                #endregion
                #region level 4
                Turtapod,
                Vysage,
                TRexaur,
                Bomb,
                Blitz,
                Wendigo,
                Torama,
                Imp,
                BlueDragon,
                Adamantoise,
                Hexadragon,
                #endregion
                #region level 5
                IronGiant,
                Behemoth,
                Chimera,
                PuPu,
                Elastoid,
                Gim47N,
                Malboro,
                RubyDragon,
                Elnoyle,
                TonberryKing,
                BiggsWedge,
                #endregion
                #region level 6
                FujinRaijin,
                Elvoret,
                XAtm092,
                Granaldo,
                Gerogero,
                Iguion,
                Abadon,
                Trauma,
                Oilboyle,
                ShumiTribe,
                Krysta,
                #endregion
                #region level 7
                Propagator,
                JumboCactuar,
                TriPoint,
                Gargantua,
                MobileType8,
                Sphinxara,
                Tiamat,
                Bgh251F2,
                RedGiant,
                Catoblepas,
                UltimaWeapon,
                #endregion
                #region level 8
                ChubbyChocobo,
                Angelo,
                Gilgamesh,
                MiniMog,
                Chicobo,
                Quezacotl,
                Shiva,
                Ifrit,
                Siren,
                Sacred,
                Minotaur,
                #endregion
                #region level 9
                Carbuncle,
                Diablos,
                Leviathan,
                Odin,
                Pandemona,
                Cerberus,
                Alexander,
                Phoenix,
                Bahamut,
                Doomtrain,
                Eden,
                #endregion
                #region level 10
                Ward,
                Kiros,
                Laguna,
                Selphie,
                Quistis,
                Irvine,
                Zell,
                Rinoa,
                Edea,
                Seifer,
                Squall
                #endregion
            };

        List = new ReadOnlyCollection<Card>(list);
    }

    public static readonly IEnumerable<Card> List;
}

