﻿using System.Linq;

namespace PKHeX.Core
{
    public static partial class Legal
    {
        internal const int MaxSpeciesID_7 = 802;
        internal const int MaxMoveID_7 = 720;
        internal const int MaxItemID_7 = 920;
        internal const int MaxAbilityID_7 = 232;
        internal const int MaxBallID_7 = 0x1A; // 26
        internal const int MaxGameID_7 = 41; // Crystal (VC?)

        #region Met Locations

        internal static readonly int[] Met_SMc = { 0, 60002, 30002, };

        internal static readonly int[] Met_SM_0 =
        {
            002, 004, // Invalid
            006, 008, 010, 012, 014, 016, 018, 020, 022, 024, 026, 028, 030, 032, 034, 036, 038, 040, 042, 044, 046, 048,
            050, 052, 054, 056, 058, 060, 062, 064, 066, 068, 070, 072, 074, 076, 078, 082, 084, 086, 088, 090, 092, 094,
            100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 132, 134, 136, 138, 140, 142, 144, 146, 148,
            150, 152, 154, 156, 158, 160, 162, 164, 166, 168, 170, 172, 174, 176, 178, 180, 182, 184, 186, 188, 190, 192
        };

        internal static readonly int[] Met_SM_3 =
        {
            30001, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013, 30014, 30015, 30016,
        };

        internal static readonly int[] Met_SM_4 =
        {
            40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010,
            40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021, 40022, 40023, 40024, 40025,
            40026, 40027, 40028, 40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038, 40039, 40040,
            40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048, 40049, 40050, 40051, 40052, 40053, 40054, 40055,
            40056, 40057, 40058, 40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068, 40069, 40070,
            40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078, 40079,

            40080, 40081, 40082, 40083, 40084, 40085, 40086, 40087, 40088,
        };

        internal static readonly int[] Met_SM_6 = {/* XY */ 60001, 60003, /* ORAS */ 60004, };

        #endregion

        internal static readonly ushort[] Pouch_Regular_SM = // 00
        {
            068, 069, 070, 071, 072, 073, 074, 075, 076, 077, 078, 079, 080, 081, 082, 083, 084, 085, 086, 087,
            088, 089, 090, 091, 092, 093, 094, 099, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111,
            112, 116, 117, 118, 119, 135, 136, 137, 213, 214, 215, 217, 218, 219, 220, 221, 222, 223, 224, 225,
            226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245,
            246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265,
            266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285,
            286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305,
            306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325,
            326, 327, 499, 534, 535, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551,
            552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 571, 572, 573, 580, 581, 582, 583,
            584, 585, 586, 587, 588, 589, 590, 639, 640, 644,      646, 647, 648, 649, 650, 656, 657, 658, 659,
            660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677, 678, 679,
            680, 681, 682, 683, 684, 685, 699, 704, 710, 711, 715, 752, 753, 754, 755, 756, 757, 758, 759, 760,
            761, 762, 763, 764, 767, 768, 769, 770, 795, 796, 844, 849, 853, 854, 855, 856, 879, 880, 881, 882,
            883, 884, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920,
        };
        internal static readonly ushort[] Pouch_Ball_SM = { // 08
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 492, 493, 494, 495, 496, 497, 498, 576,
            851
        };
        internal static readonly ushort[] Pouch_Battle_SM = { // 16
            55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 577,
            846,
        };
        internal static readonly ushort[] Pouch_Items_SM = Pouch_Regular_SM.Concat(Pouch_Ball_SM).Concat(Pouch_Battle_SM).ToArray();
        
        internal static readonly ushort[] Pouch_Key_SM = {
            216, 465, 466, 628, 629, 631, 632, 633, 638, 696,
            705, 706, 765, 773, 797,
            841, 842, 843, 845, 847, 850, 857, 858, 860,
        };
        internal static readonly ushort[] Pouch_TMHM_SM = { // 02
            328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345,
            346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363,
            364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381,
            382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399,
            400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417,
            418, 419, 618, 619, 620, 690, 691, 692, 693, 694,
        };
        internal static readonly ushort[] Pouch_Medicine_SM = { // 32
            17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 65, 66, 67, 134,
            504, 565, 566, 567, 568, 569, 570, 591, 645, 708, 709,
            852,
        };
        internal static readonly ushort[] Pouch_Berries_SM = {
            149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212,
            686, 687, 688,
        };
        internal static readonly ushort[] Pouch_ZCrystal_SM = { // Bead
            807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835,
        };
        internal static readonly ushort[] Pouch_ZCrystalHeld_SM = { // Piece
            776, 777, 778, 779, 780, 781, 782, 783, 784, 785, 786, 787, 788, 789, 790, 791, 792, 793, 794, 798, 799, 800, 801, 802, 803, 804, 805, 806, 836
        };
        internal static readonly ushort[] HeldItems_SM = new ushort[1].Concat(Pouch_Items_SM).Concat(Pouch_Berries_SM).Concat(Pouch_Medicine_SM).Concat(Pouch_ZCrystalHeld_SM).ToArray();

        private static readonly int[] WildPokeballs7 = {
            0x01, 0x02, 0x03, 0x04, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
            0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, // Johto Balls
            0x1A, // Beast
        };
        internal static readonly int[] AlolanOriginForms =
        {
            019, // Rattata
            020, // Raticate
            027, // Sandshrew
            028, // Sandslash
            037, // Vulpix
            038, // Ninetails
            050, // Diglett
            051, // Dugtrio
            052, // Meowth
            053, // Persian
            074, // Geodude
            075, // Graveler
            076, // Golem
            088, // Grimer
            089, // Muk
        };
        internal static readonly int[] EvolveToAlolanForms = new[]
        {
            026, // Raichu
            103, // Exeggutor
            105, // Marowak
        }.Concat(AlolanOriginForms).ToArray();

        public static readonly int[] PastGenAlolanNatives =
        {
            010, 011, 012, 019, 020, 021, 022, 025, 026, 027, 028, 035, 036, 037, 038, 039, 040, 041, 042, 046, 047, 050,
            051, 052, 053, 054, 055, 056, 057, 058, 059, 060, 061, 062, 063, 064, 065, 066, 067, 068, 072, 073, 074, 075,
            076, 079, 080, 081, 082, 088, 089, 090, 091, 092, 093, 094, 096, 097, 102, 103, 104, 105, 113, 115, 118, 119,
            120, 121, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 142, 143, 147, 148, 149, 165,
            166, 167, 168, 169, 170, 171, 172, 173, 174, 185, 186, 196, 197, 198, 199, 200, 209, 210, 212, 215, 222, 225,
            227, 233, 235, 239, 240, 241, 242, 278, 279, 283, 284, 296, 297, 299, 302, 318, 319, 320, 321, 324, 327, 328,
            329, 330, 339, 340, 349, 350, 351, 359, 361, 362, 369, 370, 371, 372, 373, 374, 375, 376, 408, 409, 410, 411,
            422, 423, 425, 426, 429, 430, 438, 440, 443, 444, 445, 446, 447, 448, 456, 457, 461, 462, 466, 467, 470, 471,
            474, 476, 478, 506, 507, 508, 524, 525, 526, 546, 547, 548, 549, 551, 552, 553, 564, 565, 566, 567, 568, 569,
            582, 583, 584, 587, 594, 627, 628, 629, 630, 661, 662, 663, 674, 675, 700, 703, 704, 705, 706, 707, 708, 709,
            718
        };
        public static readonly int[] PastGenAlolanNativesUncapturable =
        {
            142, // Aerodacyl
            137, 233, 474 // Porygon++
        };

        internal static readonly int[] PastGenAlolanScans =
        {
            069, // Bellsprout
            111, // Rhyhorn
            116, // Horsea
            152, // Chikorita
            155, // Cyndaquil
            158, // Totodile
            220, // Swinub
            363, // Spheal
            543, // Venipede
            574, // Gothita
            599, // Klink
            607, // Litwick
            610, // Axew
            633, // Deino
            679, // Honedge

            183, 298, // Marill {Azurill}
            315, 406, // Roselia {Budew}

            175, // [468] Togekiss (Togepi)
            287, // [288] Vigoroth (Slakoth)
            396, // [397] Staravia (Starly)
            403, // [404] Luxio (Shinx)
            495, // [497] Serperior (Snivy)
            577, // [578] Duosion (Solosis)

            498, // [500] Emboar (Tepig)
            501, // [503] Samurott (Oshawott)
            532, // [534] Conkeldurr (Timburr)
            540, // [542] Leavanny (Sewaddle)
            602, // [604] Eelektross (Tynamo)
        };
        internal static readonly int[] Inherit_Apricorn6 =
        {
            010, 013, 016, 019, 021, 023, 025, 027, 029, 035, 037, 039, 041,
            043, 046, 048, 050, 052, 054, 056, 058, 060, 063, 066, 069, 072, 074, 077, 079, 083, 084, 086, 088, 090, 092,
            095, 096, 098, 102, 104, 108, 109, 111, 113, 114, 115, 116, 118, 122, 124, 125, 126, 129, 131, 143, 147, 161,
            163, 165, 167, 170, 177, 179, 183, 185, 187, 190, 191, 193, 194, 198, 200, 202, 203, 204, 206, 207, 209, 211,
            213, 214, 215, 216, 218, 220, 222, 223, 225, 226, 227, 228, 231, 234, 235, 241, 246, 261, 263, 265, 273, 276,
            278, 280, 285, 287, 293, 296, 302, 303, 307, 311, 312, 316, 322, 325, 327, 333, 339, 359, 366, 369, 370, 396,
            399, 401, 403, 406, 412, 415, 418, 420, 427, 433, 441, 455,

            032, // Via Nidoran-F

            440, // Via Chansey
            238, // Via Jynx
            239, // Via Electabuzz
            240, // Via Magmar
            298, // Via Marill
            360, // Via Wobbuffet
            438, // Via Sudowoodo
            439, // Via Mr. Mime
            446, // Via Snorlax
            458, // Via Mantine
            358, // Via Chingling
            172, // Via Pikachu
            173, // Via Clefairy
            174, // Via Jigglypuff
        };
        internal static readonly int[] AlolanCaptureOffspring =
        {
            010, 019, 021, 025, 027, 035, 037, 039, 041, 046,
            050, 052, 054, 056, 058, 060, 063, 066, 072, 074,
            079, 081, 088, 090, 092, 096, 102, 104, 113, 115,
            118, 120, 123, 127, 128, 129, 131, 132, 133, 143,
            147, 165, 167, 170, 172, 173, 174, 185, 198, 200,
            209, 212, 215, 222, 225, 227, 235, 239, 240, 241,
            278, 283, 296, 299, 302, 318, 320, 324, 327, 328,
            339, 349, 351, 359, 361, 369, 370, 371, 374, 422,
            425, 438, 440, 443, 446, 447, 456, 506, 524, 546,
            548, 551, 568, 582, 587, 594, 627, 629, 661, 674,
            703, 704, 707, 708,

            731, 734, 736, 739, 741, 742, 744, 746, 747, 749,
            751, 753, 755, 757, 759, 761, 764, 765, 766, 767,
            769, 771, 774, 775, 776, 777, 778, 779, 780, 781,
            782
        };
        internal static readonly int[] AlolanCaptureNoHeavyBall = {374, 785, 786, 787, 788}; // Beldum & Tapus
        internal static readonly int[] Inherit_ApricornMale7 =
        {
            100, // Voltorb
            343, // Baltoy
            436, // Bronzor

            // Others are capturable in the Alola region
            // Magnemite, Staryu, Tauros
        };
        internal static readonly int[] Inherit_Apricorn7 = Inherit_Apricorn6.Concat(Inherit_ApricornMale7).Concat(PastGenAlolanScans).Concat(AlolanCaptureOffspring).Distinct().ToArray();
        internal static readonly int[] Inherit_SafariMale =
        {
            128, // Tauros

            081, // Magnemite
            100, // Voltorb
            337, // Lunatone
            338, // Solrock
            374, // Beldum
            436, // Bronzor
        };
        internal static readonly int[] Inherit_DreamMale =
        {
            // Starting with Gen7, Males pass Ball via breeding with Ditto.
            001, 004, 007, // Gen1 Starters
            025, // Pikachu
            128, // Tauros
            172, // Pichu
            236, // Tyrogue (100% Male)
            252, 255, 258, // Gen2 Starters
            387, 390, 393, // Gen3 Starters
            511, 513, 515, // Gen5 Monkeys
            538, // Throh
            539, // Sawk
            574, // Gothita

            081, // Magnemite
            100, // Voltorb
            120, // Staryu
            137, // Porygon
            337, // Lunatone
            338, // Solrock
            343, // Baltoy
            374, // Beldum
            436, // Bronzor
            479, // Rotom
            599, // Klink
            622, // Golett
        };
        internal static readonly int[] Ban_Gen3Ball_7 =
        {
            566, 567, 696, 697, 698, 699 // Fossil Only obtain
        };
        internal static readonly int[] Ban_Gen4Ball_7 =
        {
            566, 567, 696, 697, 698, 699 // Fossil Only obtain
        };
        internal static readonly int[] Ban_SafariBallHidden_7 =
        {
            029, 030, 031, 032, 033, 034, // Nidos
            313, 314, // Volbeat/Illumise
        };

        internal static readonly int[] ZygardeMoves =
        {
            245, // Extreme Speed
            349, // Dragon Dance
            614, // Thousand Arrows
            615, // Thousand Waves
            687, // Core Enforcer
        };

        internal static readonly int[] EggLocations7 = {60002, 30002};
        internal static readonly int[] ValidMet_SM =
        {
            006, 008, 010, 012, 014, 016, 018, 020, 022, 024, 026, 028, 030, 032, 034, 036, 038, 040, 042, 044, 046, 048,
            050, 052, 054, 056, 058, 060, 062, 064, 066, 068, 070, 072, 074, 076, 078, 082, 084, 086, 088, 090, 092, 094,
            100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 132, 134, 136, 138, 140, 142, 144, 146, 148,
            150, 152, 154, 156, 158, 160, 162, 164, 166, 168, 170, 172, 174, 176, 178, 180, 182, 184, 186, 188, 190, 192,

            30016 // Poké Pelago
        };

        private static readonly int[] TMHM_SM =
        {
            526, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 355, 219,
            218, 076, 479, 085, 087, 089, 216, 141, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            211, 411, 412, 206, 503, 374, 451, 507, 693, 511,
            261, 512, 373, 153, 421, 371, 684, 416, 397, 694,
            444, 521, 086, 360, 014, 019, 244, 523, 524, 157,
            404, 525, 611, 398, 138, 447, 207, 214, 369, 164,
            430, 433, 528, 057, 555, 267, 399, 127, 605, 590,

            // No HMs
        };

        internal static readonly int[] MovePP_SM =
        {
            00,
            35, 25, 10, 15, 20, 20, 15, 15, 15, 35, 30, 05, 10, 20, 30, 35, 35, 20, 15, 20, 20, 25, 20, 30, 05, 10, 15, 15, 15, 25, 20, 05, 35, 15, 20, 20, 10, 15, 30, 35, 20, 20, 30, 25, 40, 20, 15, 20, 20, 20,
            30, 25, 15, 30, 25, 05, 15, 10, 05, 20, 20, 20, 05, 35, 20, 20, 20, 20, 20, 15, 25, 15, 10, 20, 25, 10, 35, 30, 15, 10, 40, 10, 15, 30, 15, 20, 10, 15, 10, 05, 10, 10, 25, 10, 20, 40, 30, 30, 20, 20,
            15, 10, 40, 15, 10, 30, 10, 20, 10, 40, 40, 20, 30, 30, 20, 30, 10, 10, 20, 05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 10, 15, 35, 20, 15, 10, 10, 30, 15, 40, 20, 10, 10, 05, 10, 30, 10, 15, 20, 15, 40,
            20, 10, 05, 15, 10, 10, 10, 15, 30, 30, 10, 10, 20, 10, 01, 01, 10, 25, 10, 05, 15, 25, 15, 10, 15, 30, 05, 40, 15, 10, 25, 10, 30, 10, 20, 10, 10, 10, 10, 10, 20, 05, 40, 05, 05, 15, 05, 10, 05, 10,
            10, 10, 10, 20, 20, 40, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25, 20, 05, 30, 05, 10, 20, 40, 05, 20, 40, 20, 15, 35, 10, 05, 05, 05, 15, 05, 20, 05, 05, 15, 20, 10, 05, 05, 15, 10, 15, 15,
            10, 10, 10, 20, 10, 10, 10, 10, 15, 15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10, 15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10, 15,
            20, 15, 10, 10, 15, 10, 05, 05, 10, 15, 10, 05, 20, 25, 05, 40, 15, 05, 40, 15, 20, 20, 05, 15, 20, 20, 15, 15, 05, 10, 30, 20, 30, 15, 05, 40, 15, 05, 20, 05, 15, 25, 25, 15, 20, 15, 20, 15, 20, 10,
            20, 20, 05, 05, 10, 05, 40, 10, 10, 05, 10, 10, 15, 10, 20, 15, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10, 10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 15, 10, 20, 20, 20, 15, 15,
            10, 15, 15, 15, 10, 10, 10, 20, 10, 30, 05, 10, 15, 10, 10, 05, 20, 30, 10, 30, 15, 15, 15, 15, 30, 10, 20, 15, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05, 20, 05, 15, 20, 05, 20, 20, 20, 20, 10, 20,
            10, 15, 20, 15, 10, 10, 05, 10, 05, 05, 10, 05, 05, 10, 05, 05, 05, 15, 10, 10, 10, 10, 10, 10, 15, 20, 15, 10, 15, 10, 15, 10, 20, 10, 10, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15, 10,
            15, 15, 15, 15, 10, 10, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10, 10, 20, 20, 20, 10, 10, 30, 15, 15, 10, 15, 25, 10, 15, 10, 10, 10, 20, 10, 10, 10, 10, 10, 15, 15, 05, 05, 10, 10, 10, 05,
            05, 10, 05, 05, 15, 10, 05, 05, 05, 10, 10, 10, 10, 20, 25, 10, 20, 30, 25, 20, 20, 15, 20, 15, 20, 20, 10, 10, 10, 10, 10, 20, 10, 30, 15, 10, 10, 10, 20, 20, 05, 05, 05, 20, 10, 10, 20, 15, 20, 20,
            10, 20, 30, 10, 10, 40, 40, 30, 20, 40, 20, 20, 10, 10, 10, 10, 05, 10, 10, 05, 05, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01,
            01, 01, 01, 01, 01, 01, 01, 01, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 40, 15, 20, 30, 20, 15, 15, 20, 10, 15, 15, 10, 05, 10, 10, 20, 15, 10, 15, 15, 15, 05, 15, 20, 20, 01, 01, 01, 01, 01, 01,
            01, 01, 01, 05, 05, 10, 10, 10, 20, 10, 10, 10, 05, 05, 20, 10, 10, 10, 01
        };

        internal static readonly int[] Ban_NoHidden7 =
        {
            // Summon only other Pokemon
            765, // Oranguru
            766, // Passimian

            // SOS slots have 0 call rate
            767, // Wimpod
            768, // Golisopod

            // No Encounter
            722, // Rowlet
            723, // Dartrix
            724, // Decidueye
            725, // Litten
            726, // Torracat
            727, // Incineroar
            728, // Popplio
            729, // Brionne
            730, // Primarina
            774, // Minior

            //Pre-Gen
            669 + (2 << 11), //Flabébé-Orange
            670 + (2 << 11), //Floette-Orange
            671 + (2 << 11), //Florges-Orange
            669 + (4 << 11), //Flabébé-White
            670 + (4 << 11), //Floette-White
            671 + (4 << 11), //Florges-White

            710 + (1 << 11), //Pumpkaboo-Small
            711 + (1 << 11), //Gourgeist-Small
            710 + (2 << 11), //Pumpkaboo-Large
            711 + (2 << 11), //Gourgeist-Large
        };
        #region Pre-Bank Illegality
        internal static readonly int[] Bank_NoHidden7 =
        {
            // Gifts
            137, // Porygon
            233, // Porygon2
            474, // Porygon-Z
            
            // No SOS slots
            142, // Aerodactyl
            408, // Cranidos
            409, // Rampardos
            410, // Shieldon
            411, // Bastiodon
            564, // Tirtouga
            565, // Carracosta
            566, // Archen
            567, // Archeops

            // Island Scan
            069, // Bellsprout
            070, // Weepinbell
            071, // Victreebel
            111, // Rhyhorn
            112, // Rhydon
            464, // Rhyperior
            116, // Horsea
            117, // Seadra
            230, // Kingdra
            152, // Chikorita
            153, // Bayleef
            154, // Meganium
            155, // Cyndaquil
            156, // Quilava
            157, // Typhlosion
            158, // Totodile
            159, // Croconaw
            160, // Feraligatr
            175, // Togepi
            176, // Togetic
            468, // Togekiss
            183, // Marill
            184, // Azumarill
            220, // Swinub
            221, // Piloswine
            287, // Slakoth
            288, // Vigoroth
            289, // Slaking
            473, // Mamoswine
            298, // Azurill
            363, // Spheal
            364, // Sealeo
            365, // Walrein
            396, // Starly
            397, // Staravia
            398, // Staraptor
            403, // Shinx
            404, // Luxio
            405, // Luxray
            406, // Budew
            407, // Roserade
            315, // Roselia
            495, // Snivy
            496, // Servine
            497, // Serperior
            498, // Tepig
            499, // Pignite
            500, // Emboar
            501, // Oshawott
            502, // Dewott
            503, // Samurott
            532, // Timburr
            533, // Gurdurr
            534, // Conkeldurr
            540, // Sewaddle
            541, // Swadloon
            542, // Leavanny
            543, // Venipede
            544, // Whirlipede
            545, // Scolipede
            574, // Gothita
            575, // Gothorita
            576, // Gothitelle
            577, // Solosis
            578, // Duosion
            579, // Reuniclus
            599, // Klink
            600, // Klang
            601, // Klinklang
            602, // Tynamo
            603, // Eelektrik
            604, // Eelektross
            607, // Litwick
            608, // Lampent
            609, // Chandelure
            610, // Axew
            611, // Fraxure
            612, // Haxorus
            633, // Deino
            634, // Zweilous
            635, // Hydreigon
            679, // Honedge
            680, // Doublade
            681, // Aegislash
        };
        internal static readonly int[] Bank_NotAvailable7 = // Unobtainable Species
        {
            001, // Bulbasaur
            002, // Ivysaur
            003, // Venusaur
            004, // Charmander
            005, // Charmeleon
            006, // Charizard
            007, // Squirtle
            008, // Wartortle
            009, // Blastoise
            013, // Weedle
            014, // Kakuna
            015, // Beedrill
            016, // Pidgey
            017, // Pidgeotto
            018, // Pidgeot
            023, // Ekans
            024, // Arbok
            026, // Raichu
            029, // Nidoran♀
            030, // Nidorina
            031, // Nidoqueen
            032, // Nidoran♂
            033, // Nidorino
            034, // Nidoking
            043, // Oddish
            044, // Gloom
            045, // Vileplume
            048, // Venonat
            049, // Venomoth
            077, // Ponyta
            078, // Rapidash
            083, // Farfetch'd
            084, // Doduo
            085, // Dodrio
            086, // Seel
            087, // Dewgong
            095, // Onix
            098, // Krabby
            099, // Kingler
            100, // Voltorb
            101, // Electrode
            103, // Exeggutor
            105, // Marowak
            106, // Hitmonlee
            107, // Hitmonchan
            108, // Lickitung
            109, // Koffing
            110, // Weezing
            114, // Tangela
            122, // Mr. Mime
            124, // Jynx
            138, // Omanyte
            139, // Omastar
            140, // Kabuto
            141, // Kabutops
            144, // Articuno
            145, // Zapdos
            146, // Moltres
            150, // Mewtwo
            151, // Mew
            161, // Sentret
            162, // Furret
            163, // Hoothoot
            164, // Noctowl
            177, // Natu
            178, // Xatu
            179, // Mareep
            180, // Flaaffy
            181, // Ampharos
            182, // Bellossom
            187, // Hoppip
            188, // Skiploom
            189, // Jumpluff
            190, // Aipom
            191, // Sunkern
            192, // Sunflora
            193, // Yanma
            194, // Wooper
            195, // Quagsire
            201, // Unown
            202, // Wobbuffet
            203, // Girafarig
            204, // Pineco
            205, // Forretress
            206, // Dunsparce
            207, // Gligar
            208, // Steelix
            211, // Qwilfish
            213, // Shuckle
            214, // Heracross
            216, // Teddiursa
            217, // Ursaring
            218, // Slugma
            219, // Magcargo
            223, // Remoraid
            224, // Octillery
            226, // Mantine
            228, // Houndour
            229, // Houndoom
            231, // Phanpy
            232, // Donphan
            234, // Stantler
            236, // Tyrogue
            237, // Hitmontop
            238, // Smoochum
            243, // Raikou
            244, // Entei
            245, // Suicune
            246, // Larvitar
            247, // Pupitar
            248, // Tyranitar
            249, // Lugia
            250, // Ho-Oh
            251, // Celebi
            252, // Treecko
            253, // Grovyle
            254, // Sceptile
            255, // Torchic
            256, // Combusken
            257, // Blaziken
            258, // Mudkip
            259, // Marshtomp
            260, // Swampert
            261, // Poochyena
            262, // Mightyena
            263, // Zigzagoon
            264, // Linoone
            265, // Wurmple
            266, // Silcoon
            267, // Beautifly
            268, // Cascoon
            269, // Dustox
            270, // Lotad
            271, // Lombre
            272, // Ludicolo
            273, // Seedot
            274, // Nuzleaf
            275, // Shiftry
            276, // Taillow
            277, // Swellow
            280, // Ralts
            281, // Kirlia
            282, // Gardevoir
            285, // Shroomish
            286, // Breloom
            290, // Nincada
            291, // Ninjask
            292, // Shedinja
            293, // Whismur
            294, // Loudred
            295, // Exploud
            300, // Skitty
            301, // Delcatty
            303, // Mawile
            304, // Aron
            305, // Lairon
            306, // Aggron
            307, // Meditite
            308, // Medicham
            309, // Electrike
            310, // Manectric
            311, // Plusle
            312, // Minun
            313, // Volbeat
            314, // Illumise
            316, // Gulpin
            317, // Swalot
            322, // Numel
            323, // Camerupt
            325, // Spoink
            326, // Grumpig
            331, // Cacnea
            332, // Cacturne
            333, // Swablu
            334, // Altaria
            335, // Zangoose
            336, // Seviper
            337, // Lunatone
            338, // Solrock
            341, // Corphish
            342, // Crawdaunt
            343, // Baltoy
            344, // Claydol
            345, // Lileep
            346, // Cradily
            347, // Anorith
            348, // Armaldo
            352, // Kecleon
            353, // Shuppet
            354, // Banette
            355, // Duskull
            356, // Dusclops
            357, // Tropius
            358, // Chimecho
            360, // Wynaut
            366, // Clamperl
            367, // Huntail
            368, // Gorebyss
            377, // Regirock
            378, // Regice
            379, // Registeel
            380, // Latias
            381, // Latios
            382, // Kyogre
            383, // Groudon
            384, // Rayquaza
            385, // Jirachi
            386, // Deoxys
            387, // Turtwig
            388, // Grotle
            389, // Torterra
            390, // Chimchar
            391, // Monferno
            392, // Infernape
            393, // Piplup
            394, // Prinplup
            395, // Empoleon
            399, // Bidoof
            400, // Bibarel
            401, // Kricketot
            402, // Kricketune
            412, // Burmy
            413, // Wormadam
            414, // Mothim
            415, // Combee
            416, // Vespiquen
            417, // Pachirisu
            418, // Buizel
            419, // Floatzel
            420, // Cherubi
            421, // Cherrim
            424, // Ambipom
            427, // Buneary
            428, // Lopunny
            431, // Glameow
            432, // Purugly
            433, // Chingling
            434, // Stunky
            435, // Skuntank
            436, // Bronzor
            437, // Bronzong
            439, // Mime Jr.
            441, // Chatot
            442, // Spiritomb
            449, // Hippopotas
            450, // Hippowdon
            451, // Skorupi
            452, // Drapion
            453, // Croagunk
            454, // Toxicroak
            455, // Carnivine
            458, // Mantyke
            459, // Snover
            460, // Abomasnow
            463, // Lickilicky
            465, // Tangrowth
            469, // Yanmega
            472, // Gliscor
            475, // Gallade
            477, // Dusknoir
            479, // Rotom
            480, // Uxie
            481, // Mesprit
            482, // Azelf
            483, // Dialga
            484, // Palkia
            485, // Heatran
            486, // Regigigas
            487, // Giratina
            488, // Cresselia
            489, // Phione
            490, // Manaphy
            491, // Darkrai
            492, // Shaymin
            493, // Arceus
            494, // Victini
            504, // Patrat
            505, // Watchog
            509, // Purrloin
            510, // Liepard
            511, // Pansage
            512, // Simisage
            513, // Pansear
            514, // Simisear
            515, // Panpour
            516, // Simipour
            517, // Munna
            518, // Musharna
            519, // Pidove
            520, // Tranquill
            521, // Unfezant
            522, // Blitzle
            523, // Zebstrika
            527, // Woobat
            528, // Swoobat
            529, // Drilbur
            530, // Excadrill
            531, // Audino
            535, // Tympole
            536, // Palpitoad
            537, // Seismitoad
            538, // Throh
            539, // Sawk
            550, // Basculin
            554, // Darumaka
            555, // Darmanitan
            556, // Maractus
            557, // Dwebble
            558, // Crustle
            559, // Scraggy
            560, // Scrafty
            561, // Sigilyph
            562, // Yamask
            563, // Cofagrigus
            570, // Zorua
            571, // Zoroark
            572, // Minccino
            573, // Cinccino
            580, // Ducklett
            581, // Swanna
            585, // Deerling
            586, // Sawsbuck
            588, // Karrablast
            589, // Escavalier
            590, // Foongus
            591, // Amoonguss
            592, // Frillish
            593, // Jellicent
            595, // Joltik
            596, // Galvantula
            597, // Ferroseed
            598, // Ferrothorn
            605, // Elgyem
            606, // Beheeyem
            613, // Cubchoo
            614, // Beartic
            615, // Cryogonal
            616, // Shelmet
            617, // Accelgor
            618, // Stunfisk
            619, // Mienfoo
            620, // Mienshao
            621, // Druddigon
            622, // Golett
            623, // Golurk
            624, // Pawniard
            625, // Bisharp
            626, // Bouffalant
            631, // Heatmor
            632, // Durant
            636, // Larvesta
            637, // Volcarona
            638, // Cobalion
            639, // Terrakion
            640, // Virizion
            641, // Tornadus
            642, // Thundurus
            643, // Reshiram
            644, // Zekrom
            645, // Landorus
            646, // Kyurem
            647, // Keldeo
            648, // Meloetta
            649, // Genesect
            650, // Chespin
            651, // Quilladin
            652, // Chesnaught
            653, // Fennekin
            654, // Braixen
            655, // Delphox
            656, // Froakie
            657, // Frogadier
            658, // Greninja
            659, // Bunnelby
            660, // Diggersby
            664, // Scatterbug
            665, // Spewpa
            666, // Vivillon
            667, // Litleo
            668, // Pyroar
            669, // Flabébé
            670, // Floette
            671, // Florges
            672, // Skiddo
            673, // Gogoat
            676, // Furfrou
            677, // Espurr
            678, // Meowstic
            682, // Spritzee
            683, // Aromatisse
            684, // Swirlix
            685, // Slurpuff
            686, // Inkay
            687, // Malamar
            688, // Binacle
            689, // Barbaracle
            690, // Skrelp
            691, // Dragalge
            692, // Clauncher
            693, // Clawitzer
            694, // Helioptile
            695, // Heliolisk
            696, // Tyrunt
            697, // Tyrantrum
            698, // Amaura
            699, // Aurorus
            701, // Hawlucha
            702, // Dedenne
            710, // Pumpkaboo
            711, // Gourgeist
            712, // Bergmite
            713, // Avalugg
            714, // Noibat
            715, // Noivern
            716, // Xerneas
            717, // Yveltal
            719, // Diancie
            720, // Hoopa
            721, // Volcanion
        };
        internal static readonly EncounterStatic[] Bank_Egg7 = // Unobtainable Egg Moves
        {
            // Regular

            new EncounterStatic { Species = 722, Relearn = new[] {466,174}},                // Rowlet: Ominous Wind, Curse
            new EncounterStatic { Species = 731, Relearn = new[] {586,253}},                // Pikipek: Boomburst, Uproar
            new EncounterStatic { Species = 165, Relearn = new[] {227,282,264,409,146}},    // Ledyba: Encore, Knock Off, Focus Punch, Drain Punch, Dizzy Punch
            new EncounterStatic { Species = 167, Relearn = new[] {50,324,527}},             // Spinarak: Disable, Signal Beam, Electroweb
            new EncounterStatic { Species = 736, Relearn = new[] {527}},                    // Grubbin: Electroweb
            new EncounterStatic { Species = 185, Relearn = new[] {328,174,203}},            // Sudowoodo: Sand Tomb, Curse, Endure
            new EncounterStatic { Species = 440, Relearn = new[] {426,68,69}},              // Happiny: Mud Bomb, Counter, Seismic Toss
            new EncounterStatic { Species = 143, Relearn = new[] {120,495,18,204,562}},     // Snorlax: Self-Destruct, After You, Whirlwind, Charm, Belch
            new EncounterStatic { Species = 446, Relearn = new[] {120,495,18,204,562}},     // Munchlax: Self-Destruct, After You, Whirlwind, Charm, Belch
            new EncounterStatic { Species = 079, Relearn = new[] {562}},                    // Slowpoke: Belch
            new EncounterStatic { Species = 278, Relearn = new[] {282}},                    // Wingull: Knock Off
            new EncounterStatic { Species = 063, Relearn = new[] {112,379,385,285,8,375}},  // Abra: Barrier, Power Trick, Guard Swap, Skill Swap, Ice Punch, Psycho Shift
            new EncounterStatic { Species = 052, Relearn = new[] {274}},                    // Meowth: Assist
            new EncounterStatic { Species = 088, Form = 1, Relearn = new[] {184,228,372}},  // Grimer1: Scary Face, Pursuit, Assurance
            new EncounterStatic { Species = 088, Relearn = new[] {184}},                    // Grimer: Scary Face
            new EncounterStatic { Species = 096, Relearn = new[] {112,274,385,290,285,8}},  // Drowzee: Barrier, Assist, Guard Swap, Secret Power, Skill Swap, Ice Punch
            new EncounterStatic { Species = 296, Relearn = new[] {270}},                    // Makuhita: Helping Hand
            new EncounterStatic { Species = 739, Relearn = new[] {276}},                    // Crabrawler: Superpower
            new EncounterStatic { Species = 092, Relearn = new[] {114,184,513,9,8,7}},      // Gastly: Haze, Scary Face, Reflect Type, Thunder Punch, Ice Punch, Fire Punch
            new EncounterStatic { Species = 425, Relearn = new[] {366,432,114}},            // Drifloon: Tailwind, Defog, Haze
            new EncounterStatic { Species = 200, Relearn = new[] {382,417}},                // Misdreavus: Me First, Nasty Plot
            new EncounterStatic { Species = 041, Relearn = new[] {599,202,428,95,174}},     // Zubat: Venom Drench, Giga Drain, Zen Headbutt, Hypnosis, Curse
            new EncounterStatic { Species = 021, Relearn = new[] {161}},                    // Spearow: Tri Attack
            new EncounterStatic { Species = 629, Relearn = new[] {282,313}},                // Vullaby: Knock Off, Fake Tears
            new EncounterStatic { Species = 742, Relearn = new[] {285}},                    // Cutiefly: Skill Swap
            new EncounterStatic { Species = 548, Relearn = new[] {361,117}},                // Petilil: Healing Wish, Bide
            new EncounterStatic { Species = 546, Relearn = new[] {262,251,415}},            // Cottonee: Memento, Beat Up, Switcheroo
            new EncounterStatic { Species = 066, Relearn = new[] {27,8,379}},               // Machop: Rolling Kick, Ice Punch, Power Trick
            new EncounterStatic { Species = 524, Relearn = new[] {222,174}},                // Roggenrola: Magnitude, Curse
            new EncounterStatic { Species = 302, Relearn = new[] {236,445,368,286}},        // Sableye: Moonlight, Captivate, Metal Burst, Imprison
            new EncounterStatic { Species = 327, Relearn = new[] {274,375}},                // Spinda: Assist, Psycho Shift
            new EncounterStatic { Species = 072, Relearn = new[] {229,114,282,367,330,321}},// Tentacool: Rapid Spin, Haze, Knock Off, Acupressure, Muddy Water, Tickle
            new EncounterStatic { Species = 456, Relearn = new[] {62,60}},                  // Finneon: Aurora Beam, Psybeam
            new EncounterStatic { Species = 370, Relearn = new[] {494}},                    // Luvdisc: Entrainment
            new EncounterStatic { Species = 222, Relearn = new[] {275,267,293}},            // Corsola: Ingrain, Nature Power, Camoflage
            new EncounterStatic { Species = 090, Relearn = new[] {41,341,229,36}},          // Shellder: Twineedle, Mud Shot, Rapid Spin, Take Down
            new EncounterStatic { Species = 371, Relearn = new[] {111}},                    // Bagon: Defense Curl
            new EncounterStatic { Species = 174, Relearn = new[] {445,386,581,505,343} },   // Igglybuff: Captivate, Punishment, Misty Terrain, Heal Pulse, Covet
            new EncounterStatic { Species = 283, Relearn = new[] {471}},                    // Surskit: Power Split
            new EncounterStatic { Species = 751, Relearn = new[] {471}},                    // Dewpider: Power Split
            new EncounterStatic { Species = 753, Relearn = new[] {432}},                    // Fomantis: Defog
            new EncounterStatic { Species = 755, Relearn = new[] {133}},                    // Morelull: Amnesia
            new EncounterStatic { Species = 046, Relearn = new[] {563}},                    // Paras: Rototiller
            new EncounterStatic { Species = 060, Relearn = new[] {283}},                    // Poliwag: Endeavor
            new EncounterStatic { Species = 118, Relearn = new[] {114,60}},                 // Goldeen: Haze, Psybeam
            new EncounterStatic { Species = 661, Relearn = new[] {289}},                    // Fletchling: Snatch
            new EncounterStatic { Species = 757, Relearn = new[] {562,282,289,252}},        // Salandit: Belch, Knock Off, Snatch, Fake Out
            new EncounterStatic { Species = 104, Relearn = new[] {24,197}},                 // Cubone: Double Kick, Detect
            new EncounterStatic { Species = 115, Relearn = new[] {264,253,509}},            // Kangaskhan: Focus Punch, Uproar, Circle Throw
            new EncounterStatic { Species = 126, Relearn = new[] {562,384,231,394,183,112,5}},// Magmar: Belch, Power Swap, Iron Tail, Flare Blitz, Mach Punch, Barrier, Mega Punch
            new EncounterStatic { Species = 761, Relearn = new[] {364,367}},                // Bounsweet: Feint, Acupressure
            new EncounterStatic { Species = 764, Relearn = new[] {495,381,133}},            // Comfey: After You, Lucky Chant, Amnesia
            new EncounterStatic { Species = 127, Relearn = new[] {382}},                    // Pinsir: Me First
            new EncounterStatic { Species = 704, Relearn = new[] {151,174,342,68}},         // Goomy: Acid Armor, Curse, Poison Tail, Counter
            new EncounterStatic { Species = 351, Relearn = new[] {513,385}},                // Castform: Reflect Type, Guard Swap
            new EncounterStatic { Species = 769, Relearn = new[] {246}},                    // Sandygast: Ancient Power
            new EncounterStatic { Species = 408, Relearn = new[] {18,21}},                  // Cranidos: Whirlwind, Slam
            new EncounterStatic { Species = 410, Relearn = new[] {469,446}},                // Shieldon: Wide Guard, Stealth Rock
            new EncounterStatic { Species = 566, Relearn = new[] {282,415,502}},            // Archen: Knock Off, Switcheroo, Ally Switch
            new EncounterStatic { Species = 564, Relearn = new[] {282,385}},                // Tirtouga: Knock Off, Guard Swap
            new EncounterStatic { Species = 170, Relearn = new[] {60,351}},                 // Chinchou: Psybeam, Shock Wave
            new EncounterStatic { Species = 568, Relearn = new[] {114,174}},                // Trubbish: Haze, Curse
            new EncounterStatic { Species = 227, Relearn = new[] {203,446,385,174} },       // Skarmory: Endure, Stealth Rock, Guard Swap, Curse
            new EncounterStatic { Species = 173, Relearn = new[] {505,581,343,150}},        // Cleffa: Heal Pulse, Misty Terrain, Covet, Splash
            new EncounterStatic { Species = 776, Relearn = new[] {469,279,83}},             // Turtonator: Wide Guard, Revenge, Fire Spin
            new EncounterStatic { Species = 239, Relearn = new[] {8,27,112}},               // Elekid: Ice Punch, Rolling Kick, Barrier
            new EncounterStatic { Species = 074, Relearn = new[] {203,103,431,264,174}},    // Geodude: Endure, Screech, Rock Climb, Focus Punch, Curse
            new EncounterStatic { Species = 707, Relearn = new[] {415}},                    // Klefki: Switcheroo
            new EncounterStatic { Species = 780, Relearn = new[] {583,13}},                 // Drampa: Play Rough, Razor Wind
            new EncounterStatic { Species = 361, Relearn = new[] {415}},                    // Snorunt: Switcheroo
            new EncounterStatic { Species = 215, Relearn = new[] {274}},                    // Sneasel: Assist
            new EncounterStatic { Species = 037, Relearn = new[] {541,290}},                // Vulpix: Tail Slap, Secret Power
            new EncounterStatic { Species = 582, Relearn = new[] {352,363}},                // Vanillite: Water Pulse, Natural Gift
            new EncounterStatic { Species = 422, Relearn = new[] {124}},                    // Shellos: Sludge
            new EncounterStatic { Species = 131, Relearn = new[] {419}},                    // Lapras: Avalanche
            new EncounterStatic { Species = 102, Relearn = new[] {335,285,384,381,267,246}},// Exeggcute: Block, Skill Swap, Power Swap, Lucky Chant, Nature Power, Ancient Power
            new EncounterStatic { Species = 123, Relearn = new[] {211,501,432,179,68}},     // Scyther: Steel Wing, Quick Guard, Defog, Reversal, Counter
            new EncounterStatic { Species = 198, Relearn = new[] {375,260,195}},            // Murkrow: Psycho Shift, Flatter, Perish Song
            new EncounterStatic { Species = 447, Relearn = new[] {299}},                    // Riolu: Blaze Kick
            new EncounterStatic { Species = 147, Relearn = new[] {245}},                    // Dratini: Extreme Speed
            new EncounterStatic { Species = 142, Relearn = new[] {174}},                    // Aerodactyl: Curse
            
            // Island Scan

            new EncounterStatic {Species = 069, Relearn = new[] {562, 438, 499}},           // Bellsprout: Belch, Power Whip, Clear Smog
            new EncounterStatic {Species = 158, Relearn = new[] {313, 260}},                // Totodile: Fake Tears, Flatter
            new EncounterStatic {Species = 183, Relearn = new[] {293, 383}},                // Marill: Camouflage, Copycat
            new EncounterStatic {Species = 298, Relearn = new[] {293, 383}},                // Azurill: Camouflage, Copycat
            new EncounterStatic {Species = 116, Relearn = new[] {13, 190}},                 // Horsea: Razor Wind, Octazooka
            new EncounterStatic {Species = 406, Relearn = new[] {170}},                     // Budew: Mind Reader 
            new EncounterStatic {Species = 315, Relearn = new[] {170}},                     // Roselia: Mind Reader 
            new EncounterStatic {Species = 396, Relearn = new[] {279, 197}},                // Starly: Revenge, Detect
            new EncounterStatic {Species = 175, Relearn = new[] {375, 234, 290, 326}},      // Togepi: Psycho Shift, Morning Sun, Secret Power, Extrasensory
            new EncounterStatic {Species = 577, Relearn = new[] {271, 290, 270}},           // Solosis: Trick, Secret Power, Helping Hand
            new EncounterStatic {Species = 607, Relearn = new[] {257, 114, 203, 445, 471}}, // Litwick: Heat Wave, Haze, Endure, Captivate, Power Split
            new EncounterStatic {Species = 543, Relearn = new[] {36}},                      // Venipede: Take Down 
            new EncounterStatic {Species = 532, Relearn = new[] {183}},                     // Timburr: Mach Punch 
            new EncounterStatic {Species = 574, Relearn = new[] {243, 445}},                // Gothita: Mirror Coat, Captivate
            new EncounterStatic {Species = 540, Relearn = new[] {170, 293}},                // Sewaddle: Mind Reader, Camouflage
            new EncounterStatic {Species = 633, Relearn = new[] {310, 414}},                // Deino: Astonish, Earth Power
        };
        internal static readonly int[] Bank_Sketch7 = // Unobtainable Sketch Moves prior to Bank making moves available.
        {
            367, // Acupressure
            177, // Aeroblast
            274, // Assist
            454, // Attack Order
            299, // Blaze Kick
            551, // Blue Flare
            550, // Bolt Strike
            464, // Dark Void
            455, // Defend Order
            591, // Diamond Storm
            353, // Doom Desire
            582, // Electrify
            552, // Fiery Dance
            560, // Flying Press
            559, // Fusion Bolt
            558, // Fusion Flare
            601, // Geomancy
            549, // Glaciate
            543, // Head Charge
            456, // Heal Order
            607, // Hold Hands
            593, // Hyperspace Hole
            621, // Hyperspace Fury
            617, // Light of Ruin
            461, // Lunar Dance
            295, // Luster Purge
            463, // Magma Storm
            296, // Mist Ball
            302, // Needle Arm
            613, // Oblivion Wing
            190, // Octazooka
            618, // Origin Pulse
            570, // Parabolic Charge
            600, // Powder
            619, // Precipice Blades
            354, // Psycho Boost
            375, // Psycho Shift
            540, // Psystrike
            547, // Relic Song
            459, // Roar of Time
            027, // Rolling Kick
            221, // Sacred Fire
            545, // Searing Shot
            290, // Secret Power
            548, // Secret Sword
            465, // Seed Flare
            467, // Shadow Force
            493, // Simple Beam
            460, // Spacial Rend
            592, // Steam Eruption
            541, // Tail Slap
            546, // Techno Blast
            576, // Topsy-Turvy
            567, // Trick-or-Treat
            557, // V-create
        };

        #endregion

        #region Unreleased Items
        internal static readonly int[] UnreleasedHeldItems_7 =
        {
            005, // Safari Ball
            016, // Cherish Ball
            064, // Fluffy Tail
            065, // Blue Flute
            066, // Yellow Flute
            067, // Red Flute
            068, // Black Flute
            069, // White Flute
            070, // Shoal Salt
            071, // Shoal Shell
            099, // Root Fossil
            100, // Claw Fossil
            101, // Helix Fossil
            102, // Dome Fossil
            103, // Old Amber
            111, // Odd Keystone
            164, // Razz Berry
            166, // Nanab Berry
            167, // Wepear Berry
            175, // Cornn Berry
            176, // Magost Berry
            177, // Rabuta Berry
            178, // Nomel Berry
            179, // Spelon Berry
            180, // Pamtre Berry
            181, // Watmel Berry
            182, // Durin Berry
            183, // Belue Berry
            208, // Enigma Berry
            209, // Micle Berry
            210, // Custap Berry
            211, // Jaboca Berry
            212, // Rowap Berry
            215, // Macho Brace
            260, // Red Scarf
            261, // Blue Scarf
            262, // Pink Scarf
            263, // Green Scarf
            264, // Yellow Scarf
            548, // Fire Gem
            549, // Water Gem
            550, // Electric Gem
            551, // Grass Gem
            552, // Ice Gem
            553, // Fighting Gem
            554, // Poison Gem
            555, // Ground Gem
            556, // Flying Gem
            557, // Psychic Gem
            558, // Bug Gem
            559, // Rock Gem
            560, // Ghost Gem
            561, // Dragon Gem
            562, // Dark Gem
            563, // Steel Gem
            576, // Dream Ball
            584, // Relic Copper
            585, // Relic Silver
            586, // Relic Gold
            587, // Relic Vase
            588, // Relic Band
            589, // Relic Statue
            590, // Relic Crown
            710, // Jaw Fossil
            711, // Sail Fossil
            715, // Fairy Gem
        };
        #endregion
        internal static readonly bool[] ReleasedHeldItems_7 = Enumerable.Range(0, MaxItemID_7+1).Select(i => HeldItems_SM.Contains((ushort)i) && !UnreleasedHeldItems_7.Contains(i)).ToArray();
    }
}
