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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace practicemultifunzion
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=register;Integrated Security=True");
        public MainWindow()
        {
            InitializeComponent();

            // For Animation..........
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            RotateImg.RenderTransform = rt;
            RotateImg.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();   //Drag_Window
        }

        private void Feature_MouseEnter(object sender, MouseEventArgs e)
        {
            //Hidden options visible

            ImageConvert.Visibility = Visibility.Visible;
            SnapShot.Visibility = Visibility.Visible;
            NotePad.Visibility = Visibility.Visible;
            ImageSlider.Visibility = Visibility.Visible;
            Blank.Visibility = Visibility.Visible;

            //Foreground color set

            lb1.Foreground = Brushes.White;
            lb4.Foreground = Brushes.White;
            lb2.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;

            mnu_shortcut.Visibility = Visibility.Hidden;  //Visible menu hide
        }

        private void Notification_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide

            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown(); //Close project
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; //Minimize window
        }

        private void ImageConvert_Click(object sender, RoutedEventArgs e)
        {
            //open Image Convert
            ImageConvert a = new ImageConvert();
            a.Show();
            this.Close();
        }

        private void btn_about_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide

            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden;  //Visible menu hide
        }

        private void btn_exit2_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide

            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden;  //Visible menu hide

        }

        private void btn_exit_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide

            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_minimize_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide

            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_imgconvert_Click(object sender, RoutedEventArgs e)
        {
            //Open Image Convert
            ImageConvert a = new ImageConvert();
            a.Show();
            this.Close();
        }

        //Change Features Foreground Color  

        private void ImageConvert_MouseEnter(object sender, MouseEventArgs e)
        {
            lb1.Foreground = Brushes.Green;
            lb4.Foreground = Brushes.White;
            lb2.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;

        }

        private void SnapShot_MouseEnter(object sender, MouseEventArgs e)
        {
            lb2.Foreground = Brushes.Green;
            lb1.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;
            lb4.Foreground = Brushes.White;
        }

        private void NotePad_MouseEnter(object sender, MouseEventArgs e)
        {
            lb3.Foreground = Brushes.Green;
            lb2.Foreground = Brushes.White;
            lb1.Foreground = Brushes.White;
            lb4.Foreground = Brushes.White;
        }

        private void ImageSlider_MouseEnter(object sender, MouseEventArgs e)
        {
            lb4.Foreground = Brushes.Green;
            lb2.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;
            lb1.Foreground = Brushes.White;
        }

        private void BlankLable_MouseEnter(object sender, MouseEventArgs e)
        {
            lb1.Foreground = Brushes.White;
            lb2.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;
            lb4.Foreground = Brushes.White;
        }
        //
        private void btn_settings1_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Visible; //Visible menu hide
        }

        private void btn_SnapShot_Click(object sender, RoutedEventArgs e)
        {
            //Open Screen Capture
            SnapShot s = new SnapShot();
            s.Show();
            this.Close();
        }

        private void btn_NotePad_Click(object sender, RoutedEventArgs e)
        {
            //Open NotePad
            NotePad n = new NotePad();
            n.Show();
            this.Close();
        }

        private void btn_ImageSlide_Click(object sender, RoutedEventArgs e)
        {
            Image_slide img = new Image_slide();
            img.Show();
            this.Close();
        }

        private void btn_exit2_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown(); //Close project
        }

       

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
           if (txtblk_username.Text == "")
            {
                lbl_register.Visibility = Visibility.Visible;
                txt_email.Visibility = Visibility.Visible;
                txt_name.Visibility = Visibility.Visible;
                txt_phone.Visibility = Visibility.Visible;
                btn_submit.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_register.Visibility = Visibility.Hidden;
                txt_email.Visibility = Visibility.Hidden;
                txt_name.Visibility = Visibility.Hidden;
                txt_phone.Visibility = Visibility.Hidden;
                btn_submit.Visibility = Visibility.Hidden;
            }
            //Registration Form
            //lbl_register.Visibility = Visibility.Visible;
            //txt_email.Visibility = Visibility.Visible;
            //txt_name.Visibility = Visibility.Visible;
           // txt_phone.Visibility = Visibility.Visible;
           // btn_submit.Visibility = Visibility.Visible;
        }



        private void NotePad_Click(object sender, RoutedEventArgs e)
        {
            //Open NotePad
            NotePad n = new NotePad();
            n.Show();
            this.Close();
        }

        private void btn_NotePad_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void SnapShot_Click(object sender, RoutedEventArgs e)
        {
            //Open Screen_Capture
            SnapShot s = new SnapShot();
            s.Show();
            this.Close();
        }
        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            //Set data in registration TextBlock
           // sql.Open();

           // SqlCommand cmd = new SqlCommand("INSERT INTO register(name,email,phone) VALUES('" + txt_name.Text + "','" + txt_email.Text + "' ,'" + txt_phone.Text + "')", sql);
           // cmd.ExecuteNonQuery();

            // MessageBox.Show("Registration Complete");
           // Registration r = new Registration();
           // r.Show();
           // this.Close();
           // lbl_register.Visibility = Visibility.Hidden;

          //  sql.Close();
        }

        private void active_windows(object sender, RoutedEventArgs e)
        {
            if (txtblk_username.Text != "")
            {
               // btn_register.Visibility = Visibility.Hidden;
            }
            else
            {
               // btn_register.IsEnabled = false;
                // btn_register.Visibility = Visibility.Hidden;
            }
            show();
        }

        void show()
        {
           // sql.Open();
           // SqlCommand cmd1 = new SqlCommand("SELECT * FROM register", sql);
            //SqlDataReader read = cmd1.ExecuteReader();
           // while (read.Read())
           // {
                // p = read[0].ToString();
             //   txtblk_username.Text = read[0].ToString() + "\n" + read[1].ToString() + "\n" + read[2].ToString();

            //}

            //sql.Close();
        }

        private void btn_register_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            //Reset Registration

            txt_name.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            lbl_register.Visibility = Visibility.Hidden;
        }

        private void btn_home_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            //Open About
            About a = new About();
            a.Show();
            this.Close();
        }

        private void btn_folder_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        //Menu Item Checked then visible features

        private void mnu_imgConvert_Checked_1(object sender, RoutedEventArgs e)
        {
            btn_imgconvert.Visibility = Visibility.Visible;
        }

        private void mnu_ScreenCapture_Checked_1(object sender, RoutedEventArgs e)
        {
            btn_SnapShot.Visibility = Visibility.Visible;
        }

        private void mnu_NotePad_Checked(object sender, RoutedEventArgs e)
        {
            btn_NotePad.Visibility = Visibility.Visible;
        }

        private void mnu_ImageSlide_Checked(object sender, RoutedEventArgs e)
        {
            btn_ImageSlide.Visibility = Visibility.Visible;
        }

        //Menu Item UnChecked then visible features

        private void mnu_imgConvert_UnChecked(object sender, RoutedEventArgs e)
        {
            btn_imgconvert.Visibility = Visibility.Hidden;
        }

        private void mnu_ScreenCapture_UnChecked(object sender, RoutedEventArgs e)
        {
            btn_SnapShot.Visibility = Visibility.Hidden;
        }

        private void mnu_NotePad_UnChecked(object sender, RoutedEventArgs e)
        {
            btn_NotePad.Visibility = Visibility.Hidden;
        }

        private void mnu_ImageSlide_UnChecked(object sender, RoutedEventArgs e)
        {
            btn_ImageSlide.Visibility = Visibility.Hidden;
        }


        private void txt_features_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            //Features Foreground color set

            lb1.Foreground = Brushes.White;
            lb4.Foreground = Brushes.White;
            lb2.Foreground = Brushes.White;
            lb3.Foreground = Brushes.White;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_SnapShot_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_ImageSlide_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void btn_imgconvert_MouseEnter(object sender, MouseEventArgs e)
        {
            //Visible features options Hide
            ImageConvert.Visibility = Visibility.Hidden;
            SnapShot.Visibility = Visibility.Hidden;
            NotePad.Visibility = Visibility.Hidden;
            ImageSlider.Visibility = Visibility.Hidden;
            Blank.Visibility = Visibility.Hidden;

            mnu_shortcut.Visibility = Visibility.Hidden; //Visible menu hide
        }

        private void ImageSlider_Click(object sender, RoutedEventArgs e)
        {
            Image_slide img = new Image_slide();
            img.Show();
            this.Close();
        }
    }
}
