using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class W : Form
    {
        public W()
        {
            InitializeComponent();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskManager frm = new TaskManager();
           
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            FileManager frm = new FileManager();
            
            frm.Show();
        }

        private void lbTask_Click(object sender, EventArgs e)
        {

        }

        private void W_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Directory.Delete(@"C:\RecycleBin", true);
        }

        private void W_Load(object sender, EventArgs e)
        {

            Directory.CreateDirectory(@"C:\RecycleBin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string recycle = @"C:\RecycleBin";
            Process.Start("explorer.exe", recycle);
        }
    }
}
