using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinAldana_FinalLab
{
    public partial class frmSplash : Form
    {
        Timer splashTimer;
        public frmSplash()
        {
            InitializeComponent();
            InitializeSplashTimer();
        }

        private void InitializeSplashTimer()
        {

            splashTimer = new Timer();
            splashTimer.Interval = 5000;
            splashTimer.Tick += SplashTimer_Tick_Tick;
            
        }




        private void frmSplash_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        private void SplashTimer_Tick_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
