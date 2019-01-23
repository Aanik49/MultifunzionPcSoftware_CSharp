using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace practicemultifunzion
{
    /// <summary>
    /// Interaction logic for NotePad.xaml
    /// </summary>
    public partial class NotePad : Window
    {
        string activeFileName = null;
        string activeFilePath = null;

        public NotePad()
        {
            InitializeComponent();

            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            RotateImg.RenderTransform = rt;
            RotateImg.RenderTransformOrigin = new System.Windows.Point(0.5, .5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void New()
        {
            txtDocument.Text = "";
            activeFileName = "Untitled";
            activeFilePath = null;
            UpdateTitle();
        }

        private void Open()
        {
            // Configure dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = activeFileName; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                activeFilePath = dlg.FileName;
                activeFileName = new FileInfo(activeFilePath).Name;
                using (TextReader tr = new StreamReader(activeFilePath))
                {
                    txtDocument.Text = tr.ReadToEnd();
                }
                UpdateTitle();
            }
        }

        private void Save()
        {
            if (String.IsNullOrEmpty(activeFilePath))
            {
                // File has never been saved, must prompt for name
                SaveAs();
            }
            else
            {
                // Save document
                using (TextWriter tr = new StreamWriter(activeFilePath))
                {
                    tr.Write(txtDocument.Text);
                }
            }
        }

        private void SaveAs()
        {
            // Configure dialog box
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = activeFileName; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Save document
                activeFilePath = dlg.FileName;
                using (TextWriter tr = new StreamWriter(activeFilePath))
                {
                    tr.Write(txtDocument.Text);
                }
                UpdateTitle();
            }
        }

        private void MenuHandler_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            switch (item.Name)
            {
                case "NewMenu":
                    New();
                    break;

                case "OpenMenu":
                    Open();
                    break;

                case "SaveMenu":
                    Save();
                    break;

                case "SaveAsMenu":
                    SaveAs();
                    break;

            }
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateStatus();
        }

        private void txtDocument_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateTitle()
        {
            window1.Title = activeFileName + " - " + "Notepad";
        }

        /// <summary>
        /// Updates the status bar text.
        /// </summary>
        private void UpdateStatus()
        {
            int caret = txtDocument.CaretIndex;
            int row = txtDocument.GetLineIndexFromCharacterIndex(caret);
            int col = caret - txtDocument.GetFirstVisibleLineIndex();
            statusBar.Text = String.Format("Ln {0}, Col {1}", row, col);
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

        private void btn_file_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Visible;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void txtDocument_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Hidden;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void btn_Edit_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_edit.Visibility = Visibility.Visible;
            mnu_file.Visibility = Visibility.Hidden;
        }

        private void btn_About_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Hidden;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void btn_exit2_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Hidden;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void btn_Help_MouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Hidden;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            Class1.help = txt_Help.Text;

            Help h = new Help();
            h.Show();
            this.Close();
        }

        private void btn_exit2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow h = new MainWindow();
            h.Show();
            this.Close();
        }

        private void btn_home_mouseEnter(object sender, MouseEventArgs e)
        {
            mnu_file.Visibility = Visibility.Hidden;
            mnu_edit.Visibility = Visibility.Hidden;
        }

        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.Show();
            this.Close();
        }
    }
}
