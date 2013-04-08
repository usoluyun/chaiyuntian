using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using common;//常用函数

namespace wpf_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string current;
        public string lastNumber;
        public MainWindow()
        {
            current = "";
            InitializeComponent();
            
        }

        private string addString(string s1, string s2)
        {
             return s1 + s2;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            
            if(current.Length!=0)
            {
             current = current.Remove(current.Length - 1);
             label1.Content = current;
            }

        }
     

        #region(“点击事件”)


        private void N1_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "1");
            label1.Content = current;

        }

        private void N2_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "2");
            label1.Content = current;
        }

        private void N3_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "2");
            label1.Content = current;
        }

        private void N4_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "4");
            label1.Content = current;
        }

        private void N5_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "5");
            label1.Content = current;
        }

        private void N6_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "6");
            label1.Content = current;
        }

        private void N7_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "7");
            label1.Content = current;
        }

        private void N8_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "8");
            label1.Content = current;
        }

        private void N9_Click(object sender, RoutedEventArgs e)
        {
            current = addString(current, "9");
            label1.Content = current;
        }

    
     #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string.Compare(current, lastNumber);
        }


    }
}
