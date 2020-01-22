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

namespace EsercizioNatale3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox[] array;
        public MainWindow()
        {
            InitializeComponent();
            array = new TextBox[] { TxtNum1, TxtNum2, TxtNum3, TxtNum4, TxtNum5, TxtNum6 };
        }
        
        private void BtnON_OFF_Click(object sender, RoutedEventArgs e)
        {
            if (BtnON_OFF.Content.ToString() == "ON")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].IsEnabled = true;
                }
                BtnCalcola.IsEnabled = true;
                BtnON_OFF.Content = "OFF";
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].IsEnabled = false;
                }
                BtnCalcola.IsEnabled = false;
                BtnON_OFF.Content = "ON";
            }

        }

        private void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = 0;
                int n2 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int num = int.Parse(array[i].Text);
                    if (num % 2 == 0)
                    {
                        n1++;
                    }
                    else
                    {
                        n2++;
                    }
                }
                LblRisultato.Content = $"I numeri pari sono {n1}, i numeri dispari sono {n2}";
            }
            catch
            {
                MessageBox.Show("Inserire solo numeri", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
