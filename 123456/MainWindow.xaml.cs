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

namespace _123456
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
        private void vypocitejButton_Click(object sender, RoutedEventArgs e)
        {
            string operace = operaceComboBox.Text;
            double cislo1 = double.Parse(cislo1TextBox.Text);
            double vysledek=0;
            double vysledek1;


            if (operace == "mm")
            {
                vysledek = (cislo1 * 6.28);
                vysledek1 = (cislo1 * cislo1 * 3.14);
            }
            else if (operace == "cm")
            {
                vysledek = (cislo1 * 6.28);
                vysledek1 = (cislo1 * cislo1 * 3.14);
            }
            else if (operace == "dm")
            {
                vysledek = (cislo1 * 6.28);
                vysledek1 = (cislo1 * cislo1 * 3.14);
            }
            else if (operace == "m")
            {
                vysledek = (cislo1 * 6.28);
                vysledek1 = (cislo1 * cislo1 * 3.14);
            }
            else
            { 
                MessageBox.Show("Neplatné číslo!");
            }
            vysledekTextBlock.Text = vysledek.ToString();
        }
    }
}
