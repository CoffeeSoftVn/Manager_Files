using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Files
{
    public partial class frm_Copy : Form
    {
        public delegate void percent(double cent);
        public frm_Copy()
        {
            InitializeComponent();
            //progressBar1.ForeColor = Color.FromArgb(255, 0, 0);
            //progressBar1.BackColor = Color.FromArgb(150, 0, 0);
            btn_Perform.MouseClick += (object sender, MouseEventArgs e) => {
                //GetDriveA();
                //Task.Run(() => {
                //    for (int i = 1; i <= 100; i++) {
                //    Thread.Sleep(100);
                //        Progress1(i);
                //    }
                //});

                //label_Progress1.Text = "aaaaaa";

                bool b = CopyFile1(@"D:\DataCoffees\data2.av", @"D:\DataCoffees\data1.av1", 1024*1000,  (data1) =>
                {
                    //Thread.Sleep(100);
                    //string aa = data1.ToString();
                    Task.Run(() => {
                        this.Invoke((MethodInvoker)delegate
                        {
                            //Task.Run(new Progress1(int.Parse(data1.ToString())));
                            //Progress1(int.Parse(data1.ToString()));
                            if (data1 % 50 == 0) {
                                int c = Convert.ToInt32(data1);
                                string s = "";
                                for (int i = 1; i <= c; i++)
                                    s = s + ".";
                                s += " " + c.ToString() + "%";
                                label_Progress1.Text = s;
                                //label_Progress1.Refresh();
                                //MessageBox.Show(data1.ToString());
                            }
                        });
                    });
                });
            };
        }

        //private bool CopyFile1(string v1, string v2, Action<object> p)
        //{
        //    MessageBox.Show("con cac");
        //    //hrow new NotImplementedException();
        //}

        private void frm_Copy_Load(object sender, EventArgs e)
        {
            //progressBar1.ForeColor = Color.FromArgb(255, 0, 0);
            //progressBar1.BackColor = Color.FromArgb(0, 0, 0);
            //ColorBar.SetState(progressBar1, ColorBar.Color.Red, 50);
        }
        public void Progress1(int c)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
                string s = "";
                for (int i = 1; i <= c; i++)
                    s = s + ".";
                s += " " + c.ToString() + "%";
                label_Progress1.Text = s;
            //});
        }
        public void Progress2(int c)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string s = "";
                for (int i = 1; i <= c; i++)
                    s = s + ".";
                s += " " + c.ToString() + "%";
                label_Progress2.Text = s;
            });
        }
        public bool CopyFile1(string fromPath, string toPath, int eachReadLength, percent p)
        {
            
            int toCopyLength = 0;
            FileStream fromFile, toFile;
            try
            {
                fromFile = new FileStream(fromPath, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                return false;
            }
            try
            {
                toFile = new FileStream(toPath, FileMode.Create, FileAccess.Write);
            }
            catch
            {
                fromFile.Close();
                return false;
            }
            try
            {
                if (eachReadLength < fromFile.Length)
                {
                    int count = 0;
                    byte[] buffer = new byte[eachReadLength];
                    long copied = 0;
                    while (copied <= fromFile.Length - eachReadLength)
                    {
                        toCopyLength = fromFile.Read(buffer, 0, eachReadLength);
                        fromFile.Flush();
                        toFile.Write(buffer, 0, eachReadLength);
                        toFile.Flush();
                        toFile.Position = fromFile.Position;
                        //count = int.Parse( (copied/(fromFile.Length - eachReadLength)).ToString());
                        if (count != Convert.ToInt32(double.Parse(copied.ToString()) / double.Parse((fromFile.Length - eachReadLength).ToString()) * 100))
                        {
                            count = Convert.ToInt32(double.Parse(copied.ToString()) / double.Parse((fromFile.Length - eachReadLength).ToString()) * 100);
                            p(count);
                        }
                        copied += toCopyLength;
                    }
                    int left = (int)(fromFile.Length - copied);
                    toCopyLength = fromFile.Read(buffer, 0, left);
                    fromFile.Flush();
                    toFile.Write(buffer, 0, left);
                    toFile.Flush();
                    p(100);
                }
                else
                {
                    byte[] buffer = new byte[fromFile.Length];
                    fromFile.Read(buffer, 0, buffer.Length);
                    fromFile.Flush();
                    toFile.Write(buffer, 0, buffer.Length);
                    toFile.Flush();
                    p(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                try { fromFile.Close(); } catch { }
                try { toFile.Close(); } catch { }
                return false;
            }
            fromFile.Close();
            toFile.Close();
           
            return true;
        }
    }
}
