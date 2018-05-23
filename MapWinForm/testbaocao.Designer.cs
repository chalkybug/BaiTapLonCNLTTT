namespace MapWinForm
{
    partial class testbaocao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCaoThietHai = new MapWinForm.BaoCaoThietHai();
            this.DamChayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DamChayTableAdapter = new MapWinForm.BaoCaoThietHaiTableAdapters.DamChayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoThietHai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamChayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DamChayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MapWinForm.rptBaoCaoThietHai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // BaoCaoThietHai
            // 
            this.BaoCaoThietHai.DataSetName = "BaoCaoThietHai";
            this.BaoCaoThietHai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DamChayBindingSource
            // 
            this.DamChayBindingSource.DataMember = "DamChay";
            this.DamChayBindingSource.DataSource = this.BaoCaoThietHai;
            // 
            // DamChayTableAdapter
            // 
            this.DamChayTableAdapter.ClearBeforeFill = true;
            // 
            // testbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "testbaocao";
            this.Text = "testbaocao";
            this.Load += new System.EventHandler(this.testbaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoThietHai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamChayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DamChayBindingSource;
        private BaoCaoThietHai BaoCaoThietHai;
        private BaoCaoThietHaiTableAdapters.DamChayTableAdapter DamChayTableAdapter;
    }
}