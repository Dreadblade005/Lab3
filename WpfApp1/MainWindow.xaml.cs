/// Chapter No. 3 Lab 3
/// File Name: Pig latin input
/// @author: Dakota Durst
/// Date: september 14, 2020
///
/// Problem Statement: 
/// Ask the user to enter first and last name in popup window. After user has inputed name and pressed convert to pig latin display popup with translated name
///
///
/// Overall Plan:
/// 1) create visual display of popup with first, last, and translate button
/// 2) assign variables
/// 3) change anme to all lower case
/// 4) set variable of pig latin based on user inputs
/// 5) display popup with translated nane
///
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
