namespace GoogleMap
{
    partial class frmDamChay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapDo = new System.Windows.Forms.TextBox();
            this.lbltp = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.lblQuan = new System.Windows.Forms.Label();
            this.txtQuanHuyen = new System.Windows.Forms.TextBox();
            this.lbldc = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTHietHai = new System.Windows.Forms.Label();
            this.txtThietHai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.dgvDamChay = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dateNgayChay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.county = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamChay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(109, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 25);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cấp độ:";
            // 
            // txtCapDo
            // 
            this.txtCapDo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapDo.Location = new System.Drawing.Point(401, 35);
            this.txtCapDo.Name = "txtCapDo";
            this.txtCapDo.Size = new System.Drawing.Size(145, 25);
            this.txtCapDo.TabIndex = 1;
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltp.Location = new System.Drawing.Point(669, 38);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(73, 17);
            this.lbltp.TabIndex = 0;
            this.lbltp.Text = "Thành phố:";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhPho.Location = new System.Drawing.Point(750, 32);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(145, 25);
            this.txtThanhPho.TabIndex = 1;
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuan.Location = new System.Drawing.Point(22, 81);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(85, 17);
            this.lblQuan.TabIndex = 0;
            this.lblQuan.Text = "Quận, huyện:";
            // 
            // txtQuanHuyen
            // 
            this.txtQuanHuyen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanHuyen.Location = new System.Drawing.Point(109, 78);
            this.txtQuanHuyen.Name = "txtQuanHuyen";
            this.txtQuanHuyen.Size = new System.Drawing.Size(145, 25);
            this.txtQuanHuyen.TabIndex = 1;
            // 
            // lbldc
            // 
            this.lbldc.AutoSize = true;
            this.lbldc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldc.Location = new System.Drawing.Point(346, 81);
            this.lbldc.Name = "lbldc";
            this.lbldc.Size = new System.Drawing.Size(53, 17);
            this.lbldc.TabIndex = 0;
            this.lbldc.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(401, 81);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(145, 25);
            this.txtDiaChi.TabIndex = 1;
            // 
            // lblTHietHai
            // 
            this.lblTHietHai.AutoSize = true;
            this.lblTHietHai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHietHai.Location = new System.Drawing.Point(682, 81);
            this.lblTHietHai.Name = "lblTHietHai";
            this.lblTHietHai.Size = new System.Drawing.Size(62, 17);
            this.lblTHietHai.TabIndex = 0;
            this.lblTHietHai.Text = "Thiệt hại:";
            // 
            // txtThietHai
            // 
            this.txtThietHai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThietHai.Location = new System.Drawing.Point(750, 78);
            this.txtThietHai.Name = "txtThietHai";
            this.txtThietHai.Size = new System.Drawing.Size(145, 25);
            this.txtThietHai.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lat:";
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(401, 123);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(145, 25);
            this.txtLat.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(682, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lng:";
            // 
            // txtLng
            // 
            this.txtLng.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLng.Location = new System.Drawing.Point(750, 120);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(145, 25);
            this.txtLng.TabIndex = 1;
            // 
            // dgvDamChay
            // 
            this.dgvDamChay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.level,
            this.city,
            this.county,
            this.address,
            this.damages,
            this.date,
            this.lat,
            this.lng});
            this.dgvDamChay.Location = new System.Drawing.Point(0, 238);
            this.dgvDamChay.Name = "dgvDamChay";
            this.dgvDamChay.Size = new System.Drawing.Size(936, 283);
            this.dgvDamChay.TabIndex = 2;
            this.dgvDamChay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamChay_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(109, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(336, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 33);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(547, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dateNgayChay
            // 
            this.dateNgayChay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayChay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayChay.Location = new System.Drawing.Point(109, 122);
            this.dateNgayChay.Name = "dateNgayChay";
            this.dateNgayChay.Size = new System.Drawing.Size(145, 25);
            this.dateNgayChay.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCapDo);
            this.groupBox1.Controls.Add(this.dateNgayChay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblQuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLng);
            this.groupBox1.Controls.Add(this.txtQuanHuyen);
            this.groupBox1.Controls.Add(this.txtThietHai);
            this.groupBox1.Controls.Add(this.lbldc);
            this.groupBox1.Controls.Add(this.txtThanhPho);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTHietHai);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.lbltp);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đám cháy";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "Cấp độ";
            this.level.Name = "level";
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "Thành phố";
            this.city.Name = "city";
            // 
            // county
            // 
            this.county.DataPropertyName = "county";
            this.county.HeaderText = "Quận Huyện";
            this.county.Name = "county";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            // 
            // damages
            // 
            this.damages.DataPropertyName = "damages";
            this.damages.HeaderText = "Thiệt hại";
            this.damages.Name = "damages";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Ngày";
            this.date.Name = "date";
            // 
            // lat
            // 
            this.lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lat.DataPropertyName = "lat";
            this.lat.HeaderText = "Lat";
            this.lat.Name = "lat";
            // 
            // lng
            // 
            this.lng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lng.DataPropertyName = "lng";
            this.lng.HeaderText = "Lng";
            this.lng.Name = "lng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(726, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDamChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 521);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDamChay);
            this.Name = "frmDamChay";
            this.Text = "Quản lý đám cháy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamChay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapDo;
        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.TextBox txtQuanHuyen;
        private System.Windows.Forms.Label lbldc;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTHietHai;
        private System.Windows.Forms.TextBox txtThietHai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.DataGridView dgvDamChay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateNgayChay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn county;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn damages;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn lng;
        private System.Windows.Forms.Button btnThoat;
    }
}