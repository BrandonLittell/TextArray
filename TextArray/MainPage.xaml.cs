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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var textArrayController = new TextArrayController.TextArrayController(5, 10);
            textArrayController.SetLight(0, 0, true);
            textArrayController.SetLight(1, 1, true);
            textArrayController.SetLight(2, 2, true);
            textArrayController.SetLight(3, 3, true);
            textArrayController.SetLight(4, 4, true);
            textArrayController.SetLight(2, 0, true);
            textArrayController.DebugPrintArray();
        }
    }
}
