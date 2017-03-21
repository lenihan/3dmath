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
using Windows.UI;
using System.Numerics;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _3dmath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            System.Diagnostics.Debug.WriteLine("TESTING!!!!!!!!");
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated += onAcceleratorKey;

            // TODO: Not sure which keyboard handler to use....ALT doesn't go to keyup/keydown.
            //       acceleratorKey catches alt...but doesn't behave same as keyup/keydown...more info.

        }

        private void onAcceleratorKey(CoreDispatcher sender, AcceleratorKeyEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine($"AccelKey: {args.VirtualKey.ToString()}");
        }

        private void CoreWindow_KeyUp(CoreWindow sender, KeyEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine($"KeyUp: {args.VirtualKey.ToString()}");
        }

        private void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine($"KeyDown: {args.VirtualKey.ToString()}");
        }

        private void canvas_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawText("Hello, World!", 100, 100, Colors.Black);
        }
    }
}
