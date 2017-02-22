using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextArrayController
{
    public enum StringCharacter 
    {
        UpperA = 0,
        UpperB,
        UpperC,
        UpperD,
        UpperE,
        UpperF,
        UpperG,
        UpperH,
        UpperI,
        UpperJ,
        UpperK,
        UpperL,
        UpperM,
        UpperN,
        UpperO,
        UpperP,
        UpperQ,
        UpperR,
        UpperS,
        UpperT,
        UpperU,
        UpperV,
        UpperW,
        UpperX,
        UpperY,
        UpperZ
    };

    public static class CharacterFactory
    {
        private const string UpperA = "  0  " +
                                      " 0 0 " +
                                      " 000 " +
                                      "0   0" +
                                      "0   0";

        private const string UpperB = "000  " +
                                      "0  0 " +
                                      "0000 " +
                                      "0   0" +
                                      "0000 ";

        private const string UpperC = " 0000" +
                                      "0    " +
                                      "0    " +
                                      "0    " +
                                      " 0000";

        private const string UpperD = "0000 " +
                                      "0   0" +
                                      "0   0" +
                                      "0   0" +
                                      "0000 ";

        private const string UpperE = "00000" +
                                      "0    " +
                                      "000  " +
                                      "0    " +
                                      "00000";

        private const string UpperF = "00000" +
                                      "0    " +
                                      "000  " +
                                      "0    " +
                                      "0    ";

        private const string UpperG = " 0000" +
                                      "0    " +
                                      "0 000" +
                                      "0   0" +
                                      " 0000";

        private const string UpperH = "0   0" +
                                      "0   0" +
                                      "00000" +
                                      "0   0" +
                                      "0   0";

        private const string UpperI = "00000" +
                                      "  0  " +
                                      "  0  " +
                                      "  0  " +
                                      "00000";

        private const string UpperJ = "  000" +
                                      "    0" +
                                      "    0" +
                                      "0   0" +
                                      " 000 ";

        private const string UpperK = "0  0 " +
                                      "0 0  " +
                                      "000  " +
                                      "0  0 " +
                                      "0   0";

        private const string UpperL = "0    " +
                                      "0    " +
                                      "0    " +
                                      "0    " +
                                      "00000";

        private const string UpperM = "0   0" +
                                      "00 00" +
                                      "0 0 0" +
                                      "0   0" +
                                      "0   0";

        private const string UpperN = "0   0" +
                                      "00  0" +
                                      "0 0 0" +
                                      "0  00" +
                                      "0   0";

        private const string UpperO = " 000 " +
                                      "0   0" +
                                      "0   0" +
                                      "0   0" +
                                      " 000 ";

        private const string UpperP = "0000 " +
                                      "0   0" +
                                      "0000 " +
                                      "0    " +
                                      "0    ";

        private const string UpperQ = " 000 " +
                                      "0   0" +
                                      "0   0" +
                                      "0  0 " +
                                      " 00 0";

        private const string UpperR = "0000 " +
                                      "0   0" +
                                      "0000 " +
                                      "0  0 " +
                                      "0   0";

        private const string UpperS = " 000 " +
                                      "0    " +
                                      " 000 " +
                                      "    0" +
                                      " 000 ";

        private const string UpperT = "00000" +
                                      "  0  " +
                                      "  0  " +
                                      "  0  " +
                                      "  0  ";

        private const string UpperU = "0   0" +
                                      "0   0" +
                                      "0   0" +
                                      "0   0" +
                                      " 000 ";

        private const string UpperV = "0   0" +
                                      "0   0" +
                                      "0   0" +
                                      " 0 0 " +
                                      "  0  ";

        private const string UpperW = "0   0" +
                                      "0   0" +
                                      "0 0 0" +
                                      "00 00" +
                                      "0   0";

        private const string UpperX = "0   0" +
                                      " 0 0 " +
                                      "  0  " +
                                      " 0 0 " +
                                      "0   0";

        private const string UpperY = "0   0" +
                                      " 0 0 " +
                                      "  0  " +
                                      "  0  " +
                                      "  0  ";

        private const string UpperZ = "00000" +
                                      "   0 " +
                                      "  0  " +
                                      " 0   " +
                                      "00000";

        private static string[] HeightSixCharacters =
        {
            UpperA,
            UpperB,
            UpperC,
            UpperD,
            UpperE,
            UpperF,
            UpperG,
            UpperH,
            UpperI,
            UpperJ,
            UpperK,
            UpperL,
            UpperM,
            UpperN,
            UpperO,
            UpperP,
            UpperQ,
            UpperR,
            UpperS,
            UpperT,
            UpperU,
            UpperV,
            UpperW,
            UpperX,
            UpperY,
            UpperZ
        };

        public static string GetCharacterString(StringCharacter character)
        {
            return HeightSixCharacters[(int)character];
        }
    }
}
