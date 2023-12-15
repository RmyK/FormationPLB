using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegue
{
    class TicTac
    {
        public event EventHandler Ontic;

        private Timer timer;
        private int i;

        public int GetI() => i;
        public TicTac()
        {
            timer = new Timer(o =>
            {
                i++;
                if (Ontic != null)
                    Ontic(this, new EventArgs());
            }, null, 0, 2000);
        }
    }
}
