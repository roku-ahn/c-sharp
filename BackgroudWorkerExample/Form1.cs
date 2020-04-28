using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroudWorkerExample
{
    public partial class Form1 : Form
    {
        int number = 0;
        int percent = 0;
        public Form1()
        {
            InitializeComponent();
            InitBackWorkerEvent();
        }

        private void InitControl()
        {
            lb_per.Text = "";
            lb_result2.Text = "";

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 0;

        }
        private void InitBackWorkerEvent()
        {
         
            _bw.DoWork += new DoWorkEventHandler(this._bw_DoWork1);
            _bw.ProgressChanged += new ProgressChangedEventHandler(this._bw_ProgressChanged);
            _bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this._bw_RunWorkerCompleted);

            _bw2.DoWork += new DoWorkEventHandler(_bw2_DoWork1);
            _bw2.ProgressChanged += new ProgressChangedEventHandler(_bw2_ProgressChanged);
            _bw2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_bw2_RunWorkerCompleted);

        }

        private void _bw_DoWork1(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker wr = sender as BackgroundWorker;
            for (int i = 0; i < 10; i++)
            {
                if (wr.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    wr.ReportProgress(i * 10);
                }
            }
        }
        private void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
            if(e.Cancelled == true)
            {
                lb_per.Text = "cancel";
         
            }
            else if(e.Error != null)
            {
                lb_per.Text = "Error" + e.Error.Message;
            }
            else
            {
                lb_per.Text = "Done";
            }
        }
        
        private void _bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        
            lb_per.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (_bw.IsBusy != true)
            {
                _bw.RunWorkerAsync();
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            if(_bw.WorkerSupportsCancellation == true)
                _bw.CancelAsync();
        }
        private void bt_reset_Click(object sender, EventArgs e)
        {
            lb_per.Text = "";
            _bw.CancelAsync();
        }

        private void bt_reset2_Click(object sender, EventArgs e)
        {
            lb_result2.Text = "";
            progressBar1.Value = 0;
        }
    
        private void _bw2_DoWork1(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }
        private void _bw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else if(e.Cancelled)
            {
                lb_result2.Text = "cancle";
            }
            else
            {
                lb_result2.Text = e.Result.ToString();
            }

            numericUpDown1.Enabled = true;
            bt_startAsy.Enabled = true;
            bt_stopasy.Enabled = false;
        }
        
        private void _bw2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bt_startAsy_Click(object sender, EventArgs e)
        {
            lb_result2.Text = String.Empty;

            numericUpDown1.Enabled = false;
            bt_startAsy.Enabled = false;
            bt_stopasy.Enabled = true;
            number = (int)numericUpDown1.Value;
            percent = 0;
            _bw2.RunWorkerAsync(number);
        }

        private void bt_stopasy_Click(object sender, EventArgs e)
        {
            _bw2.CancelAsync();
            numericUpDown1.Enabled = true;
            bt_startAsy.Enabled = true;
            bt_stopasy.Enabled = false;
        }

        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // The parameter n must be >= 0 and <= 91.
            // Fib(n), with n > 91, overflows a long.
            if ((n < 0) || (n > 91))
            {
                throw new ArgumentException(
                    "value must be >= 0 and <= 91", "n");
            }

            long result = 0;

            // Abort the operation if the user has canceled.
            // Note that a call to CancelAsync may have set 
            // CancellationPending to true just after the
            // last invocation of this method exits, so this 
            // code will not have the opportunity to set the 
            // DoWorkEventArgs.Cancel flag to true. This means
            // that RunWorkerCompletedEventArgs.Cancelled will
            // not be set to true in your RunWorkerCompleted
            // event handler. This is a race condition.

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) +
                             ComputeFibonacci(n - 2, worker, e);
                }

                // Report progress as a percentage of the total task.
                int percentComplete =
                    (int)((float)n / (float)number * 100);
                if (percentComplete > percent)
                {
                    percent = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }

            return result;
        }

    }
}
