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
using System.Windows.Threading;

namespace WpfApp_SplashScreen
{
    /// <summary>
    /// Açlılış Ekranı Hazırlıyoruz
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);

            dt.Interval = TimeSpan.FromMilliseconds(0.5); // new TimeSpan( 0 ,0, 0, 0,1);
            dt.Start();
        }
        private void dt_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 15;
            if (progressBar.Width >= 455)
            {
            
                dt.Stop();
                DashBoard db = new DashBoard();
                db.Show();

                this.Close();
            }

        }

    }
}
