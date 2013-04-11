using common;//常用函数
using System.Linq;
using System.Windows;
using System.Windows.Input;

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
            string format = "wav";
            string[] kk = { "59", "60", "61" };

            //初始化播放器和播放列表
            Sound s = new Sound(kk.Select(f => f + "." + format).ToArray());
            //这里有用到linq的语法，感兴趣可以到这里看看： http://msdn.microsoft.com/en-us/library/vstudio/bb397926.aspx

            //从头开始播放
            s.PlaySequence();

        }
    }
}
