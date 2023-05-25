using Desktop_01_3990.ViewModel;
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
using System.Windows.Shapes;

namespace Desktop_01_3990.View
{
    /// <summary>
    /// Interaction logic for LogInWindowView.xaml
    /// </summary>
    public partial class LogInWindowView : Window
    {
        public LogInWindowView()
        {
            InitializeComponent();
            DataContext = new LogInWindowVM();
        }
    }
}
