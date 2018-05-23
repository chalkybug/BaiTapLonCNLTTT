namespace GoogleMap
{
    partial class frmThongKe
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
            this.label2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.dgvThietHai = new System.Windows.Forms.DataGridView();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sovuchay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiethai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongKeTungKhu = new System.Windows.Forms.Button();
            this.btnThongKeTatCaKhu = new System.Windows.Forms.Button();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "đến:";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(101, 72);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(183, 25);
            this.date1.TabIndex = 1;
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(101, 125);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(183, 25);
            this.date2.TabIndex = 1;
            // 
            // dgvThietHai
            // 
            this.dgvThietHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diachi,
            this.sovuchay,
            this.thiethai});
            this.dgvThietHai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThietHai.Location = new System.Drawing.Point(0, 175);
            this.dgvThietHai.Name = "dgvThietHai";
            this.dgvThietHai.Size = new System.Drawing.Size(793, 287);
            this.dgvThietHai.TabIndex = 2;
            this.dgvThietHai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietHai_CellContentClick);
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
            // btnThongKeTungKhu
            // 
            this.btnThongKeTungKhu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTungKhu.Location = new System.Drawing.Point(651, 70);
            this.btnThongKeTungKhu.Name = "btnThongKeTungKhu";
            this.btnThongKeTungKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTungKhu.TabIndex = 3;
            this.btnThongKeTungKhu.Text = "1 khu";
            this.btnThongKeTungKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTungKhu.Click += new System.EventHandler(this.btnThongKeTungKhu_Click);
            // 
            // btnThongKeTatCaKhu
            // 
            this.btnThongKeTatCaKhu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTatCaKhu.Location = new System.Drawing.Point(651, 124);
            this.btnThongKeTatCaKhu.Name = "btnThongKeTatCaKhu";
            this.btnThongKeTatCaKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTatCaKhu.TabIndex = 3;
            this.btnThongKeTatCaKhu.Text = "Tất cả khu";
            this.btnThongKeTatCaKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTatCaKhu.Click += new System.EventHandler(this.btnThongKeTatCaKhu_Click);
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(384, 73);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(239, 25);
            this.cmbKhuVuc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "THỐNG KÊ THIỆT HẠI CỦA CÁC KHU VỰC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khu Vực:";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.Location = new System.Drawing.Point(506, 124);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(117, 26);
            this.btnInBaoCao.TabIndex = 5;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.btnThongKeTatCaKhu);
            this.Controls.Add(this.btnThongKeTungKhu);
            this.Controls.Add(this.dgvThietHai);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DataGridView dgvThietHai;
        private System.Windows.Forms.Button btnThongKeTungKhu;
        private System.Windows.Forms.Button btnThongKeTatCaKhu;
        public System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sovuchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiethai;
        private System.Windows.Forms.Button btnInBaoCao;
    }
}