using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI;
using Windows.UI.Core;
using System.Diagnostics;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _3dmath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool shiftDown = false;
        bool altDown = false;
        bool ctrlDown = false;
        public MainPage()
        {
            this.InitializeComponent();
            Debug.WriteLine("TESTING!!!!!!!!");
            Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated += OnAcceleratorKey;

            // TODO: Not sure which keyboard handler to use....ALT doesn't go to keyup/keydown.
            //       acceleratorKey catches alt...but doesn't behave same as keyup/keydown...more info.

        }

        private void OnAcceleratorKey(CoreDispatcher sender, AcceleratorKeyEventArgs args)
        {
            bool isKeyDown = !args.KeyStatus.IsKeyReleased;
            if (args.VirtualKey == VirtualKey.Shift)
            {
                shiftDown = isKeyDown;
            }
            else if (args.VirtualKey == VirtualKey.Menu)
            {
                altDown = isKeyDown;
            }
            else if (args.VirtualKey == VirtualKey.Control)
            {
                ctrlDown = isKeyDown;
            }
            else if (args.EventType == CoreAcceleratorKeyEventType.KeyDown ||
                     args.EventType == CoreAcceleratorKeyEventType.SystemKeyDown)
            {
                Debug.WriteLine($"AccelKey: {args.VirtualKey}, Event: {args.EventType}, shiftDown: {shiftDown},  ctrlDown: {ctrlDown},  altDown: {altDown}, IsExtendedKey: {args.KeyStatus.IsExtendedKey}, IsKeyReleased: {args.KeyStatus.IsKeyReleased}, IsMenuKeyDown: {args.KeyStatus.IsMenuKeyDown}, RepeatCount: {args.KeyStatus.IsMenuKeyDown}, ScanCode: {args.KeyStatus.ScanCode}, WasKeyDown: {args.KeyStatus.WasKeyDown}");
            }
        }
          

        private void Canvas_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawText("Hello, World!", 100, 100, Colors.Black);
        }
    }
}
