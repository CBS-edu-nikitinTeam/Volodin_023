using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Exercise4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler Add = null;
        public event EventHandler Sub = null;
        public event EventHandler Mul = null;
        public event EventHandler Div = null;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                Add?.Invoke(this, new ButtonClickEventArgs(Model.Operations.Add));
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                Sub?.Invoke(this, new ButtonClickEventArgs(Model.Operations.Sub));
            }
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                Mul?.Invoke(this, new ButtonClickEventArgs(Model.Operations.Mul));
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                if (double.Parse(TbOperand2.Text.ToString()) == 0)
                {
                    MessageBox.Show("Нельзя делить на 0");
                } else
                {
                    Div?.Invoke(this, new ButtonClickEventArgs(Model.Operations.Div));
                }
               
            }
        }
        private bool IsInputValid()
        {
            bool inputValid = true;

            if (!double.TryParse(TbOperand1.Text.ToString(), out double operand1))
            {
                MessageBox.Show("Необходимо ввести число для операнда 1");
                inputValid = false;
            }
            if (!double.TryParse(TbOperand2.Text.ToString(), out double operand2))
            {
                MessageBox.Show("Необходимо ввести число для операнда 2");
                inputValid = false;
            }

            return inputValid;
        }

        // Как раз хорошо, что сделал свой тип события.
        public class ButtonClickEventArgs: EventArgs
        {
            public Model.Operations Operation { get; set; }

            public ButtonClickEventArgs(Model.Operations operation) => Operation = operation;
        }
    }
}
