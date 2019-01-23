using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Drawing;
using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Animation;

namespace practicemultifunzion
{
    /// <summary>
    /// Interaction logic for ImageConvert.xaml
    /// </summary>
    public partial class ImageConvert : Window
    {
        public ImageConvert()
        {
            InitializeComponent();
            
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            RotateImg.RenderTransform = rt;
            RotateImg.RenderTransformOrigin = new System.Windows.Point(0.5, .5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }
        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
     private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
       {
            DragMove();
       }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        private void loadimage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select Image";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true && op.FileName.Length > 0)
            {
               pictureBox1.Image = new Bitmap(op.FileName);
                saveimage.IsEnabled = true;
               
            }
        }

        private void saveimage_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"E:\";
            save.Filter = "JPeg Image|*.jpg|Png Image|*.png";

            if (save.ShowDialog() == true && save.FileName.Length > 0)
            {
                pictureBox1.Image.Save(save.FileName);
              // MessageBox.Show("Image saved");
               ImageSave a = new ImageSave();
               a.Show();
               this.Close();
            }
        }

        private void btn_helpimgconvert_Click(object sender, RoutedEventArgs e)
        {
            Class1.help = txt_Help.Text;

            Help h = new Help();
            h.Show();
            this.Close();

        }

        private void btn_exit2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.Show();
            this.Close();
        }
    }
}
