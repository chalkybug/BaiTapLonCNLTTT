namespace MapWinForm
{
    partial class UserThongKe
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
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.btnThongKeTatCaKhu = new System.Windows.Forms.Button();
            this.btnThongKeTungKhu = new System.Windows.Forms.Button();
            this.dgvThietHai = new System.Windows.Forms.DataGridView();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sovuchay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiethai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.palDamChay = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.palXeCuuHoa = new System.Windows.Forms.Panel();
            this.palTruNuoc = new System.Windows.Forms.Panel();
            this.palTramCuuHoa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.FlatAppearance.BorderSize = 0;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.Location = new System.Drawing.Point(567, 210);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(117, 26);
            this.btnInBaoCao.TabIndex = 16;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(447, 158);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(239, 25);
            this.cmbKhuVuc.TabIndex = 15;
            // 
            // btnThongKeTatCaKhu
            // 
            this.btnThongKeTatCaKhu.FlatAppearance.BorderSize = 0;
            this.btnThongKeTatCaKhu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKeTatCaKhu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTatCaKhu.Location = new System.Drawing.Point(712, 210);
            this.btnThongKeTatCaKhu.Name = "btnThongKeTatCaKhu";
            this.btnThongKeTatCaKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTatCaKhu.TabIndex = 13;
            this.btnThongKeTatCaKhu.Text = "Tất cả khu";
            this.btnThongKeTatCaKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTatCaKhu.Click += new System.EventHandler(this.btnThongKeTatCaKhu_Click);
            // 
            // btnThongKeTungKhu
            // 
            this.btnThongKeTungKhu.FlatAppearance.BorderSize = 0;
            this.btnThongKeTungKhu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKeTungKhu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTungKhu.Location = new System.Drawing.Point(712, 156);
            this.btnThongKeTungKhu.Name = "btnThongKeTungKhu";
            this.btnThongKeTungKhu.Size = new System.Drawing.Size(102, 26);
            this.btnThongKeTungKhu.TabIndex = 14;
            this.btnThongKeTungKhu.Text = "1 khu";
            this.btnThongKeTungKhu.UseVisualStyleBackColor = true;
            this.btnThongKeTungKhu.Click += new System.EventHandler(this.btnThongKeTungKhu_Click);
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
            this.dgvThietHai.Size = new System.Drawing.Size(953, 255);
            this.dgvThietHai.TabIndex = 12;
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
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(162, 211);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(183, 25);
            this.date2.TabIndex = 10;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(162, 158);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(183, 25);
            this.date1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "THỐNG KÊ THIỆT HẠI CỦA CÁC KHU VỰC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khu Vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ:";
            // 
            // palDamChay
            // 
            this.palDamChay.AutoScroll = true;
            this.palDamChay.AutoSize = true;
            this.palDamChay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.palDamChay.Location = new System.Drawing.Point(130, 0);
            this.palDamChay.Name = "palDamChay";
            this.palDamChay.Size = new System.Drawing.Size(147, 13);
            this.palDamChay.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(646, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 57);
            this.button6.TabIndex = 21;
            this.button6.Text = "XE CỨU HỎA";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(470, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 57);
            this.button5.TabIndex = 22;
            this.button5.Text = "TRỤ NƯỚC";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(275, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 57);
            this.button4.TabIndex = 23;
            this.button4.Text = "TRẠM CỨU HỎA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(128, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 57);
            this.button3.TabIndex = 24;
            this.button3.Text = " ĐÁM CHÁY";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThietHai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 255);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(1)))), ((int)(((byte)(4)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.palXeCuuHoa);
            this.panel2.Controls.Add(this.palTruNuoc);
            this.panel2.Controls.Add(this.palTramCuuHoa);
            this.panel2.Controls.Add(this.palDamChay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 75);
            this.panel2.TabIndex = 27;
            // 
            // palXeCuuHoa
            // 
            this.palXeCuuHoa.AutoScroll = true;
            this.palXeCuuHoa.AutoSize = true;
            this.palXeCuuHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.palXeCuuHoa.Location = new System.Drawing.Point(646, 0);
            this.palXeCuuHoa.Name = "palXeCuuHoa";
            this.palXeCuuHoa.Size = new System.Drawing.Size(175, 13);
            this.palXeCuuHoa.TabIndex = 20;
            // 
            // palTruNuoc
            // 
            this.palTruNuoc.AutoScroll = true;
            this.palTruNuoc.AutoSize = true;
            this.palTruNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.palTruNuoc.Location = new System.Drawing.Point(471, 0);
            this.palTruNuoc.Name = "palTruNuoc";
            this.palTruNuoc.Size = new System.Drawing.Size(175, 13);
            this.palTruNuoc.TabIndex = 20;
            // 
            // palTramCuuHoa
            // 
            this.palTramCuuHoa.AutoScroll = true;
            this.palTramCuuHoa.AutoSize = true;
            this.palTramCuuHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.palTramCuuHoa.Location = new System.Drawing.Point(276, 0);
            this.palTramCuuHoa.Name = "palTramCuuHoa";
            this.palTramCuuHoa.Size = new System.Drawing.Size(196, 13);
            this.palTramCuuHoa.TabIndex = 20;
            // 
            // UserThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.btnThongKeTatCaKhu);
            this.Controls.Add(this.btnThongKeTungKhu);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UserThongKe";
            this.Size = new System.Drawing.Size(953, 521);
            this.Load += new System.EventHandler(this.UserThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietHai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInBaoCao;
        public System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.Button btnThongKeTatCaKhu;
        private System.Windows.Forms.Button btnThongKeTungKhu;
        private System.Windows.Forms.DataGridView dgvThietHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sovuchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiethai;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel palDamChay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel palXeCuuHoa;
        private System.Windows.Forms.Panel palTruNuoc;
        private System.Windows.Forms.Panel palTramCuuHoa;
    }
}
