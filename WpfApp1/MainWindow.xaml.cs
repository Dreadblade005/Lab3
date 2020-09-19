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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String piglatinfn; // to output
            String piglatinln; //to output
            String firstName = fntextbox.Text; //Mark
            String lastName = lntextbox.Text; // Aloka

            //process first name
            piglatinfn = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1).ToLower() + "ay"; //arkmay
            piglatinfn = piglatinfn.Substring(0, 1).ToUpper() + piglatinfn.Substring(1, piglatinfn.Length - 1); //Arkmay
            //process last name
            piglatinln = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1).ToLower() + "ay"; //lokaay
            piglatinln = piglatinln.Substring(0, 1).ToUpper() + piglatinln.Substring(1, piglatinln.Length - 1); //Lokaay

            MessageBox.Show("Your name in piglatin is " + piglatinfn + " " + piglatinln);


        }
    }
}
