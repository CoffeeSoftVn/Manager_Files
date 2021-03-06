using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Files
{
    public partial class frm_Rename : Form
    {
        private frm_Main f;
        private string Path;
        //private string NameF;
        private bool LR;
        private bool Type;
        public frm_Rename()
        {
            InitializeComponent();
        }
        public frm_Rename(frm_Main f, string path,string name, bool LR, bool Type)
        {
            InitializeComponent();
            { this.f = f; Path = path; this.LR = LR; this.Type = Type; }
            this.ActiveControl = txt_ReName;
            txt_ReName.Text = name;
            btn_ReName.MouseClick += (object sender, MouseEventArgs e) =>
            {
                if (txt_ReName.Text.Trim().Equals("")) {
                    this.Text = string.Format("{0} - {1}", "Rename - ", "Not empty the name!");
                    this.txt_ReName.Focus();
                    return;
                }
                try {
                    if (this.Type) //true file, false folden
                    {
                        System.IO.File.Move(path + @"\" + name, path + @"\" + txt_ReName.Text);
                    }
                    else
                    {
                        System.IO.Directory.Move(path + @"\" + name, path + @"\" + txt_ReName.Text);
                    }
                    if (LR)
                        f.SelectDataA();
                    else
                        f.SelectDataB();
                    this.Close();
                    return;
                } catch {
                    this.Text = string.Format("{0} - {1}", "Rename - ", "Can't change name!");
                }
         
            };
            btn_Cancel.MouseClick += (object sender, MouseEventArgs e) =>
            {
                this.Close();
            };
        }
        private void frm_Rename_Load(object sender, EventArgs e)
        {

        }
    }
}
