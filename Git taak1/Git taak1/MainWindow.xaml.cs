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

namespace Git_taak1
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
        private void Green_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        }

        private void Red_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void Yellow_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Blue_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
            this.Background = new SolidColorBrush(Colors.LightGray);
        }
        private void Green_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorCodeText.Text = "Kleurcode: #008000";
            ColorInfoText.Text = "Groen is de kleur van genezing";
        }

        private void Red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorCodeText.Text = "Kleurcode: #FF0000";
            ColorInfoText.Text = "Rood is de kleur van warmte";
        }

        private void Yellow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorCodeText.Text = "Kleurcode: #FFFF00";
            ColorInfoText.Text = "Geel is de kleur van levenslust";
        }

        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorCodeText.Text = "Kleurcode: #0000FF";
            ColorInfoText.Text = "Blauw is de kleur van intelligentie";
        }
    }
}
