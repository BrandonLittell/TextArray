using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using TextArrayController;

namespace TextArray
{
    public sealed partial class LightBoardView : UserControl
    {
        private TextArrayController.TextArrayController _textArrayController;

        public LightBoardView()
        {
            this.InitializeComponent();
            _textArrayController = new TextArrayController.TextArrayController(15, 5);
            _textArrayController.SetLetter(0, StringCharacter.UpperY);
            _textArrayController.SetLetter(6, StringCharacter.UpperO);
            UpdateLightsForArray(_textArrayController.LightArray);
        }

        private void UpdateLightsForArray(bool[] lightArray)
        {
            var array = ConvertArray(lightArray);

        }

        private bool[,] ConvertArray(bool[] oldArray)
        {
            bool[,] newArray = new bool[5, 15];
            var totalLights = 15 * 5;
            var x = 0;
            var y = 0;
            for (var i = 0; i < totalLights; i++)
            {
                x = i / 15;
                y = i % 15;
                newArray[x, y] = oldArray[i];

                var light = FindName(GetLightName(y, x)) as LightView;
                if(light != null)
                {
                    light.IsLightEnabled = oldArray[i];
                }
            }

            return newArray;
        }

        private string GetLightName(int x, int y)
        {
            var name = "Light_" + x + "_" + y;
            return name;
        }
    }
}
