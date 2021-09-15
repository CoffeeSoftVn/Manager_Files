
namespace Manager_Files
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_DriveA = new System.Windows.Forms.ComboBox();
            this.btn_RefreshA = new System.Windows.Forms.Button();
            this.btn_BackA = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_DriveB = new System.Windows.Forms.ComboBox();
            this.btn_RefreshB = new System.Windows.Forms.Button();
            this.btn_BackB = new System.Windows.Forms.Button();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.SELECT_A = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NAME_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZE_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.SELECT_B = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NAME_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZE_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_PathA = new System.Windows.Forms.TextBox();
            this.txt_PathB = new System.Windows.Forms.TextBox();
            this.contextMenuStripA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_SelectAll_A = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_UnSelectAll_A = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_ContrarySelect_A = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_SelectAll_B = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_UnSelectAll_B = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_ContrarySelect_B = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_NewFolder_A = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Delete_A = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Rename_A = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_NewFolder_B = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Delete_B = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Rename_B = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.contextMenuStripA.SuspendLayout();
            this.contextMenuStripB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewA, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_PathA, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_PathB, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 358);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.Controls.Add(this.cbo_DriveA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_RefreshA, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_BackA, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 29);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cbo_DriveA
            // 
            this.cbo_DriveA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_DriveA.FormattingEnabled = true;
            this.cbo_DriveA.Location = new System.Drawing.Point(3, 3);
            this.cbo_DriveA.Name = "cbo_DriveA";
            this.cbo_DriveA.Size = new System.Drawing.Size(416, 23);
            this.cbo_DriveA.TabIndex = 0;
            // 
            // btn_RefreshA
            // 
            this.btn_RefreshA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RefreshA.Image = global::Manager_Files.Properties.Resources.Refresh;
            this.btn_RefreshA.Location = new System.Drawing.Point(422, 0);
            this.btn_RefreshA.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RefreshA.Name = "btn_RefreshA";
            this.btn_RefreshA.Size = new System.Drawing.Size(55, 29);
            this.btn_RefreshA.TabIndex = 1;
            this.btn_RefreshA.UseVisualStyleBackColor = true;
            // 
            // btn_BackA
            // 
            this.btn_BackA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BackA.Image = global::Manager_Files.Properties.Resources.BackPath;
            this.btn_BackA.Location = new System.Drawing.Point(477, 0);
            this.btn_BackA.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BackA.Name = "btn_BackA";
            this.btn_BackA.Size = new System.Drawing.Size(55, 29);
            this.btn_BackA.TabIndex = 2;
            this.btn_BackA.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.Controls.Add(this.cbo_DriveB, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_RefreshB, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_BackB, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(545, 37);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(532, 29);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // cbo_DriveB
            // 
            this.cbo_DriveB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_DriveB.FormattingEnabled = true;
            this.cbo_DriveB.Location = new System.Drawing.Point(3, 3);
            this.cbo_DriveB.Name = "cbo_DriveB";
            this.cbo_DriveB.Size = new System.Drawing.Size(416, 23);
            this.cbo_DriveB.TabIndex = 0;
            // 
            // btn_RefreshB
            // 
            this.btn_RefreshB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RefreshB.Image = global::Manager_Files.Properties.Resources.Refresh;
            this.btn_RefreshB.Location = new System.Drawing.Point(422, 0);
            this.btn_RefreshB.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RefreshB.Name = "btn_RefreshB";
            this.btn_RefreshB.Size = new System.Drawing.Size(55, 29);
            this.btn_RefreshB.TabIndex = 1;
            this.btn_RefreshB.UseVisualStyleBackColor = true;
            // 
            // btn_BackB
            // 
            this.btn_BackB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BackB.Image = global::Manager_Files.Properties.Resources.BackPath;
            this.btn_BackB.Location = new System.Drawing.Point(477, 0);
            this.btn_BackB.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BackB.Name = "btn_BackB";
            this.btn_BackB.Size = new System.Drawing.Size(55, 29);
            this.btn_BackB.TabIndex = 2;
            this.btn_BackB.UseVisualStyleBackColor = true;
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AllowUserToDeleteRows = false;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT_A,
            this.NAME_A,
            this.TYPE_A,
            this.SIZE_A,
            this.DATE_A});
            this.dataGridViewA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewA.Location = new System.Drawing.Point(5, 74);
            this.dataGridViewA.MultiSelect = false;
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.ReadOnly = true;
            this.dataGridViewA.RowTemplate.Height = 25;
            this.dataGridViewA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewA.Size = new System.Drawing.Size(532, 247);
            this.dataGridViewA.TabIndex = 2;
            // 
            // SELECT_A
            // 
            this.SELECT_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SELECT_A.DataPropertyName = "SELECT_A";
            this.SELECT_A.HeaderText = "SELECT";
            this.SELECT_A.Name = "SELECT_A";
            this.SELECT_A.ReadOnly = true;
            this.SELECT_A.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECT_A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SELECT_A.Width = 70;
            // 
            // NAME_A
            // 
            this.NAME_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME_A.DataPropertyName = "NAME_A";
            this.NAME_A.HeaderText = "NAME";
            this.NAME_A.Name = "NAME_A";
            this.NAME_A.ReadOnly = true;
            // 
            // TYPE_A
            // 
            this.TYPE_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYPE_A.DataPropertyName = "TYPE_A";
            this.TYPE_A.HeaderText = "TYPE";
            this.TYPE_A.Name = "TYPE_A";
            this.TYPE_A.ReadOnly = true;
            // 
            // SIZE_A
            // 
            this.SIZE_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SIZE_A.DataPropertyName = "SIZE_A";
            this.SIZE_A.HeaderText = "SIZE";
            this.SIZE_A.Name = "SIZE_A";
            this.SIZE_A.ReadOnly = true;
            // 
            // DATE_A
            // 
            this.DATE_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE_A.DataPropertyName = "DATE_A";
            this.DATE_A.HeaderText = "DATE";
            this.DATE_A.Name = "DATE_A";
            this.DATE_A.ReadOnly = true;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT_B,
            this.NAME_B,
            this.TYPE_B,
            this.SIZE_B,
            this.DATE_B});
            this.dataGridViewB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewB.Location = new System.Drawing.Point(545, 74);
            this.dataGridViewB.MultiSelect = false;
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.ReadOnly = true;
            this.dataGridViewB.RowTemplate.Height = 25;
            this.dataGridViewB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewB.Size = new System.Drawing.Size(532, 247);
            this.dataGridViewB.TabIndex = 3;
            // 
            // SELECT_B
            // 
            this.SELECT_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SELECT_B.DataPropertyName = "SELECT_B";
            this.SELECT_B.HeaderText = "SELECT";
            this.SELECT_B.Name = "SELECT_B";
            this.SELECT_B.ReadOnly = true;
            this.SELECT_B.Width = 51;
            // 
            // NAME_B
            // 
            this.NAME_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME_B.DataPropertyName = "NAME_B";
            this.NAME_B.HeaderText = "NAME";
            this.NAME_B.Name = "NAME_B";
            this.NAME_B.ReadOnly = true;
            // 
            // TYPE_B
            // 
            this.TYPE_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYPE_B.DataPropertyName = "TYPE_B";
            this.TYPE_B.HeaderText = "TYPE";
            this.TYPE_B.Name = "TYPE_B";
            this.TYPE_B.ReadOnly = true;
            // 
            // SIZE_B
            // 
            this.SIZE_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SIZE_B.DataPropertyName = "SIZE_B";
            this.SIZE_B.HeaderText = "SIZE";
            this.SIZE_B.Name = "SIZE_B";
            this.SIZE_B.ReadOnly = true;
            // 
            // DATE_B
            // 
            this.DATE_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE_B.DataPropertyName = "DATE_B";
            this.DATE_B.HeaderText = "DATE";
            this.DATE_B.Name = "DATE_B";
            this.DATE_B.ReadOnly = true;
            // 
            // txt_PathA
            // 
            this.txt_PathA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PathA.Location = new System.Drawing.Point(5, 329);
            this.txt_PathA.Name = "txt_PathA";
            this.txt_PathA.ReadOnly = true;
            this.txt_PathA.Size = new System.Drawing.Size(532, 23);
            this.txt_PathA.TabIndex = 4;
            // 
            // txt_PathB
            // 
            this.txt_PathB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PathB.Location = new System.Drawing.Point(545, 329);
            this.txt_PathB.Name = "txt_PathB";
            this.txt_PathB.ReadOnly = true;
            this.txt_PathB.Size = new System.Drawing.Size(532, 23);
            this.txt_PathB.TabIndex = 5;
            // 
            // contextMenuStripA
            // 
            this.contextMenuStripA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_SelectAll_A,
            this.StripMenuItem_UnSelectAll_A,
            this.StripMenuItem_ContrarySelect_A,
            this.toolStripSeparator2,
            this.StripMenuItem_NewFolder_A,
            this.StripMenuItem_Delete_A,
            this.StripMenuItem_Rename_A});
            this.contextMenuStripA.Name = "contextMenuStripA";
            this.contextMenuStripA.Size = new System.Drawing.Size(155, 142);
            // 
            // StripMenuItem_SelectAll_A
            // 
            this.StripMenuItem_SelectAll_A.Image = global::Manager_Files.Properties.Resources.SelectAll;
            this.StripMenuItem_SelectAll_A.Name = "StripMenuItem_SelectAll_A";
            this.StripMenuItem_SelectAll_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_SelectAll_A.Text = "Select All";
            // 
            // StripMenuItem_UnSelectAll_A
            // 
            this.StripMenuItem_UnSelectAll_A.Image = global::Manager_Files.Properties.Resources.UnSelectAll;
            this.StripMenuItem_UnSelectAll_A.Name = "StripMenuItem_UnSelectAll_A";
            this.StripMenuItem_UnSelectAll_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_UnSelectAll_A.Text = "UnSelect All";
            // 
            // StripMenuItem_ContrarySelect_A
            // 
            this.StripMenuItem_ContrarySelect_A.Image = global::Manager_Files.Properties.Resources.InverseSelectAll;
            this.StripMenuItem_ContrarySelect_A.Name = "StripMenuItem_ContrarySelect_A";
            this.StripMenuItem_ContrarySelect_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_ContrarySelect_A.Text = "Contrary Select";
            // 
            // contextMenuStripB
            // 
            this.contextMenuStripB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_SelectAll_B,
            this.StripMenuItem_UnSelectAll_B,
            this.StripMenuItem_ContrarySelect_B,
            this.toolStripSeparator1,
            this.StripMenuItem_NewFolder_B,
            this.StripMenuItem_Delete_B,
            this.StripMenuItem_Rename_B});
            this.contextMenuStripB.Name = "contextMenuStripB";
            this.contextMenuStripB.Size = new System.Drawing.Size(155, 142);
            // 
            // StripMenuItem_SelectAll_B
            // 
            this.StripMenuItem_SelectAll_B.Image = global::Manager_Files.Properties.Resources.SelectAll;
            this.StripMenuItem_SelectAll_B.Name = "StripMenuItem_SelectAll_B";
            this.StripMenuItem_SelectAll_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_SelectAll_B.Text = "Select All";
            // 
            // StripMenuItem_UnSelectAll_B
            // 
            this.StripMenuItem_UnSelectAll_B.Image = global::Manager_Files.Properties.Resources.UnSelectAll;
            this.StripMenuItem_UnSelectAll_B.Name = "StripMenuItem_UnSelectAll_B";
            this.StripMenuItem_UnSelectAll_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_UnSelectAll_B.Text = "UnSelect All";
            // 
            // StripMenuItem_ContrarySelect_B
            // 
            this.StripMenuItem_ContrarySelect_B.Image = global::Manager_Files.Properties.Resources.InverseSelectAll;
            this.StripMenuItem_ContrarySelect_B.Name = "StripMenuItem_ContrarySelect_B";
            this.StripMenuItem_ContrarySelect_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_ContrarySelect_B.Text = "Contrary Select";
            // 
            // StripMenuItem_NewFolder_A
            // 
            this.StripMenuItem_NewFolder_A.Name = "StripMenuItem_NewFolder_A";
            this.StripMenuItem_NewFolder_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_NewFolder_A.Text = "New Folder";
            // 
            // StripMenuItem_Delete_A
            // 
            this.StripMenuItem_Delete_A.Name = "StripMenuItem_Delete_A";
            this.StripMenuItem_Delete_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_Delete_A.Text = "Delete";
            // 
            // StripMenuItem_Rename_A
            // 
            this.StripMenuItem_Rename_A.Name = "StripMenuItem_Rename_A";
            this.StripMenuItem_Rename_A.Size = new System.Drawing.Size(154, 22);
            this.StripMenuItem_Rename_A.Text = "Rename";
            // 
            // StripMenuItem_NewFolder_B
            // 
            this.StripMenuItem_NewFolder_B.Name = "StripMenuItem_NewFolder_B";
            this.StripMenuItem_NewFolder_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_NewFolder_B.Text = "New Folder";
            // 
            // StripMenuItem_Delete_B
            // 
            this.StripMenuItem_Delete_B.Name = "StripMenuItem_Delete_B";
            this.StripMenuItem_Delete_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_Delete_B.Text = "Delete";
            // 
            // StripMenuItem_Rename_B
            // 
            this.StripMenuItem_Rename_B.Name = "StripMenuItem_Rename_B";
            this.StripMenuItem_Rename_B.Size = new System.Drawing.Size(180, 22);
            this.StripMenuItem_Rename_B.Text = "Rename";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_Main";
            this.Text = "Manager_Files";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.contextMenuStripA.ResumeLayout(false);
            this.contextMenuStripB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbo_DriveA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cbo_DriveB;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.TextBox txt_PathA;
        private System.Windows.Forms.TextBox txt_PathB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZE_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_A;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZE_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_B;
        private System.Windows.Forms.Button btn_RefreshA;
        private System.Windows.Forms.Button btn_BackA;
        private System.Windows.Forms.Button btn_RefreshB;
        private System.Windows.Forms.Button btn_BackB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripB;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_SelectAll_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_UnSelectAll_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_ContrarySelect_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_SelectAll_B;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_UnSelectAll_B;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_ContrarySelect_B;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_NewFolder_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Delete_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Rename_A;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_NewFolder_B;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Delete_B;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Rename_B;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}