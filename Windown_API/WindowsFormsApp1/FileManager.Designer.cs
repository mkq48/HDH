namespace WindowsFormsApp1
{
    partial class FileManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lbFoF = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.viewCreate = new System.Windows.Forms.ListView();
            this.lbLocation = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.ViewMove = new System.Windows.Forms.ListView();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtNameMove = new System.Windows.Forms.TextBox();
            this.btnSelectFrom = new System.Windows.Forms.Button();
            this.btnMoveIn = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCancelMove = new System.Windows.Forms.Button();
            this.btnSelectTo = new System.Windows.Forms.Button();
            this.cbMove = new System.Windows.Forms.ComboBox();
            this.lbFoFMove = new System.Windows.Forms.Label();
            this.btnCancelDel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDeleteIn = new System.Windows.Forms.Button();
            this.txtNameDelete = new System.Windows.Forms.TextBox();
            this.lbNameDelete = new System.Windows.Forms.Label();
            this.viewDelete = new System.Windows.Forms.ListView();
            this.lbFoFDel = new System.Windows.Forms.Label();
            this.cbFoFDel = new System.Windows.Forms.ComboBox();
            this.btnFromDel = new System.Windows.Forms.Button();
            this.txtFromDel = new System.Windows.Forms.TextBox();
            this.lbFromDel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(50, 46);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 70);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(361, 78);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(281, 24);
            this.cbSelect.TabIndex = 1;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // lbFoF
            // 
            this.lbFoF.AutoSize = true;
            this.lbFoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoF.Location = new System.Drawing.Point(228, 79);
            this.lbFoF.Name = "lbFoF";
            this.lbFoF.Size = new System.Drawing.Size(95, 18);
            this.lbFoF.TabIndex = 2;
            this.lbFoF.Text = "Folder or File";
            this.lbFoF.Click += new System.EventHandler(this.lbFoF_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(228, 125);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(67, 18);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "File Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(361, 124);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(281, 24);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // viewCreate
            // 
            this.viewCreate.HideSelection = false;
            this.viewCreate.Location = new System.Drawing.Point(163, 29);
            this.viewCreate.Name = "viewCreate";
            this.viewCreate.Size = new System.Drawing.Size(551, 305);
            this.viewCreate.TabIndex = 5;
            this.viewCreate.UseCompatibleStateImageBehavior = false;
            this.viewCreate.SelectedIndexChanged += new System.EventHandler(this.viewCreate_SelectedIndexChanged);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(228, 172);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(65, 18);
            this.lbLocation.TabIndex = 6;
            this.lbLocation.Text = "Location";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(50, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 70);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateIn
            // 
            this.btnCreateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIn.Location = new System.Drawing.Point(468, 266);
            this.btnCreateIn.Name = "btnCreateIn";
            this.btnCreateIn.Size = new System.Drawing.Size(80, 35);
            this.btnCreateIn.TabIndex = 11;
            this.btnCreateIn.Text = "Create";
            this.btnCreateIn.UseVisualStyleBackColor = true;
            this.btnCreateIn.Click += new System.EventHandler(this.btnCreateIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(562, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(228, 221);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(75, 18);
            this.lbFileName.TabIndex = 14;
            this.lbFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(361, 216);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(281, 22);
            this.txtFileName.TabIndex = 15;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(648, 168);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(29, 23);
            this.btnLocation.TabIndex = 16;
            this.btnLocation.Text = "-";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(361, 169);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(281, 22);
            this.txtLocation.TabIndex = 17;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(50, 143);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(80, 70);
            this.btnMove.TabIndex = 18;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // ViewMove
            // 
            this.ViewMove.HideSelection = false;
            this.ViewMove.Location = new System.Drawing.Point(163, 29);
            this.ViewMove.Name = "ViewMove";
            this.ViewMove.Size = new System.Drawing.Size(551, 305);
            this.ViewMove.TabIndex = 19;
            this.ViewMove.UseCompatibleStateImageBehavior = false;
            this.ViewMove.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(226, 120);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(44, 18);
            this.lbFrom.TabIndex = 20;
            this.lbFrom.Text = "From";
            this.lbFrom.Click += new System.EventHandler(this.lbFrom_Click);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(228, 170);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(26, 18);
            this.lbTo.TabIndex = 21;
            this.lbTo.Text = "To";
            this.lbTo.Click += new System.EventHandler(this.lbTo_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(226, 218);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 18);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(328, 117);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(281, 22);
            this.txtFrom.TabIndex = 25;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(328, 166);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(281, 22);
            this.txtTo.TabIndex = 26;
            // 
            // txtNameMove
            // 
            this.txtNameMove.Location = new System.Drawing.Point(328, 214);
            this.txtNameMove.Name = "txtNameMove";
            this.txtNameMove.ReadOnly = true;
            this.txtNameMove.Size = new System.Drawing.Size(281, 22);
            this.txtNameMove.TabIndex = 27;
            this.txtNameMove.TextChanged += new System.EventHandler(this.txtNameMove_TextChanged);
            // 
            // btnSelectFrom
            // 
            this.btnSelectFrom.Location = new System.Drawing.Point(632, 116);
            this.btnSelectFrom.Name = "btnSelectFrom";
            this.btnSelectFrom.Size = new System.Drawing.Size(29, 23);
            this.btnSelectFrom.TabIndex = 28;
            this.btnSelectFrom.Text = "-";
            this.btnSelectFrom.UseVisualStyleBackColor = true;
            this.btnSelectFrom.Click += new System.EventHandler(this.btnSelectFrom_Click);
            // 
            // btnMoveIn
            // 
            this.btnMoveIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveIn.Location = new System.Drawing.Point(323, 270);
            this.btnMoveIn.Name = "btnMoveIn";
            this.btnMoveIn.Size = new System.Drawing.Size(80, 35);
            this.btnMoveIn.TabIndex = 30;
            this.btnMoveIn.Text = "Move";
            this.btnMoveIn.UseVisualStyleBackColor = true;
            this.btnMoveIn.Click += new System.EventHandler(this.btnMoveIn_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(223, 270);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 35);
            this.btnCopy.TabIndex = 31;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCancelMove
            // 
            this.btnCancelMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMove.Location = new System.Drawing.Point(572, 270);
            this.btnCancelMove.Name = "btnCancelMove";
            this.btnCancelMove.Size = new System.Drawing.Size(80, 35);
            this.btnCancelMove.TabIndex = 32;
            this.btnCancelMove.Text = "Cancel";
            this.btnCancelMove.UseVisualStyleBackColor = true;
            this.btnCancelMove.Click += new System.EventHandler(this.btnCancelMove_Click);
            // 
            // btnSelectTo
            // 
            this.btnSelectTo.Location = new System.Drawing.Point(632, 165);
            this.btnSelectTo.Name = "btnSelectTo";
            this.btnSelectTo.Size = new System.Drawing.Size(29, 23);
            this.btnSelectTo.TabIndex = 33;
            this.btnSelectTo.Text = "-";
            this.btnSelectTo.UseVisualStyleBackColor = true;
            this.btnSelectTo.Click += new System.EventHandler(this.btnSelectTo_Click);
            // 
            // cbMove
            // 
            this.cbMove.FormattingEnabled = true;
            this.cbMove.Location = new System.Drawing.Point(328, 66);
            this.cbMove.Name = "cbMove";
            this.cbMove.Size = new System.Drawing.Size(281, 24);
            this.cbMove.TabIndex = 34;
            this.cbMove.SelectedIndexChanged += new System.EventHandler(this.cbMove_SelectedIndexChanged);
            // 
            // lbFoFMove
            // 
            this.lbFoFMove.AutoSize = true;
            this.lbFoFMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoFMove.Location = new System.Drawing.Point(208, 68);
            this.lbFoFMove.Name = "lbFoFMove";
            this.lbFoFMove.Size = new System.Drawing.Size(95, 18);
            this.lbFoFMove.TabIndex = 35;
            this.lbFoFMove.Text = "Folder or File";
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDel.Location = new System.Drawing.Point(572, 262);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(80, 35);
            this.btnCancelDel.TabIndex = 52;
            this.btnCancelDel.Text = "Cancel";
            this.btnCancelDel.UseVisualStyleBackColor = true;
            this.btnCancelDel.Click += new System.EventHandler(this.btnCancelDel_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(223, 262);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 35);
            this.btnRestore.TabIndex = 51;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDeleteIn
            // 
            this.btnDeleteIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIn.Location = new System.Drawing.Point(323, 262);
            this.btnDeleteIn.Name = "btnDeleteIn";
            this.btnDeleteIn.Size = new System.Drawing.Size(80, 35);
            this.btnDeleteIn.TabIndex = 50;
            this.btnDeleteIn.Text = "Delete";
            this.btnDeleteIn.UseVisualStyleBackColor = true;
            this.btnDeleteIn.Click += new System.EventHandler(this.btnDeleteIn_Click);
            // 
            // txtNameDelete
            // 
            this.txtNameDelete.Location = new System.Drawing.Point(328, 188);
            this.txtNameDelete.Name = "txtNameDelete";
            this.txtNameDelete.ReadOnly = true;
            this.txtNameDelete.Size = new System.Drawing.Size(281, 22);
            this.txtNameDelete.TabIndex = 49;
            // 
            // lbNameDelete
            // 
            this.lbNameDelete.AutoSize = true;
            this.lbNameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameDelete.Location = new System.Drawing.Point(226, 192);
            this.lbNameDelete.Name = "lbNameDelete";
            this.lbNameDelete.Size = new System.Drawing.Size(48, 18);
            this.lbNameDelete.TabIndex = 48;
            this.lbNameDelete.Text = "Name";
            // 
            // viewDelete
            // 
            this.viewDelete.HideSelection = false;
            this.viewDelete.Location = new System.Drawing.Point(163, 29);
            this.viewDelete.Name = "viewDelete";
            this.viewDelete.Size = new System.Drawing.Size(551, 305);
            this.viewDelete.TabIndex = 47;
            this.viewDelete.UseCompatibleStateImageBehavior = false;
            // 
            // lbFoFDel
            // 
            this.lbFoFDel.AutoSize = true;
            this.lbFoFDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoFDel.Location = new System.Drawing.Point(208, 89);
            this.lbFoFDel.Name = "lbFoFDel";
            this.lbFoFDel.Size = new System.Drawing.Size(95, 18);
            this.lbFoFDel.TabIndex = 57;
            this.lbFoFDel.Text = "Folder or File";
            // 
            // cbFoFDel
            // 
            this.cbFoFDel.FormattingEnabled = true;
            this.cbFoFDel.Location = new System.Drawing.Point(328, 87);
            this.cbFoFDel.Name = "cbFoFDel";
            this.cbFoFDel.Size = new System.Drawing.Size(281, 24);
            this.cbFoFDel.TabIndex = 56;
            this.cbFoFDel.SelectedIndexChanged += new System.EventHandler(this.cbFoFDel_SelectedIndexChanged);
            // 
            // btnFromDel
            // 
            this.btnFromDel.Location = new System.Drawing.Point(632, 137);
            this.btnFromDel.Name = "btnFromDel";
            this.btnFromDel.Size = new System.Drawing.Size(29, 23);
            this.btnFromDel.TabIndex = 55;
            this.btnFromDel.Text = "-";
            this.btnFromDel.UseVisualStyleBackColor = true;
            this.btnFromDel.Click += new System.EventHandler(this.btnFromDel_Click);
            // 
            // txtFromDel
            // 
            this.txtFromDel.Location = new System.Drawing.Point(328, 138);
            this.txtFromDel.Name = "txtFromDel";
            this.txtFromDel.Size = new System.Drawing.Size(281, 22);
            this.txtFromDel.TabIndex = 54;
            this.txtFromDel.TextChanged += new System.EventHandler(this.txtFromDel_TextChanged);
            // 
            // lbFromDel
            // 
            this.lbFromDel.AutoSize = true;
            this.lbFromDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromDel.Location = new System.Drawing.Point(226, 141);
            this.lbFromDel.Name = "lbFromDel";
            this.lbFromDel.Size = new System.Drawing.Size(44, 18);
            this.lbFromDel.TabIndex = 53;
            this.lbFromDel.Text = "From";
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 384);
            this.Controls.Add(this.lbFoFDel);
            this.Controls.Add(this.cbFoFDel);
            this.Controls.Add(this.btnFromDel);
            this.Controls.Add(this.txtFromDel);
            this.Controls.Add(this.lbFromDel);
            this.Controls.Add(this.btnCancelDel);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnDeleteIn);
            this.Controls.Add(this.txtNameDelete);
            this.Controls.Add(this.lbNameDelete);
            this.Controls.Add(this.viewDelete);
            this.Controls.Add(this.lbFoFMove);
            this.Controls.Add(this.cbMove);
            this.Controls.Add(this.btnSelectTo);
            this.Controls.Add(this.btnCancelMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMoveIn);
            this.Controls.Add(this.btnSelectFrom);
            this.Controls.Add(this.txtNameMove);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.ViewMove);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateIn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbFoF);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.viewCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lbFoF;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ListView viewCreate;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListView ViewMove;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtNameMove;
        private System.Windows.Forms.Button btnSelectFrom;
        private System.Windows.Forms.Button btnMoveIn;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCancelMove;
        private System.Windows.Forms.Button btnSelectTo;
        private System.Windows.Forms.ComboBox cbMove;
        private System.Windows.Forms.Label lbFoFMove;
        private System.Windows.Forms.Button btnCancelDel;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDeleteIn;
        private System.Windows.Forms.TextBox txtNameDelete;
        private System.Windows.Forms.Label lbNameDelete;
        private System.Windows.Forms.ListView viewDelete;
        private System.Windows.Forms.Label lbFoFDel;
        private System.Windows.Forms.ComboBox cbFoFDel;
        private System.Windows.Forms.Button btnFromDel;
        private System.Windows.Forms.TextBox txtFromDel;
        private System.Windows.Forms.Label lbFromDel;
    }
}