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
using System.Media;
namespace educationalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).Opacity = 0.3;
            string name = ((Image)sender).Name;
            string path = $"{Environment.CurrentDirectory}\\audio\\{name}.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Load();
            soundPlayer.Play();
        }
        private void symbol_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Image)sender).Opacity = 0.6;
        }

        private void symbol_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Image)sender).Opacity = 1;
        }

        private void symbol_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).Opacity = 0.6;
        }
        private void Digit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).Opacity = 0.3;
            string name = ((Image)sender).Name;
            string path = $"{Environment.CurrentDirectory}\\digitsAudio\\{name}.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Load();
            soundPlayer.Play();
        }

        #region basic actions with the window
        

        private void DigitsDown(object sender, MouseButtonEventArgs e)
        {
            Letters.Visibility = Visibility.Hidden;
            Digits.Visibility = Visibility.Visible;

        }

        private void ButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Label)sender).Background = (Brush)Application.Current.MainWindow.FindResource("ButtonBrush2");

        }

        private void Mouse_Drag_Window(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void LettersDown(object sender, MouseButtonEventArgs e)
        {
            Letters.Visibility = Visibility.Visible;
            Digits.Visibility = Visibility.Hidden;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Отмена закрытия окна 
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Header_Mouse_Enter(object sender, RoutedEventArgs e)
        {
            ((Label)sender).Foreground = Brushes.White;
        }
        private void Header_Mouse_Leave(object sender, RoutedEventArgs e)
        {
            ((Label)sender).Foreground = Brushes.Black;
        }
        private void Resize_Wondow(object sender, RoutedEventArgs e)
        {

            if (WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }
        private void Roll_Up(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Mouse_Enter(object sender, RoutedEventArgs e)
        {
            ((Label)sender).Background = new SolidColorBrush(Colors.Gray) { Opacity = 0.2 };
        }
        private void Mouse_Leave(object sender, RoutedEventArgs e)
        {
            ((Label)sender).Background = new SolidColorBrush(Colors.Gray) { Opacity = 0 };
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }
        private void Mouse_Enter_Close(object sender, RoutedEventArgs e)
        {
            ((Label)sender).Background = Brushes.Red;
        }
        private void Mouse_Leave_Close(object sender, RoutedEventArgs e)
        {
            lbl_Close.Background = new SolidColorBrush(Colors.Gray) { Opacity = 0 };
        }

        //Открытие окна для входа в аккаунт\регистрации
        private void LoginWindow_Open(object sender, MouseButtonEventArgs e)
        {

        }


        #endregion

        
    }
}
