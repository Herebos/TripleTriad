using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;

public static class AllCards
{
    #region level1
    public static Card test = new Card(1, "Test", 1, new Rank(1, 4, 5, 1));
    public static Card Geezard = new Card(1, "Geezard", 1, new Rank(1, 4, 5, 1));
    public static Card Funguar = new Card(2, "Funguar", 1, new Rank(5, 1, 1, 3));
    public static Card BiteBug = new Card(3, "Bite Bug", 1, new Rank(1, 3, 3, 5));
    public static Card RedBat = new Card(4, "Red Bat", 1, new Rank(6, 1, 1, 2));
    public static Card Blobra = new Card(5, "Blobra", 1, new Rank(2, 3, 1, 5));
    public static Card Gayla = new Card(6, "Gayla", 1, new Rank(2, 1, 4, 4), Element.Lightning);
    public static Card Gesper = new Card(7, "Gesper", 1, new Rank(1, 5, 4, 1));
    public static Card FastitocalonF = new Card(8, "Fastitocalon-F", 1, new Rank(3, 5, 2, 1), Element.Earth);
    public static Card BloodSoul = new Card(9, "Blood Soul", 1, new Rank(2, 1, 6, 1));
    public static Card Caterchipillar = new Card(10, "Caterchipillar", 1, new Rank(4, 2, 4, 3));
    public static Card Cockatrice = new Card(11, "Cockatrice", 1, new Rank(2, 1, 2, 6), Element.Lightning);
    #endregion

    #region level2
    public static Card Grat = new Card(10, "Grat", 2, new Rank(7, 1, 3, 1));
    public static Card Buel = new Card(11, "Buel", 2, new Rank(6, 2, 2, 3));
    public static Card Mesmerize = new Card(12, "Mesmerize", 2, new Rank(5, 3, 3, 4));
    public static Card GlacialEye = new Card(13, "Glacial Eye", 2, new Rank(6, 1, 4, 3), Element.Ice);
    public static Card Belhelmel = new Card(14, "Belhelmel", 2, new Rank(3, 4, 5, 3));
    public static Card Thrustaevis = new Card(15, "Thrustaevis", 2, new Rank(5, 3, 2, 5), Element.Wind);
    public static Card Anacondaur = new Card(16, "Anacondaur", 2, new Rank(5, 1, 3, 5), Element.Poison);
    public static Card Creeps = new Card(17, "Creeps", 2, new Rank(5, 2, 5, 2), Element.Lightning);
    public static Card Grendel = new Card(18, "Grendel", 2, new Rank(4, 4, 5, 2), Element.Lightning);
    public static Card Jelleye = new Card(19, "Jelleye", 2, new Rank(3, 2, 1, 7));
    public static Card GrandMantis = new Card(20, "Grand Mantis", 2, new Rank(5, 2, 5, 3));
    #endregion

    #region level3
    public static Card Forbidden = new Card(21, "Forbidden", 3, new Rank(6, 6, 3, 2));
    public static Card Armadodo = new Card(22, "Armadodo", 3, new Rank(6, 3, 1, 6), Element.Earth);
    public static Card TriFace = new Card(23, "Tri-Face", 3, new Rank(3, 5, 5, 5), Element.Poison);
    public static Card Fastitocalon = new Card(24, "Fastitocalon", 3, new Rank(7, 5, 1, 3), Element.Earth);
    public static Card SnowLion = new Card(25, "Snow Lion", 3, new Rank(7, 1, 5, 3), Element.Ice);
    public static Card Ochu = new Card(26, "Ochu", 3, new Rank(5, 6, 3, 3));
    public static Card Sam08G = new Card(27, "SAM08G", 3, new Rank(5, 6, 2, 4), Element.Fire);
    public static Card DeathClaw = new Card(28, "Death Claw", 3, new Rank(4, 4, 7, 2), Element.Fire);
    public static Card Cactuar = new Card(29, "Cactuar", 3, new Rank(6, 2, 6, 3));
    public static Card Tonberry = new Card(30, "Tonberry", 3, new Rank(3, 6, 4, 4));
    public static Card AbyssWorm = new Card(31, "Abyss Worm", 3, new Rank(7, 2, 3, 5), Element.Earth);
    #endregion

    #region level4
    public static Card Turtapod = new Card(32, "Turtapod", 4, new Rank(2, 3, 6, 7));
    public static Card Vysage = new Card(33, "Vysage", 4, new Rank(6, 5, 4, 5));
    public static Card TRexaur = new Card(34, "T-Rexaur", 4, new Rank(4, 6, 2, 7));
    public static Card Bomb = new Card(35, "Bomb", 4, new Rank(2, 7, 6, 3), Element.Fire);
    public static Card Blitz = new Card(36, "Blitz", 4, new Rank(1, 6, 4, 7), Element.Lightning);
    public static Card Wendigo = new Card(37, "Wendigo", 4, new Rank(7, 3, 1, 6));
    public static Card Torama = new Card(38, "Torama", 4, new Rank(7, 4, 4, 4));
    public static Card Imp = new Card(39, "Imp", 4, new Rank(3, 7, 3, 6));
    public static Card BlueDragon = new Card(40, "Blue Dragon", 4, new Rank(6, 2, 7, 3), Element.Poison);
    public static Card Adamantoise = new Card(41, "Adamantoise", 4, new Rank(4, 5, 5, 6), Element.Earth);
    public static Card Hexadragon = new Card(42, "Hexadragon", 4, new Rank(7, 5, 4, 3), Element.Fire);
    #endregion

    #region level5
    public static Card IronGiant = new Card(43, "Iron Giant", 5, new Rank(6, 5, 6, 5));
    public static Card Behemoth = new Card(44, "Behemoth", 5, new Rank(3, 6, 5, 7));
    public static Card Chimera = new Card(45, "Chimera", 5, new Rank(7, 6, 5, 3), Element.Water);
    public static Card PuPu = new Card(46, "PuPu", 5, new Rank(3, 10, 2, 1));
    public static Card Elastoid = new Card(47, "Elastoid", 5, new Rank(6, 2, 6, 7));
    public static Card Gim47N = new Card(48, "GIM47N", 5, new Rank(5, 5, 7, 4));
    public static Card Malboro = new Card(49, "Malboro", 5, new Rank(7, 7, 4, 2), Element.Poison);
    public static Card RubyDragon = new Card(50, "Ruby Dragon", 5, new Rank(7, 2, 7, 4), Element.Fire);
    public static Card Elnoyle = new Card(51, "Elnoyle", 5, new Rank(5, 3, 7, 6));
    public static Card TonberryKing = new Card(52, "Tonberry King", 5, new Rank(4, 6, 7, 4));
    public static Card BiggsWedge = new Card(53, "Biggs, Wedge", 5, new Rank(6, 6, 2, 7));
    #endregion

    #region level6
    public static Card FujinRaijin = new Card(54, "Rujin, Raijin", 6, new Rank(2, 8, 8, 4));
    public static Card Elvoret = new Card(55, "Elvoret", 6, new Rank(7, 8, 3, 4), Element.Wind);
    public static Card XAtm092 = new Card(56, "X-ATM092", 6, new Rank(4, 8, 7, 3));
    public static Card Granaldo = new Card(57, "Granaldo", 6, new Rank(7, 2, 8, 5));
    public static Card Gerogero = new Card(58, "Gerogero", 6, new Rank(1, 8, 8, 3), Element.Poison);
    public static Card Iguion = new Card(59, "Iguion", 6, new Rank(8, 2, 8, 2));
    public static Card Abadon = new Card(60, "Abadon", 6, new Rank(6, 8, 4, 5));
    public static Card Trauma = new Card(61, "Trauma", 6, new Rank(4, 8, 5, 6));
    public static Card Oilboyle = new Card(62, "Oilboyle", 6, new Rank(1, 8, 4, 8));
    public static Card ShumiTribe = new Card(63, "Shumi Tribe", 6, new Rank(6, 5, 8, 4));
    public static Card Krysta = new Card(64, "Krysta", 6, new Rank(7, 5, 8, 1));
    #endregion

    #region level7
    public static Card Propagator = new Card(65, "Propagator", 7, new Rank(8, 4, 4, 8));
    public static Card JumboCactuar = new Card(66, "Jumbo Cactuar", 7, new Rank(8, 8, 4, 4));
    public static Card TriPoint = new Card(67, "Tri-Point", 7, new Rank(8, 5, 2, 8), Element.Lightning);
    public static Card Gargantua = new Card(68, "Gargantua", 7, new Rank(5, 6, 6, 8));
    public static Card MobileType8 = new Card(69, "Mobile Type 8", 7, new Rank(8, 6, 7, 3));
    public static Card Sphinxara = new Card(70, "Sphinxara", 7, new Rank(8, 3, 5, 8));
    public static Card Tiamat = new Card(71, "Tiamat", 7, new Rank(8, 8, 5, 4));
    public static Card Bgh251F2 = new Card(72, "BGH251F2", 7, new Rank(5, 7, 8, 5));
    public static Card RedGiant = new Card(73, "Red Giant", 7, new Rank(6, 8, 4, 7));
    public static Card Catoblepas = new Card(74, "Catoblepas", 7, new Rank(1, 8, 7, 7));
    public static Card UltimaWeapon = new Card(75, "Ultima Weapon", 7, new Rank(7, 7, 2, 8));
    #endregion

    #region level8
    public static Card ChubbyChocobo = new Card(76, "Chubby Chocobo", 8, new Rank(4, 4, 8, 9));
    public static Card Angelo = new Card(77, "Angelo", 8, new Rank(9, 6, 7, 3));
    public static Card Gilgamesh = new Card(78, "Gilgamesh", 8, new Rank(3, 7, 9, 6));
    public static Card MiniMog = new Card(79, "MiniMog", 8, new Rank(9, 3, 9, 2));
    public static Card Chicobo = new Card(80, "Chicobo", 8, new Rank(9, 4, 8, 4));
    public static Card Quezacotl = new Card(81, "Quezacotl", 8, new Rank(2, 9, 9, 4), Element.Lightning);
    public static Card Shiva = new Card(82, "Shiva", 8, new Rank(6, 7, 4, 9), Element.Ice);
    public static Card Ifrit = new Card(83, "Ifrit", 8, new Rank(9, 6, 2, 8), Element.Fire);
    public static Card Siren = new Card(84, "Siren", 8, new Rank(8, 9, 6, 2));
    public static Card Sacred = new Card(85, "Sacred", 8, new Rank(5, 1, 9, 9), Element.Earth);
    public static Card Minotaur = new Card(86, "Minotaur", 8, new Rank(9, 5, 2, 9), Element.Earth);
    #endregion

    #region level9
    public static Card Carbuncle = new Card(87, "Carbuncle", 9, new Rank(8, 4, 10, 4));
    public static Card Diablos = new Card(88, "Diablos", 9, new Rank(5, 10, 8, 3));
    public static Card Leviathan = new Card(89, "Leviathan", 9, new Rank(7, 10, 1, 7), Element.Water);
    public static Card Odin = new Card(90, "Odin", 9, new Rank(8, 10, 3, 5));
    public static Card Pandemona = new Card(91, "Pandemona", 9, new Rank(10, 1, 7, 7), Element.Wind);
    public static Card Cerberus = new Card(92, "Cerberus", 9, new Rank(7, 4, 6, 10));
    public static Card Alexander = new Card(93, "Alexander", 9, new Rank(9, 10, 4, 2), Element.Holy);
    public static Card Phoenix = new Card(94, "Phoenix", 9, new Rank(7, 2, 7, 10), Element.Fire);
    public static Card Bahamut = new Card(95, "Bahamut", 9, new Rank(10, 8, 2, 6));
    public static Card Doomtrain = new Card(96, "Doomtrain", 9, new Rank(3, 1, 10, 10), Element.Poison);
    public static Card Eden = new Card(97, "Eden", 9, new Rank(4, 4, 9, 10));
    #endregion

    #region level10
    public static Card Ward = new Card(98, "Ward", 10, new Rank(10, 7, 2, 8));
    public static Card Kiros = new Card(99, "Kiros", 10, new Rank(6, 7, 6, 10));
    public static Card Laguna = new Card(100, "Laguna", 10, new Rank(5, 10, 3, 9));
    public static Card Selphie = new Card(101, "Selphie", 10, new Rank(10, 8, 6, 4));
    public static Card Quistis = new Card(102, "Quistis", 10, new Rank(9, 6, 10, 2));
    public static Card Irvine = new Card(103, "Irvine", 10, new Rank(2, 6, 9, 10));
    public static Card Zell = new Card(104, "Zell", 10, new Rank(8, 5, 10, 6));
    public static Card Rinoa = new Card(105, "Rinoa", 10, new Rank(4, 10, 2, 10));
    public static Card Edea = new Card(106, "Edea", 10, new Rank(10, 10, 3, 3));
    public static Card Seifer = new Card(107, "Seifer", 10, new Rank(6, 9, 10, 4));
    public static Card Squall = new Card(108, "Squall", 10, new Rank(10, 4, 6, 9));
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

