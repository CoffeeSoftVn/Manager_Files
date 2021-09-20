using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manager_Files
{
    public partial class frm_NewFolder : Form
    {
        private frm_Main f;
        private string Path;
        private bool LR;
        public frm_NewFolder()
        {
            InitializeComponent();
        }
        public frm_NewFolder(frm_Main f, string path, bool LR)
        {
            InitializeComponent();
            { this.f = f; Path = path; this.LR = LR;}
            //this.Load += new System.EventHandler((object sender, EventArgs e) =>
            //{
            //});
            this.ActiveControl = txt_Folder;
            btn_CreateFolder.MouseClick += (object sender, MouseEventArgs e) => {
                if (txt_Folder.Text.Trim().Equals(""))
                { 
                    this.Text = string.Format("{0} - {1}", "New Folder", "Not empty the folder name!");
                    this.txt_Folder.Focus();
                    return;
                }
                try {
                    System.IO.Directory.CreateDirectory(path + "\\" + txt_Folder.Text);
                    if (LR)
                        f.SelectDataA();
                    else 
                        f.SelectDataB();
                } catch {
                    this.Text = string.Format("{0} - {1}", "New Folder", "Can't create folder!");
                    txt_Folder.Text = "";
                    return;
                }
                this.Close();
            };
            btn_Cancel.MouseClick += (object sender, MouseEventArgs e) => {
                this.Close();
            };
        }
        private void frm_NewFolder_Load(object sender, EventArgs e)
        {
            //txt_Folder.Focus();
        }
    }
}
