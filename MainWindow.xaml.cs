using System;
using System.Windows;

namespace project_one
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gay_result.Text = rng.Next(0, 1000) + ".0 %";
        }
    }
}
