using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Bientoancuc.setRowNumber(dataGridView1);
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
            //Bientoancuc.setRowNumber(dataGridView1);
        }
    }
}
