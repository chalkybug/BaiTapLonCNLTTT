namespace GoogleMap
{
    partial class userControlTruNuoc1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTruNuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTHietHai = new System.Windows.Forms.Label();
            this.lbltp = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lbldc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtQH = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.lblQuan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruNuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "lng";
            this.Column6.HeaderText = "Lng";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "lat";
            this.Column5.HeaderText = "Lat";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "address";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "county";
            this.Column3.HeaderText = "Quận, Huyện";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "city";
            this.Column2.HeaderText = "Thành phố";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // dgvTruNuoc
            // 
            this.dgvTruNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTruNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTruNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTruNuoc.Location = new System.Drawing.Point(0, 231);
            this.dgvTruNuoc.Name = "dgvTruNuoc";
            this.dgvTruNuoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTruNuoc.Size = new System.Drawing.Size(968, 261);
            this.dgvTruNuoc.TabIndex = 72;
            this.dgvTruNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTruNuoc_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTHietHai);
            this.groupBox1.Controls.Add(this.lbltp);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.lbldc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLng);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.txtQH);
            this.groupBox1.Controls.Add(this.txtTP);
            this.groupBox1.Controls.Add(this.lblQuan);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 167);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Trụ Nước";
            // 
            // lblTHietHai
            // 
            this.lblTHietHai.AutoSize = true;
            this.lblTHietHai.Location = new System.Drawing.Point(621, 99);
            this.lblTHietHai.Name = "lblTHietHai";
            this.lblTHietHai.Size = new System.Drawing.Size(35, 19);
            this.lblTHietHai.TabIndex = 84;
            this.lblTHietHai.Text = "Lng:";
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Location = new System.Drawing.Point(624, 42);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(32, 19);
            this.lbltp.TabIndex = 80;
            this.lbltp.Text = "Lat:";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(419, 92);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(145, 26);
            this.txtDC.TabIndex = 87;
            // 
            // lbldc
            // 
            this.lbldc.AutoSize = true;
            this.lbldc.Location = new System.Drawing.Point(354, 99);
            this.lbldc.Name = "lbldc";
            this.lbldc.Size = new System.Drawing.Size(54, 19);
            this.lbldc.TabIndex = 83;
            this.lbldc.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Quận, Huyện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "ID:";
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(677, 92);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(196, 26);
            this.txtLng.TabIndex = 91;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(677, 35);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(196, 26);
            this.txtLat.TabIndex = 90;
            // 
            // txtQH
            // 
            this.txtQH.Location = new System.Drawing.Point(419, 35);
            this.txtQH.Name = "txtQH";
            this.txtQH.Size = new System.Drawing.Size(145, 26);
            this.txtQH.TabIndex = 89;
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(110, 92);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(145, 26);
            this.txtTP.TabIndex = 88;
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(22, 99);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(76, 19);
            this.lblQuan.TabIndex = 81;
            this.lblQuan.Text = "Thành phố:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 26);
            this.txtID.TabIndex = 86;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Maroon;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(624, 175);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 35);
            this.btnHuy.TabIndex = 79;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Maroon;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(480, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 78;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Maroon;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(765, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 37);
            this.btnThoat.TabIndex = 77;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(347, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 34);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Maroon;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(218, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 34);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Maroon;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(83, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 34);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // userControlTruNuoc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTruNuoc);
            this.Name = "userControlTruNuoc1";
            this.Size = new System.Drawing.Size(968, 492);
            this.Load += new System.EventHandler(this.userControlTruNuoc1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruNuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvTruNuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTHietHai;
        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label lbldc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtQH;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
