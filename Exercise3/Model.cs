using System;
using System.Windows.Threading;

namespace Exercise3
{
    class Model
    {
        public int Seconds { get; set; } = default;
        public DispatcherTimer Timer { get; private set; } = null;

        public Model()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
        }
    }
}
