using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Activity_3
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
        private void btn_StartLengthyTask_Click(object sender, RoutedEventArgs e)
        {
           

            Thread.Sleep(1000);

            

            pb_TaskProgress.Value = 0;

            Task.Run(() =>
            {
                for (int i = 0; i <=100; i++)
                {
                    Thread.Sleep(50);
                    this.Dispatcher.Invoke(() => //Use Dispather to Update UI Immediately  
                    {
                        pb_TaskProgress.Value = i;
                        lbl_CountDownTimer.Text = i.ToString();
                    });
                }
            });
        }
    }
}
