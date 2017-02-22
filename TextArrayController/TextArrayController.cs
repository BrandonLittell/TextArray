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
            _lineHeight = height;
            _lightCount = _lineWidth * _lineHeight;
            _lightArray = new bool[_lightCount];
        }

        private int GetIndexForPosition(int x, int y)
        {
            var rowJump = y * _lineHeight;
            var index = (int)rowJump + x;

            // Catch overflow
            if(index >= (_lineWidth * _lineHeight))
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

        public void SetLetter(int xPos)
        {

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
