namespace GoogleMap
{
    partial class frmSoXeTrong
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
            this.btnGoiXe = new System.Windows.Forms.Button();
            this.dgvXeDuocChon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoXeTrong = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDuocChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoXeTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoiXe
            // 
            this.btnGoiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiXe.Location = new System.Drawing.Point(378, 264);
            this.btnGoiXe.Name = "btnGoiXe";
            this.btnGoiXe.Size = new System.Drawing.Size(93, 29);
            this.btnGoiXe.TabIndex = 5;
            this.btnGoiXe.Text = "Gọi Xe";
            this.btnGoiXe.UseVisualStyleBackColor = true;
            this.btnGoiXe.Click += new System.EventHandler(this.btnGoiXe_Click);
            // 
            // dgvXeDuocChon
            // 
            this.dgvXeDuocChon.AllowDrop = true;
            this.dgvXeDuocChon.AllowUserToAddRows = false;
            this.dgvXeDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeDuocChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvXeDuocChon.Location = new System.Drawing.Point(461, 47);
            this.dgvXeDuocChon.Name = "dgvXeDuocChon";
            this.dgvXeDuocChon.Size = new System.Drawing.Size(376, 182);
            this.dgvXeDuocChon.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // dgvSoXeTrong
            // 
            this.dgvSoXeTrong.AllowUserToAddRows = false;
            this.dgvSoXeTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoXeTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.capacity,
            this.maxHeight,
            this.size,
            this.status});
            this.dgvSoXeTrong.Location = new System.Drawing.Point(14, 47);
            this.dgvSoXeTrong.Name = "dgvSoXeTrong";
            this.dgvSoXeTrong.Size = new System.Drawing.Size(384, 182);
            this.dgvSoXeTrong.TabIndex = 4;
            this.dgvSoXeTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoXeTrong_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "capacity";
            this.capacity.Name = "capacity";
            // 
            // maxHeight
            // 
            this.maxHeight.DataPropertyName = "maxHeight";
            this.maxHeight.HeaderText = "maxHeight";
            this.maxHeight.Name = "maxHeight";
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "size";
            this.size.Name = "size";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số xe trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xe được chọn";
            // 
            // frmSoXeTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoiXe);
            this.Controls.Add(this.dgvXeDuocChon);
            this.Controls.Add(this.dgvSoXeTrong);
            this.Name = "frmSoXeTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSoXeTrong";
            this.Load += new System.EventHandler(this.frmSoXeTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDuocChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoXeTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoiXe;
        private System.Windows.Forms.DataGridView dgvXeDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgvSoXeTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}