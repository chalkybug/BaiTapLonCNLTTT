﻿namespace GoogleMap
{
    partial class UserControlThongKeDanhSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.btnThongKeTatCaKhu = new System.Windows.Forms.Button();
            this.btnThongKeTungKhu = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThietHai = new System.Windows.Forms.DataGridView();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sovuchay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiethai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnInBaoCao);
            this.panel1.Controls.Add(this.cmbKhuVuc);
            this.panel1.Controls.Add(this.btnThongKeTatCaKhu);
            this.panel1.Controls.Add(this.btnThongKeTungKhu);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 195);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.Location = new System.Drawing.Point(574, 131);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(117, 26);
            this.btnInBaoCao.TabIndex = 15;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(452, 80);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(239, 25);
            this.cmbKhuVuc.TabIndex = 14;
            // 
            // btnThongKeTatCaKhu
            // 
            this.btnThongKeTatCaKhu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeTatCaKhu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTatCaKhu.Location = new System.Drawing.Point(719, 131);
            this.btnThongKeTatCaKhu.Name = "btnThongKeTatCaKhu";
            this.btnThongKeTatCaKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTatCaKhu.TabIndex = 12;
            this.btnThongKeTatCaKhu.Text = "Tất cả khu";
            this.btnThongKeTatCaKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTatCaKhu.Click += new System.EventHandler(this.btnThongKeTatCaKhu_Click);
            // 
            // btnThongKeTungKhu
            // 
            this.btnThongKeTungKhu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeTungKhu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTungKhu.Location = new System.Drawing.Point(719, 77);
            this.btnThongKeTungKhu.Name = "btnThongKeTungKhu";
            this.btnThongKeTungKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTungKhu.TabIndex = 13;
            this.btnThongKeTungKhu.Text = "1 khu";
            this.btnThongKeTungKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTungKhu.Click += new System.EventHandler(this.btnThongKeTungKhu_Click);
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(169, 132);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(183, 25);
            this.date2.TabIndex = 10;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(169, 79);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(183, 25);
            this.date1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "THỐNG KÊ THIỆT HẠI CỦA CÁC KHU VỰC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khu Vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThietHai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 332);
            this.panel2.TabIndex = 1;
            // 
            // dgvThietHai
            // 
            this.dgvThietHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diachi,
            this.sovuchay,
            this.thiethai});
            this.dgvThietHai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThietHai.Location = new System.Drawing.Point(0, 0);
            this.dgvThietHai.Name = "dgvThietHai";
            this.dgvThietHai.Size = new System.Drawing.Size(954, 332);
            this.dgvThietHai.TabIndex = 3;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 320;
            // 
            // sovuchay
            // 
            this.sovuchay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sovuchay.DataPropertyName = "sovuchay";
            this.sovuchay.HeaderText = "Sô vụ cháy";
            this.sovuchay.Name = "sovuchay";
            // 
            // thiethai
            // 
            this.thiethai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thiethai.DataPropertyName = "thiethai";
            this.thiethai.HeaderText = "Thiệt Hại";
            this.thiethai.Name = "thiethai";
            // 
            // UserControlThongKeDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlThongKeDanhSach";
            this.Size = new System.Drawing.Size(954, 527);
            this.Load += new System.EventHandler(this.UserControlThongKeDanhSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInBaoCao;
        public System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.Button btnThongKeTatCaKhu;
        private System.Windows.Forms.Button btnThongKeTungKhu;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThietHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sovuchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiethai;
    }
}
