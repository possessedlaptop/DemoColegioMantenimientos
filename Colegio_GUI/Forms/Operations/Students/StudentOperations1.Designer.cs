namespace Colegio_GUI.Forms.Operations.Students
{
    partial class StudentOperations1
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
            label1 = new Label();
            txtSearchBar = new TextBox();
            dtgData = new DataGridView();
            label2 = new Label();
            lblEntries = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Search by Last Name: ";
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(154, 9);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(334, 23);
            txtSearchBar.TabIndex = 1;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // dtgData
            // 
            dtgData.AllowUserToOrderColumns = true;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(12, 51);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgData.Size = new Size(1188, 331);
            dtgData.TabIndex = 2;
            dtgData.DoubleClick += dtgData_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1039, 17);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Entries: ";
            // 
            // lblEntries
            // 
            lblEntries.BorderStyle = BorderStyle.FixedSingle;
            lblEntries.Location = new Point(1083, 13);
            lblEntries.Name = "lblEntries";
            lblEntries.Size = new Size(100, 23);
            lblEntries.TabIndex = 4;
            lblEntries.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(554, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(704, 404);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 48);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(853, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(1039, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 48);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // StudentOperations1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 473);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblEntries);
            Controls.Add(label2);
            Controls.Add(dtgData);
            Controls.Add(txtSearchBar);
            Controls.Add(label1);
            Name = "StudentOperations1";
            Text = "StudentOperations1";
            Load += StudentOperations1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchBar;
        private DataGridView dtgData;
        private Label label2;
        private Label lblEntries;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
    }
}