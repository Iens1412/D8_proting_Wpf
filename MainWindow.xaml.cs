using D8_porting;
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

namespace D8_porting_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Gör all initiering nedanför den här texten!
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            string output = "Key pressed: ";
            output += e.Key.ToString();
            KeyPressDisplay.Text = output;

            Title.Text = Scenery.HelpTitle();
            Text.Text = Scenery.HelpText();

            if (e.Key == Key.Escape)
                {
                    System.Windows.Application.Current.Shutdown();
                }
                else if (e.Key == Key.H)
                {
                    Title.Text = Scenery.HelpTitle();
                    Text.Text = Scenery.HelpText();
                }
                else if (e.Key == Key.N || e.Key == Key.F || e.Key == Key.S)
                {
                    string command = e.Key.ToString().ToLower();
                    Scenery.DoCommand(command);
                
                    Title.Text = Scenery.CurrentTitle(command);
                    Text.Text = Scenery.CurrentText(command);
                }
        }
    }
}
