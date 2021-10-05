using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmProg1 : Form
    {
        public FrmProg1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void FrmProg1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBarControl1.EditValue = i;
        }
    }
}
