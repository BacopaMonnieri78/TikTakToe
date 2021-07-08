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

namespace TikTakToe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        GameLogic GameLogic = new GameLogic();
        private void PlayClickSpace (object sender, RoutedEventArgs e)
        {
            var Space = (Button)sender;
            if (!String.IsNullOrWhiteSpace(Space.Content?.ToString())) return;
            Space.Content = GameLogic.CurrentPlayer;
            GameLogic.SetNextPlayer();
        }
        private void BtnNewButton(object sender, RoutedEventArgs e)
        {
            foreach(var control in gridBoard.Children)
            {
                if(control is Button)
                {
                    ((Button)control).Content = String.Empty;
                }
            }
        }
    }
}
