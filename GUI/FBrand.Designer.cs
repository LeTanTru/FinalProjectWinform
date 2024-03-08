﻿namespace GUI {
    partial class frmBrand {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddBrand = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelAddBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.dgvProduct;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(930, 0);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 510);
            this.guna2VScrollBar1.TabIndex = 13;
            this.guna2VScrollBar1.Value = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.dgvProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 25;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Brand,
            this.Edit,
            this.Delete});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.Size = new System.Drawing.Size(948, 510);
            this.dgvProduct.TabIndex = 12;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvProduct.ThemeStyle.ReadOnly = true;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel1.Controls.Add(this.dgvProduct);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(948, 510);
            this.guna2Panel1.TabIndex = 17;
            // 
            // panelAddBrand
            // 
            this.panelAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelAddBrand.Controls.Add(this.txtSearch);
            this.panelAddBrand.Controls.Add(this.btnAddBrand);
            this.panelAddBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddBrand.Location = new System.Drawing.Point(0, 0);
            this.panelAddBrand.Name = "panelAddBrand";
            this.panelAddBrand.Size = new System.Drawing.Size(948, 43);
            this.panelAddBrand.TabIndex = 16;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnAddBrand.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBrand.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBrand.Image = global::GUI.Properties.Resources.add_30px;
            this.btnAddBrand.Location = new System.Drawing.Point(768, 0);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(180, 43);
            this.btnAddBrand.TabIndex = 14;
            this.btnAddBrand.Text = "Thêm thương hiệu";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.close_window_30px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit_20px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::GUI.Properties.Resources.search_30px;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm....";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(768, 43);
            this.txtSearch.TabIndex = 15;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 54;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 74;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::GUI.Properties.Resources.edit_20px;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 17;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::GUI.Properties.Resources.delete_20px;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrand";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panelAddBrand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2Panel panelAddBrand;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}