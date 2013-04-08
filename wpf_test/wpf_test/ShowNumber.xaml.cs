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
using System.Windows.Shapes;
using common;//常用函数

namespace wpf_test
{
    /// <summary>
    /// Interaction logic for ShowNumber.xaml
    /// </summary>
    public partial class ShowNumber : Window
    {
        public ShowNumber()
        {
            InitializeComponent();
        }

        private void image1_Click(object sender, ExceptionRoutedEventArgs e)
        {

           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("hhah");
          
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Sound s = new Sound();
            string[] kk = { "59", "60", "61" };
           
            //s.PlaySequence(kk,"wav",100);

            MediaPlayer[] SP = new MediaPlayer[kk.Length];

            s.PlaySequence(kk, "wav", 100);

        }
    }
}
