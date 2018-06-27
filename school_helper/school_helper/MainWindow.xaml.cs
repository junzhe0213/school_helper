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

namespace school_helper
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //設隨機變數
        Random yn = new Random();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //設一般變數
            int ans = yn.Next(1, 3);
            int y = yn.Next(1, 5);
            int n = yn.Next(1, 5);

            {
                //抽到要去學校
                if (ans == 1)
                {
                    YN.Text = "要去";
                    YN.Foreground = Brushes.Red;
                    reason.Foreground = Brushes.Red;
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri("no.png", UriKind.Relative);
                    bi.EndInit();
                    image.Stretch = Stretch.Uniform;
                    image.Source = bi;
                    //抽到的理由
                    if (y == 1)
                    {
                        reason.Text = "保旭都不酸人了餒";
                    }
                    if (y == 2)
                    {
                        reason.Text = "純良都稱讚你可以做出好作品了餒";
                    }
                    if (y == 3)
                    {
                        reason.Text = "紹洋都去學校了餒";
                    }
                    if (y == 4)
                    {
                        reason.Text = "影像處理老師不切電腦了餒";
                    }
                    if (y == 5)
                    {
                        reason.Text = "現在有人在拉你餒";
                    }
                }
                //抽到不去學校
                else
                {
                    YN.Text = "不去";
                    YN.Foreground = Brushes.LightGreen;
                    reason.Foreground = Brushes.LightGreen;
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri("yes.png", UriKind.Relative);
                    bi.EndInit();
                    image.Stretch = Stretch.Uniform;
                    image.Source = bi;
                    //抽到的理由
                    if (n == 1)
                    {
                        reason.Text = "保旭會酸你餒";
                    }
                    if (n == 2)
                    {
                        reason.Text = "沒人拉著你餒";
                    }
                    if (n == 3)
                    {
                        reason.Text = "你離開Unity後就什麼都不是啊";
                    }
                    if (n == 4)
                    {
                        reason.Text = "有人會玩你的妹啊";
                    }
                    if (n == 5)
                    {
                        reason.Text = "你是保旭第二失望的學生啊";
                    }
                }
            }
        }
    }
}
