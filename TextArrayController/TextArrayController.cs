using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TextArrayController
{
    public sealed class TextArrayController
    {
        private uint _lineWidth;
        private uint _lineHeight;
        private uint _lightCount;

        public string Message { get; set; }

        private bool[] _lightArray;

        public TextArrayController(uint width, uint height)
        {
            _lineWidth = width;
            // TODO: Revert hard-coding
            // Setting here to ensure proper character look
            _lineHeight = 5;
            _lightCount = _lineWidth * _lineHeight;
            _lightArray = new bool[_lightCount];
        }

        private int GetIndexForPosition(int x, int y)
        {
            return GetIndexForPosition(x, y, (int) _lineHeight, (int)_lineWidth);
        }

        private int GetIndexForPosition(int x, int y, int arrayWidth, int arrayHeight)
        {
            var rowJump = y * arrayHeight;
            var index = (int)rowJump + x;

            // Catch overflow
            if (index >= (arrayWidth * arrayHeight))
            {
                index = -1;
            }

            return index;
        }

        private bool GetLightState(int x, int y)
        {
            var index = GetIndexForPosition(x, y);
            return (index >= 0) ? _lightArray[index] : false;
        }

        public void SetLight(int x, int y, bool value)
        {
            var index = GetIndexForPosition(x, y);
            if (index >= 0)
            {
                _lightArray[index] = value;
            }
        }

        public void SetLetter(int xPos, StringCharacter letter)
        {
            var charString = CharacterFactory.GetCharacterString(letter);
            var charLights = CharStringToArray(charString);

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    var charIndex = GetIndexForPosition(x, y, 5, 5);
                    if(charIndex >= 0)
                    {
                        var value = charLights[charIndex];
                        SetLight(x + xPos, y, value);
                    }
                }
            }
        }

        // TODO: Rewrite this function.
        // Hyper hardcoded at the moment
        private bool[] CharStringToArray(string charString)
        {
            // 5*5 = 25
            var charArray = new bool[25];
            var stringIndex = 0;

            for(int y = 0; y < 5; y++)
            {
                for(int x = 0; x < 5; x++)
                {
                    var index = GetIndexForPosition(x, y, 5, 5);

                    if(index >= 0)
                    {
                        charArray[index] = charString.Substring(stringIndex, 1).Equals("0") ? true : false;
                        ++stringIndex;
                    }
                }
            }

            return charArray;
        }

        public void DebugPrintArray()
        {
            string output = "";
            // For each row
            for (uint y = 0; y < _lineHeight; y++)
            {
                // Print every column
                for (uint x = 0; x < _lineWidth; x++)
                {
                    output += GetLightState((int)x, (int)y) ? "0" : " ";
                }

                output += '\n';
            }

            Debug.Write(output);
        }
    }
}
