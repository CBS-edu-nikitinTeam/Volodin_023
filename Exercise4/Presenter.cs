using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;

namespace Exercise4
{
    class Presenter
    {
        private Model _model = null;
        private MainWindow _mainWindow = null;
        public Presenter(MainWindow mainWindow)
        {
            _model = new Model();
            _mainWindow = mainWindow;

            DefineHandler();
        }

        private void DefineHandler()
        {
            void ExecuteOperation(object sender, EventArgs args)
            {
                MainWindow.ButtonClickEventArgs btnClickArgs = (MainWindow.ButtonClickEventArgs)args;
                double operand1 = double.Parse(_mainWindow.TbOperand1.Text.ToString());
                double operand2 = double.Parse(_mainWindow.TbOperand2.Text.ToString());

                _mainWindow.TbResult.Text = _model.ExecuteOperation(operand1, operand2, btnClickArgs.Operation).ToString(CultureInfo.InvariantCulture);
            }

            _mainWindow.Add += ExecuteOperation;
            _mainWindow.Sub += ExecuteOperation;
            _mainWindow.Mul += ExecuteOperation;
            _mainWindow.Div += ExecuteOperation;
        }
    }
}
