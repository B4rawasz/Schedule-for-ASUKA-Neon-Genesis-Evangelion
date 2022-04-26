using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Schedule_for_ASUKA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RestartWPE();
        }

        public void RestartWPE()
        {
            try
            {
                var process = Process.GetProcessesByName("wallpaper32")[0];
                var path = process.MainModule.FileName;
                process.Dispose();
                //Process.Start(path);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
