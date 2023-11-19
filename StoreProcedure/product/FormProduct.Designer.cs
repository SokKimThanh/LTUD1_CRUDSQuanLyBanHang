namespace WinFormsApp2.StoreProcedure.product
{
    partial class FormProduct
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
            dgvProduct = new DataGridView();
            btnadd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            txtMaSP = new TextBox();
            cboLoaiSP = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTenSP = new TextBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            txtGiaSP = new TextBox();
            label5 = new Label();
            cboNhaCungCap = new ComboBox();
            label6 = new Label();
            btnSearch = new Button();
            txtKeyWord = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(0, 300);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowTemplate.Height = 28;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(782, 150);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(3, 256);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(123, 38);
            btnadd.TabIndex = 1;
            btnadd.Text = "add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoEllipsis = true;
            btnEdit.Location = new Point(155, 256);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(291, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete\r\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(420, 256);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 38);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtMaSP
            // 
            txtMaSP.Enabled = false;
            txtMaSP.Location = new Point(3, 51);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(275, 26);
            txtMaSP.TabIndex = 2;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(291, 50);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(252, 27);
            cboLoaiSP.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 4;
            label1.Text = "masp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 4;
            label2.Text = "loaisp";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(2, 114);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(275, 26);
            txtTenSP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 4;
            label3.Text = "tensp";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(292, 166);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(252, 26);
            txtSoLuong.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 144);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 4;
            label4.Text = "so luong";
            // 
            // txtGiaSP
            // 
            txtGiaSP.Location = new Point(3, 166);
            txtGiaSP.Name = "txtGiaSP";
            txtGiaSP.Size = new Size(275, 26);
            txtGiaSP.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 144);
            label5.Name = "label5";
            label5.Size = new Size(27, 19);
            label5.TabIndex = 4;
            label5.Text = "gia";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(291, 114);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(252, 27);
            cboNhaCungCap.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 92);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 4;
            label6.Text = "nhacungcap";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(549, 256);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(221, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(549, 224);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(221, 26);
            txtKeyWord.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 202);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 4;
            label7.Text = "Từ khóa";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtGiaSP);
            Controls.Add(label1);
            Controls.Add(txtKeyWord);
            Controls.Add(txtSoLuong);
            Controls.Add(cboNhaCungCap);
            Controls.Add(cboLoaiSP);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnadd);
            Controls.Add(dgvProduct);
            Name = "FormProduct";
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private Button btnadd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private TextBox txtMaSP;
        private ComboBox cboLoaiSP;
        private Label label1;
        private Label label2;
        private TextBox txtTenSP;
        private Label label3;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtGiaSP;
        private Label label5;
        private ComboBox cboNhaCungCap;
        private Label label6;
        private Button btnSearch;
        private TextBox txtKeyWord;
        private Label label7;
    }
}