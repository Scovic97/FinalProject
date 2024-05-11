using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly: InternalsVisibleTo("frmMain")]

namespace KevinAldana_FinalLab
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
