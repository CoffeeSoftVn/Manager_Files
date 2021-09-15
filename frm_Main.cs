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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            cbo_DriveA.SelectedIndexChanged += (object sender, EventArgs e) => {
                txt_PathA.Text = cbo_DriveA.SelectedValue.ToString();
                SelectDataA(txt_PathA.Text);
            };
            cbo_DriveB.SelectedIndexChanged += (object sender, EventArgs e) => {
                txt_PathB.Text = cbo_DriveB.SelectedValue.ToString();
                SelectDataB(txt_PathB.Text);
            };
            dataGridViewA.MouseDoubleClick += (object sender, MouseEventArgs e) => {
                if (dataGridViewA.Rows[dataGridViewA.CurrentCell.RowIndex].Cells["NAME_A"].Value.ToString() == "<---")
                {
                    txt_PathA.Text = BackPath(txt_PathA.Text.Replace(@"\\", @"\"));
                    SelectDataA(txt_PathA.Text);
                    return;
                }
                if (dataGridViewA.Rows[dataGridViewA.CurrentCell.RowIndex].Cells["TYPE_A"].Value.ToString() == "Folder")
                {
                    txt_PathA.Text = (txt_PathA.Text + "\\" + dataGridViewA.Rows[dataGridViewA.CurrentCell.RowIndex].Cells["NAME_A"].Value.ToString()).Replace(@"\\", @"\");
                    SelectDataA(txt_PathA.Text);
                    return;
                }
             };
            dataGridViewB.MouseDoubleClick += (object sender, MouseEventArgs e) => {
                if (dataGridViewB.Rows[dataGridViewB.CurrentCell.RowIndex].Cells["NAME_B"].Value.ToString() == "<---")
                {
                    txt_PathB.Text = BackPath(txt_PathB.Text.Replace(@"\\", @"\"));
                    SelectDataB(txt_PathB.Text);
                    return;
                }
                if (dataGridViewB.Rows[dataGridViewB.CurrentCell.RowIndex].Cells["TYPE_B"].Value.ToString() == "Folder")
                {
                    txt_PathB.Text = (txt_PathB.Text + "\\" + dataGridViewB.Rows[dataGridViewB.CurrentCell.RowIndex].Cells["NAME_B"].Value.ToString()).Replace(@"\\", @"\");
                    SelectDataB(txt_PathB.Text);
                    return;
                }
            };
            btn_RefreshA.MouseClick += (object sender, MouseEventArgs e) => {
                GetDriveA();
            };
            btn_RefreshB.MouseClick += (object sender, MouseEventArgs e) => {
                GetDriveB();
            };
            btn_BackA.MouseClick += (object sender, MouseEventArgs e) => {
                txt_PathA.Text = BackPath(txt_PathA.Text.Replace(@"\\", @"\"));
                SelectDataA(txt_PathA.Text);
            };
            btn_BackB.MouseClick += (object sender, MouseEventArgs e) => {
                txt_PathB.Text = BackPath(txt_PathB.Text.Replace(@"\\", @"\"));
                SelectDataB(txt_PathB.Text);
            };
            txt_PathA.MouseDoubleClick += (object sender, MouseEventArgs e) => {
                System.Diagnostics.Process.Start(@"explorer.exe", txt_PathA.Text);
            };
            txt_PathB.MouseDoubleClick += (object sender, MouseEventArgs e) => {
                System.Diagnostics.Process.Start(@"explorer.exe", txt_PathB.Text);
            };
            dataGridViewA.ContextMenuStrip = contextMenuStripA;
            dataGridViewB.ContextMenuStrip = contextMenuStripB;
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            GetDriveA();
            GetDriveB();
        }
        private void GetDriveA() {
           
            cbo_DriveA.DataSource = System.IO.DriveInfo.GetDrives();
            cbo_DriveA.DisplayMember = "Name";
        }
        private void GetDriveB()
        {
            cbo_DriveB.DataSource = System.IO.DriveInfo.GetDrives();
            cbo_DriveB.DisplayMember = "Name";
        }
        public void SelectDataA(string PathA)
        {
            DataTable table = new DataTable();
            table.Columns.Add("SELECT_A", typeof(Boolean));
            table.Columns.Add("NAME_A", typeof(string));
            table.Columns.Add("TYPE_A", typeof(string));
            table.Columns.Add("SIZE_A", typeof(string));
            table.Columns.Add("DATE_A", typeof(string));
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(PathA);
            if (PathA.Length > 3)
                table.Rows.Add(false, "<---", "", "");
            try
            {
                foreach (System.IO.DirectoryInfo g in dir.GetDirectories())
                {
                    table.Rows.Add(false, g.Name.ToString(), "Folder", "", g.CreationTime.ToString());
                }
                foreach (System.IO.FileInfo f in dir.GetFiles("*.*"))
                {
                    table.Rows.Add(false, f.Name.ToString(), f.Extension, (Convert.ToDouble(f.Length) / 1000).ToString() + " KB", f.CreationTime.ToString());
                }
            }
            catch
            { }
            dataGridViewA.DataSource = table;
        }
        public void SelectDataB(string PathB)
        {
            DataTable table = new DataTable();
            table.Columns.Add("SELECT_B", typeof(Boolean));
            table.Columns.Add("NAME_B", typeof(string));
            table.Columns.Add("TYPE_B", typeof(string));
            table.Columns.Add("SIZE_B", typeof(string));
            table.Columns.Add("DATE_B", typeof(string));
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(PathB);
            if (PathB.Length > 3)
                table.Rows.Add(false, "<---", "", "");
            try
            {
                foreach (System.IO.DirectoryInfo g in dir.GetDirectories())
                {
                    table.Rows.Add(false, g.Name.ToString(), "Folder", "", g.CreationTime.ToString());
                }
                foreach (System.IO.FileInfo f in dir.GetFiles("*.*"))
                {
                    table.Rows.Add(false, f.Name.ToString(), f.Extension, (Convert.ToDouble(f.Length) / 1000).ToString() + " KB", f.CreationTime.ToString());
                }
            }
            catch
            { }
            dataGridViewB.DataSource = table;
        }
        private string BackPath(string s)
        {
            string s2 = "";
            string[] s1 = s.Split('\\');
            if (s1.Count() <= 1) return s;
            for (int i = 0; i < s1.Count() - 1; i++)
            {
                if (i == 0)
                    s2 = (s2 + s1[i] + "\\").Replace(@"\\", @"\");
                else
                    s2 = (s2 + "\\" + s1[i]).Replace(@"\\", @"\");
            }
            return s2;
        }
    }
}
