namespace GoogleMap
{
    partial class frmBaoCaoThietHai
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
            this.DamChayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBaoCaoThietHai = new GoogleMap.DataSetBaoCaoThietHai();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DamChayTableAdapter = new GoogleMap.DataSetBaoCaoThietHaiTableAdapters.DamChayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DamChayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCaoThietHai)).BeginInit();
            this.SuspendLayout();
            // 
            // DamChayBindingSource
            // 
            this.DamChayBindingSource.DataMember = "DamChay";
            this.DamChayBindingSource.DataSource = this.DataSetBaoCaoThietHai;
            // 
            // DataSetBaoCaoThietHai
            // 
            this.DataSetBaoCaoThietHai.DataSetName = "DataSetBaoCaoThietHai";
            this.DataSetBaoCaoThietHai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DamChayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GoogleMap.rptBaoCaoThietHai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // DamChayTableAdapter
            // 
            this.DamChayTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoThietHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoThietHai";
            this.Text = "frmBaoCaoThietHai";
            this.Load += new System.EventHandler(this.frmBaoCaoThietHai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DamChayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBaoCaoThietHai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DamChayBindingSource;
        private DataSetBaoCaoThietHai DataSetBaoCaoThietHai;
        private DataSetBaoCaoThietHaiTableAdapters.DamChayTableAdapter DamChayTableAdapter;
    }
}