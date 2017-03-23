using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI;
using Windows.UI.Core;
using System.Diagnostics;

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
            Debug.WriteLine("TESTING!!!!!!!!");
            Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated += onAcceleratorKey;

            // TODO: Not sure which keyboard handler to use....ALT doesn't go to keyup/keydown.
            //       acceleratorKey catches alt...but doesn't behave same as keyup/keydown...more info.

        }

        private void onAcceleratorKey(CoreDispatcher sender, AcceleratorKeyEventArgs args)
        {
            Debug.WriteLine($"AccelKey: {args.VirtualKey}, Event: {args.EventType}, IsExtendedKey: {args.KeyStatus.IsExtendedKey}, IsKeyReleased: {args.KeyStatus.IsKeyReleased}, IsMenuKeyDown: {args.KeyStatus.IsMenuKeyDown}, RepeatCount: {args.KeyStatus.IsMenuKeyDown}, ScanCode: {args.KeyStatus.ScanCode}, WasKeyDown: {args.KeyStatus.WasKeyDown}");
        }
          

        private void canvas_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawText("Hello, World!", 100, 100, Colors.Black);
        }
    }
}
