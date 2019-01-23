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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Forms;

using System.IO;
using System.Windows.Media.Animation;
namespace practicemultifunzion
{
    /// <summary>
    /// Interaction logic for Image_slide.xaml
    /// </summary>
    public partial class Image_slide : Window
    {
        Timer time = new Timer();
        private string[] folderFile = null;
        private int selected = 0;
        private int begin = 0;
        private int end = 0;
        public Image_slide()
        {
            InitializeComponent();

            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            RotateImg.RenderTransform = rt;
            RotateImg.RenderTransformOrigin = new System.Windows.Point(0.5, .5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);

           // Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(timer1_Tick);
           // time.Start();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void btn_imgslide_stop_click(object sender, RoutedEventArgs e)
        {
            if (time.Enabled == true)
            {
                time.Enabled = false;
            }
            else
            {
                time.Enabled = true;

            }
        }

        private void btn_pre_click(object sender, RoutedEventArgs e)
        {
            prevImage();
        }
        private void prevImage()
        {
            if (selected == 0)
            {
                selected = folderFile.Length - 1;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1; showImage(folderFile[selected]);
            }
        }

        private void nextImage()
        {
            if (selected == folderFile.Length - 1)
            {
                selected = 0;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1; showImage(folderFile[selected]);
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            nextImage();
        }

        private void btn_open_click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result.ToString() == "OK")
            {
                string[] part1 = null, part2 = null, part3 = null;
                part1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                part2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpeg");
                part3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bmp");
                folderFile = new string[part1.Length + part2.Length + part3.Length];
                Array.Copy(part1, 0, folderFile, 0, part1.Length);
                Array.Copy(part2, 0, folderFile, part1.Length, part2.Length);
                Array.Copy(part3, 0, folderFile, part1.Length + part2.Length, part3.Length);
                selected = 0;
                begin = 0;
                end = folderFile.Length;
                showImage(folderFile[selected]);
                btn_next.IsEnabled = true;
                btn_pre.IsEnabled = true;
                btn_imgslide_stop.IsEnabled = true;

            }
        }

        private void showImage(string p)
        {
            System.Drawing.Image imgtemp = System.Drawing.Image.FromFile(p);
            pictureBox1.Width = imgtemp.Width / 2;
            pictureBox1.Height = imgtemp.Height / 2;
            pictureBox1.Image = imgtemp;

        }

        private void btn_next_click(object sender, RoutedEventArgs e)
        {
            nextImage();
        }

        private void load_window(object sender, RoutedEventArgs e)
        {
            btn_next.IsEnabled = false;
            btn_pre.IsEnabled = false;
            btn_imgslide_stop.IsEnabled = false;
        }

        private void btn_slide_exit_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btn_helpImageSlide(object sender, RoutedEventArgs e)
        {
            Class1.help = txt_Help.Text;

            Help h = new Help();
            h.Show();
            this.Close();
        }
    }
}
