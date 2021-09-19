using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Files
{
    public partial class frm_Copy : Form
    {
        public frm_Copy()
        {
            InitializeComponent();
            //progressBar1.ForeColor = Color.FromArgb(255, 0, 0);
            //progressBar1.BackColor = Color.FromArgb(150, 0, 0);
        }

        private void frm_Copy_Load(object sender, EventArgs e)
        {
            //progressBar1.ForeColor = Color.FromArgb(255, 0, 0);
            //progressBar1.BackColor = Color.FromArgb(0, 0, 0);
            //ColorBar.SetState(progressBar1, ColorBar.Color.Red, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.ForeColor = Color.Red;
            //progressBar1.Value += 1;
        }
    }
}
