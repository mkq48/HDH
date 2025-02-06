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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            CreateShow();
            MoveHide();
            deleteHide();

        }



        void CreateHide()
        {
            lbFoF.Hide();
            lbType.Hide();
            lbLocation.Hide();
            lbFileName.Hide();
            cbSelect.Hide();
            cbType.Hide();
            txtLocation.Hide();
            txtFileName.Hide();
            btnCreateIn.Hide();
            btnCancel.Hide();
            btnLocation.Hide();
            viewCreate.Hide();
        }


        void CreateShow()
        {
            addItemCBSL();

            lbFoF.Show();
            lbType.Show();
            lbLocation.Show();
            lbFileName.Show();
            cbSelect.Show();
            cbType.Show();
            txtLocation.Show();
            txtFileName.Show();
            btnCreateIn.Show();
            btnCancel.Show();
            btnLocation.Show();
            viewCreate.Show();
        }



        void CreateFolder()
        {
            string folderPath = txtLocation.Text;
            string folderName = txtFileName.Text;

            string newFolder = Path.Combine(folderPath, folderName);

            if (folderName == "" || folderPath == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
                MessageBox.Show("Thư mục đã được tạo thành công.");
            }
            else
            {
                MessageBox.Show("Thư mục đã tồn tại.");
            }
        }


        void CreateFile()
        {

            if (cbType.SelectedIndex == 0)
            {
                cbType.Text = "txt";
            }
            else if (cbType.SelectedIndex == 1)
            {
                cbType.Text = "docx";
            }
            else if (cbType.SelectedIndex == 2)
            {
                cbType.Text = "pptx";
            }
            else
            {
                cbType.Text = "xlsx";
            }

            // Nhập kiểu tệp tin từ người dùng
            string fileExtension = cbType.Text;

            // Nhập tên tệp tin từ người dùng
            string fileName = txtFileName.Text;

            string folderPath = txtLocation.Text;

            // Kết hợp tên tệp tin và kiểu tệp tin để tạo đường dẫn đầy đủ
            string filePath = Path.Combine(folderPath, $"{fileName}.{fileExtension}");

            if (fileName == "" || folderPath == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            // Kiểm tra xem tệp tin đã tồn tại chưa
            else if (!File.Exists(filePath))
            {
                // Tạo tệp tin mới
                File.Create(filePath).Close();
                cbType.Items.Clear();
                addItemsType();

                MessageBox.Show("Tệp tin đã được tạo thành công.");

            }
            else
            {
                MessageBox.Show("Tệp tin đã tồn tại.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbSelect.Items.Clear();
            CreateShow();
            MoveHide();
            deleteHide();
        }

        private void lbFoF_Click(object sender, EventArgs e)
        {

        }


        void addItemCBSL()
        {
            cbSelect.Items.Add("Folder");
            cbSelect.Items.Add("File");
            cbSelect.SelectedIndex = 0;
        }

        void addItemsType()
        {
            cbType.Items.Add("Text Document (.txt)");
            cbType.Items.Add("Microsoft Word Document (.docx)");
            cbType.Items.Add("Microsoft PowerPoint Presentation (.pptx)");
            cbType.Items.Add("Microsoft Excel Worksheet (.xlsx)");
            cbType.SelectedIndex = 0;
        }


        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbType.Items.Clear();

            string sl = cbSelect.SelectedItem.ToString();

            if (sl == "Folder")
            {
                cbType.Items.Add("Folder");

            }
            else
            {
                addItemsType();

            }

            cbType.SelectedIndex = 0;

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void viewCreate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateIn_Click(object sender, EventArgs e)
        {

            if (cbSelect.Text == "Folder")
            {
                CreateFolder();
            }
            else
            {
                CreateFile();
            }

            txtFileName.Text = string.Empty;
            txtLocation.Text = string.Empty;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbSelect.Items.Clear();
            cbType.Items.Clear();
            txtFileName.Text = string.Empty;
            txtLocation.Text = string.Empty;
            addItemCBSL();
        }


        private void btnLocation_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại chọn thư mục
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn thư mục hay chưa
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn được chọn
                    string selectedPath = folderDialog.SelectedPath;

                    txtLocation.Text = selectedPath;
                }
            }
        }


        void MoveHide()
        {
            ViewMove.Hide();
            lbFrom.Hide();
            lbTo.Hide();
            lbFoFMove.Hide();
            lbName.Hide();
            txtFrom.Hide();
            txtTo.Hide();
            txtNameMove.Hide();
            btnCancelMove.Hide();
            btnCopy.Hide();
            btnMoveIn.Hide();
            btnSelectFrom.Hide();
            btnSelectTo.Hide();
            cbMove.Hide();
        }


        void MoveShow()
        {
            addItemcbMove();

            ViewMove.Show();
            lbFrom.Show();
            lbTo.Show();
            lbFoFMove.Show();
            lbName.Show();
            txtFrom.Show();
            txtTo.Show();
            txtNameMove.Show();
            btnCancelMove.Show();
            btnCopy.Show();
            btnMoveIn.Show();
            btnSelectFrom.Show();
            btnSelectTo.Show();
            cbMove.Show();
        }


        void addItemcbMove()
        {
            cbMove.Items.Add("Folder");
            cbMove.Items.Add("File");
            cbMove.SelectedIndex = 0;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            cbMove.Items.Clear();
            CreateHide();
            MoveShow();
            deleteHide();
        }

        private void lbTo_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnSelectFrom_Click(object sender, EventArgs e)
        {
            if (cbMove.SelectedIndex == 0)
            {
                // Tạo một hộp thoại chọn thư mục đến
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn thư mục hay chưa
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn được chọn
                        string selectedPath = folderDialog.SelectedPath;

                        txtFrom.Text = selectedPath;

                        string directoryName = Path.GetFileName(selectedPath);
                        txtNameMove.Text = directoryName;
                    }
                }
            }
            else
            {
                // Tạo một hộp thoại chọn thư mục đến
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn thư mục hay chưa
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn được chọn
                        string selectedPath = fileDialog.FileName;

                        txtFrom.Text = selectedPath;

                        string fileName = Path.GetFileName(selectedPath);
                        txtNameMove.Text = fileName;
                    }
                }
            }

        }



        private void btnSelectTo_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại chọn thư mục đến
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn thư mục hay chưa
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn được chọn
                    string selectedPath = folderDialog.SelectedPath;

                    txtTo.Text = selectedPath;
                }
            }
        }

        private void lbFrom_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }


        void cancelMove()
        {
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtNameMove.Text = string.Empty;
        }

        private void cbMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            cancelMove();
        }


        private void txtNameMove_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelMove_Click(object sender, EventArgs e)
        {
            cancelMove();
        }



        void copyFile()
        {
            string sourceFilePath = txtFrom.Text;
            string destinationFolderPath = txtTo.Text;

            string fileName = Path.GetFileName(sourceFilePath);
            string destinationFilePath = Path.Combine(destinationFolderPath, fileName);



            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            // Kiểm tra xem tệp tin đã tồn tại chưa
            else if (!File.Exists(destinationFilePath))
            {
                File.Copy(sourceFilePath, destinationFilePath);

                MessageBox.Show("Tệp tin đã được copy thành công.");

                cancelMove();
            }
            else
            {
                MessageBox.Show("Tệp tin đã tồn tại.");
            }
        }


        void CopyFolder()
        {

            string sourceFolderPath = txtFrom.Text; // đường dẫn thư mục nguồn

            string folderPath = Path.Combine(txtTo.Text, txtNameMove.Text);


            if (txtFrom.Text == "" && txtTo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);

                CopyFolder(sourceFolderPath, folderPath);

                MessageBox.Show("Tệp tin đã được di chuyển thành công.");

                cancelMove();
            }
            else
            {
                MessageBox.Show("Tệp tin đã tồn tại.");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(cbMove.SelectedIndex == 0)
            {
                CopyFolder();
            }
            else
            {
                copyFile();

            }
        }


        void MoveFolder()
        {
            
            string sourceFolderPath = txtFrom.Text; // đường dẫn thư mục nguồn
           
            string folderPath = Path.Combine(txtTo.Text, txtNameMove.Text);

            
            if(txtFrom.Text == "" && txtTo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);

                CopyFolder(sourceFolderPath, folderPath);

                Directory.Delete(txtFrom.Text, true);

                MessageBox.Show("Tệp tin đã được di chuyển thành công.");

                cancelMove();
            }
            else
            {
                MessageBox.Show("Tệp tin đã tồn tại.");
            }
        }

        void CopyFolder(string sourceFolderPath, string destinationFolderPath)
        {

            foreach (string file in Directory.GetFiles(sourceFolderPath))
            {
                string destinationFile = Path.Combine(destinationFolderPath, Path.GetFileName(file));
                File.Copy(file, destinationFile, true);
            }

            foreach (string subDirectory in Directory.GetDirectories(sourceFolderPath))
            {
                string destinationSubDirectory = Path.Combine(destinationFolderPath, new DirectoryInfo(subDirectory).Name);
                CopyFolder(subDirectory, destinationSubDirectory);
            }
        }


        void moveFile()
        {
            string sourceFilePath = txtFrom.Text; 
            string destinationFolderPath = txtTo.Text; 

            string fileName = Path.GetFileName(sourceFilePath);
            string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

            

            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            // Kiểm tra xem tệp tin đã tồn tại chưa
            else if (!File.Exists(destinationFilePath))
            {
                File.Move(sourceFilePath, destinationFilePath);

                File.Delete(txtFrom.Text);

                MessageBox.Show("Tệp tin đã được di chuyển thành công.");
                cancelMove();
            }
            else
            {
                MessageBox.Show("Tệp tin đã tồn tại.");
            }
        }

        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            if(cbMove.SelectedIndex == 0)
            {
                MoveFolder();

            }
            else
            {
                moveFile();
                
            }

        }



        void deleteHide()
        {
            viewDelete.Hide();
            lbFoFDel.Hide();
            lbFromDel.Hide();
            lbNameDelete.Hide();
            cbFoFDel.Hide();
            txtFromDel.Hide();
            txtNameDelete.Hide();
            btnRestore.Hide();
            btnDeleteIn.Hide();
            btnCancelDel.Hide();
            btnFromDel.Hide();
        }



        void deleteShow()
        {
            addItemcbDel();

            viewDelete.Show();
            lbNameDelete.Show();
            lbFoFDel.Show();
            lbFromDel.Show();
            lbNameDelete.Show();
            cbFoFDel.Show();
            txtFromDel.Show();
            txtNameDelete.Show();
            btnRestore.Show();
            btnDeleteIn.Show();
            btnCancelDel.Show();
            btnFromDel.Show();
        }


        void addItemcbDel()
        {
            cbFoFDel.Items.Add("Folder");
            cbFoFDel.Items.Add("File");
            cbFoFDel.SelectedIndex = 0;
        }


        string RePath;
        string restorePath;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cbFoFDel.Items.Clear();
            deleteShow();
            CreateHide();
            MoveHide();

        }

        private void btnFromDel_Click(object sender, EventArgs e)
        {
            if (cbFoFDel.SelectedIndex == 0)
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderDialog.SelectedPath;

                        txtFromDel.Text = selectedPath;

                        string directoryName = Path.GetFileName(selectedPath);
                        txtNameDelete.Text = directoryName;
                    }
                }
            }
            else
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = fileDialog.FileName;

                        txtFromDel.Text = selectedPath;

                        string fileName = Path.GetFileName(selectedPath);
                        txtNameDelete.Text = fileName;
                    }
                }
            }

        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            cancelDel();
        }


        void cancelDel()
        {
            txtFromDel.Text = string.Empty;
            txtNameDelete.Text = string.Empty;
        }


        void DelFolder()
        {

            string sourceFolderPath = txtFromDel.Text; // đường dẫn thư mục nguồn

            string RecycleBin = @"C:\RecycleBin";

            string folderPath = Path.Combine(RecycleBin, txtNameDelete.Text);

            restorePath = folderPath;
            RePath = sourceFolderPath;

            if (txtFromDel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else 
            {
                Directory.CreateDirectory(folderPath);

                CopyFolder(sourceFolderPath, folderPath);

                Directory.Delete(txtFromDel.Text, true);

                MessageBox.Show("Tệp tin đã được xóa thành công.");
                cancelDel();
            }
            
        }


        void DelFile()
        {
            string sourceFilePath = txtFromDel.Text;
            string RecycleBin = @"C:\RecycleBin";

            string fileName = txtNameDelete.Text;
            string destinationFilePath = Path.Combine(RecycleBin, fileName);

            RePath = sourceFilePath;
            restorePath = destinationFilePath;


            if (txtFromDel.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }

            else
            {
                File.Move(sourceFilePath, destinationFilePath);

                File.Delete(txtFromDel.Text);

                MessageBox.Show("Tệp tin đã được xóa thành công.");
                cancelDel();
            }


        }

        private void btnDeleteIn_Click(object sender, EventArgs e)
        {
            if(cbFoFDel.SelectedIndex == 0)
            {
                DelFolder();
               
            }
            else
            {
                DelFile();

            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(cbFoFDel.SelectedIndex == 0)
            {
                if (txtFromDel.Text == "")
                {
                    Directory.CreateDirectory(RePath);

                    CopyFolder(restorePath, RePath);

                    Directory.Delete(restorePath, true);

                    MessageBox.Show("Tệp tin vừa xóa đã được khôi phục thành công.");
                    cancelDel();
                }

            }
            else
            {
                if (txtFromDel.Text == "")
                {
                    File.Move(restorePath, RePath);

                    File.Delete(restorePath);

                    MessageBox.Show("Tệp tin vừa xóa đã được khôi phục thành công.");
                    cancelDel();
                }

            }
            
        }

        private void cbFoFDel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFromDel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
