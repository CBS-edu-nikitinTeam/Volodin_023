using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Exercise3
{
    class Presenter
    {
        // Супер!!!!
        private Model _model = null;
        private MainWindow _mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this._model = new Model();
            this._mainWindow = mainWindow;

            this._mainWindow.Start += (sender, args) => _model.Timer.Start();
            this._mainWindow.Stop += (sender, args) => _model.Timer.Stop();
            this._mainWindow.Clear += (sender, args) =>
            {
                _mainWindow.TbContent.Text = "00:00:00";
                _model.Seconds = default;
            };

            this._model.Timer.Tick += (sender, args) =>
            {
                _model.Seconds += 1;
                TimeSpan timeSpan = TimeSpan.FromSeconds(_model.Seconds);
                _mainWindow.TbContent.Text =
                    string.Format($"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}");
            };

        }
    }
}
