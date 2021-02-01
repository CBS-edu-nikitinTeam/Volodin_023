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

namespace Exercise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler Start;
        public event EventHandler Stop;
        public event EventHandler Clear;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Start?.Invoke(this, e);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            Stop?.Invoke(this, e);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear?.Invoke(this, e);
        }
    }
}
