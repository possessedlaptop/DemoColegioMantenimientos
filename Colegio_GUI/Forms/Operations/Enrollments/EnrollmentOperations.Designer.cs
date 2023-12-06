namespace Colegio_GUI.Forms.Operations.Enrollments
{
    partial class EnrollmentOperations
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
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblEntries = new Label();
            label2 = new Label();
            dtgData = new DataGridView();
            txtSearchBar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(1039, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 48);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(853, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 48);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(704, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 48);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(554, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 48);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblEntries
            // 
            lblEntries.BorderStyle = BorderStyle.FixedSingle;
            lblEntries.Location = new Point(1083, 19);
            lblEntries.Name = "lblEntries";
            lblEntries.Size = new Size(100, 23);
            lblEntries.TabIndex = 10;
            lblEntries.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1039, 23);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Entries: ";
            // 
            // dtgData
            // 
            dtgData.AllowUserToOrderColumns = true;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(12, 57);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgData.Size = new Size(1188, 331);
            dtgData.TabIndex = 8;
            dtgData.DoubleClick += dtgData_DoubleClick;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(154, 15);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(334, 23);
            txtSearchBar.TabIndex = 7;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Search: ";
            // 
            // EnrollmentOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            Name = "EnrollmentOperations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment Operations";
            Load += EnrollmentOperations_Load;
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblEntries;
        private Label label2;
        private DataGridView dtgData;
        private TextBox txtSearchBar;
        private Label label1;
    }
}