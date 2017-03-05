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

namespace TextArray
{
    public sealed partial class LightView : UserControl
    {
        public LightView()
        {
            this.InitializeComponent();
        }

        private bool _isLightEnabled;
        public bool IsLightEnabled
        {
            get { return _isLightEnabled; }
            set
            {
                // TODO: Swap to binding for cleaner code
                if (_isLightEnabled != value)
                {
                    _isLightEnabled = value;
                    OffEllipse.Visibility = value ? Visibility.Collapsed : Visibility.Visible;
                    OnEllipse.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }

        // TODO: Future expansion
        //private Windows.UI.Color _color;
    }
}
