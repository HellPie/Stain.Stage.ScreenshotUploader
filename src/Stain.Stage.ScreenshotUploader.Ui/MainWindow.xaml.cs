using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stain.Stage.ScreenshotUploader.Ui {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Bitmap screenshot;
        string path;
        public MainWindow() {
            InitializeComponent();
        }

        private void newScreenshot_Click(object sender, RoutedEventArgs e) {
            screenshot = Screenshot.Screenshot.Capture();
            path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{Guid.NewGuid()}.jpg");
            screenshot.Save(path);
            ScreenshotPreview.Source = new BitmapImage(new Uri(path));
        }
    }
}
