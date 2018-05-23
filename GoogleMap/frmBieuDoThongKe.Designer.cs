namespace GoogleMap
{
    partial class frmBieuDoThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartThongKeThietHai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKeThietHai = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeThietHai)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKeThietHai
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKeThietHai.ChartAreas.Add(chartArea1);
            this.chartThongKeThietHai.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartThongKeThietHai.Legends.Add(legend1);
            this.chartThongKeThietHai.Location = new System.Drawing.Point(0, 0);
            this.chartThongKeThietHai.Name = "chartThongKeThietHai";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "c";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKeThietHai.Series.Add(series1);
            this.chartThongKeThietHai.Size = new System.Drawing.Size(507, 447);
            this.chartThongKeThietHai.TabIndex = 0;
            this.chartThongKeThietHai.Text = "Thống kê thiệt hại";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.BorderWidth = 2;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ thống kê thiệt hại";
            this.chartThongKeThietHai.Titles.Add(title1);
            // 
            // btnThongKeThietHai
            // 
            this.btnThongKeThietHai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeThietHai.Location = new System.Drawing.Point(600, 265);
            this.btnThongKeThietHai.Name = "btnThongKeThietHai";
            this.btnThongKeThietHai.Size = new System.Drawing.Size(107, 44);
            this.btnThongKeThietHai.TabIndex = 1;
            this.btnThongKeThietHai.Text = "Thống kê thiệt hại";
            this.btnThongKeThietHai.UseVisualStyleBackColor = true;
            this.btnThongKeThietHai.Click += new System.EventHandler(this.btnThongKeThietHai_Click);
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(578, 118);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 22);
            this.date1.TabIndex = 2;
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(578, 169);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 22);
            this.date2.TabIndex = 2;
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(578, 218);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(200, 23);
            this.cmbKhuVuc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khu vực:";
            // 
            // frmBieuDoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.btnThongKeThietHai);
            this.Controls.Add(this.chartThongKeThietHai);
            this.Name = "frmBieuDoThongKe";
            this.Text = "Biểu đồ thống kê thiệt hại";
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeThietHai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeThietHai;
        private System.Windows.Forms.Button btnThongKeThietHai;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}