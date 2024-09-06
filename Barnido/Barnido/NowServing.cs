using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barnido
{
    public partial class NowServing : Form
    {
        private Timer timer;
        public NowServing()
        {
            InitializeComponent();
        }

        private void NowServing_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayFirstQueue(CashierClass.CashierQueue);
        }
        private void DisplayFirstQueue(Queue<string> cashierQueue)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                label1.Text = CashierClass.CashierQueue.Peek();
            }
        }
    }
}
