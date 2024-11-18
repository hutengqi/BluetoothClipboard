using System;

using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Scighost.WinUILib.Helpers;
using Windows.Graphics;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BluetoothClipboard
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private IntPtr windowHandle;

        private AppWindow appWindow;

        private SystemBackdrop systemBackdrop;

        public MainWindow()
        {
            this.InitializeComponent();

            windowHandle = WindowNative.GetWindowHandle(this);
            WindowId id = Win32Interop.GetWindowIdFromWindow(windowHandle);
            appWindow = AppWindow.GetFromWindowId(id);

            appWindow.Resize(new SizeInt32(450,800));

            systemBackdrop = new SystemBackdrop(this);
            systemBackdrop.TrySetMica(fallbackToAcrylic: true);
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            bluetoothDeviceList.Visibility = Visibility.Visible ;
        }
    }
}
