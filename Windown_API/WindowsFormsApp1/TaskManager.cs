using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TaskManager : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetProcessName(IntPtr hProcess, string lpProcessName);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        public TaskManager()
        {
            InitializeComponent();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            // Add cột vào datagridview
            dgv.Columns.Add("ProcessName", "Process Name");
            dgv.Columns["ProcessName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add("ProcessId", "Process ID");
            dgv.Columns.Add("ProcessStatus", "Status");
            dgv.Columns.Add("Memory", "Memory Usage (MB)");
            //dgv.Columns.Add("CPU", "CPU");
            load_TM(sender, e);

        }

        Process[] processes;

        void load_TM(object sender, EventArgs e)
        {

            dgv.Rows.Clear();

            // Lấy danh sách tất cả các tiến trình trên hệ thống
            processes = Process.GetProcesses();

            // Sắp xếp danh sách theo tên tiến trình
            var sortedProcesses = processes.OrderBy(process => process.ProcessName);

            // Điền thông tin tiến trình vào datagridview
            foreach (var process in sortedProcesses)
            {
                try
                {
                    string status = process.Responding ? "Running" : "Not Responding";


                    // lấy tỷ lệ sử dụng cpu của từng tiến trình
                    //float cpuUsage = ((float)(process.TotalProcessorTime.Milliseconds) / (float)(Environment.ProcessorCount * Environment.TickCount)) * 100;


                    //dgv.Rows.Add(process.ProcessName, process.Id, status, (process.WorkingSet64 / (1024 * 1024)).ToString("N1"), cpuUsage.ToString("N1") + "%");
                    dgv.Rows.Add(process.ProcessName, process.Id, status, (process.WorkingSet64 / (1024 * 1024)).ToString("N1"));


                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu không thể truy cập thông tin CPU của tiến trình
                    Console.WriteLine($"Lỗi khi truy cập thông tin tiến trình {process.ProcessName}: {ex.Message}");

                }


            }
        }


        private void newTm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Browse";
                openFileDialog.Filter = "All File | *.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Kiểm tra nếu tệp tin tồn tại
                    if (System.IO.File.Exists(selectedFilePath))
                    {
                        // Mở tệp tin
                        Process.Start(selectedFilePath);
                    }
                }
            }


            if (txt.Text != "")
            {
                timer2.Enabled = true;
            }
            else
            {
                load_TM(sender, e);
            }
        }



        private void endTm_Click(object sender, EventArgs e)
        {
            // Chọn tiến trình muốn dừng (nếu có)
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedRow = dgv.SelectedRows[0].Index;
                int processId = (int)dgv.Rows[selectedRow].Cells["ProcessId"].Value;

                // Thử tìm và dừng tiến trình đã chọn

                try
                {
                    Process process = Process.GetProcessById(processId);
                    DialogResult result = MessageBox.Show("Do you want to stop the process", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        process.Kill();

                        search_load(sender, e);
                        timer2.Enabled = true;
                        txt_TextChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ending the process: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Select a process");
            }

        }


        private void txt_TextChanged(object sender, EventArgs e)
        {

            if (txt.Text != "")
            {
                timer1.Enabled = false;
            }
            else
            {
                load_TM(sender, e);
                timer1.Enabled = true;
                timer2.Enabled = false;
            }



        }

        void search_load(object sender, EventArgs e)
        {
            string searchQuery = txt.Text;

            // Clear datagridview
            dgv.Rows.Clear();

            // Lấy danh sách tất cả các tiến trình trên hệ thống
            Process[] processes = Process.GetProcesses();


            // Lọc các tiến trình theo tên hoặc ID 
            processes = processes.Where(process =>
                process.ProcessName.ToLower().Contains(searchQuery.ToLower()) ||
                process.Id.ToString() == searchQuery
            ).ToArray();


            // Điền các tiền trình lọc được vào datagridview
            foreach (var process in processes)
            {
                string status = process.Responding ? "Running" : "Not Responding";

                dgv.Rows.Add(process.ProcessName, process.Id, status, (process.WorkingSet64 / (1024 * 1024)).ToString("N1"));

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (processes.Length != Process.GetProcesses().Length)
            {
                load_TM(sender, e);
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                search_load(sender, e);
            }
        }


        private void searchTm_Click(object sender, EventArgs e)
        {
            search_load(sender, e);
            txt_TextChanged(sender, e);
            timer2.Enabled = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }



        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchTm_Click(sender, e);
            }
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgv.CurrentCell.RowIndex;

        }
    }
}

