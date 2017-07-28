namespace QlikRelease
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoteToDev = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RefreshDev = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PromoteToProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RefreshProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.PromoteToDev,
            this.RefreshDev,
            this.PromoteToProd,
            this.RefreshProd});
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // PromoteToDev
            // 
            this.PromoteToDev.HeaderText = "Promote to Dev";
            this.PromoteToDev.Name = "PromoteToDev";
            // 
            // RefreshDev
            // 
            this.RefreshDev.HeaderText = "Refresh Dev";
            this.RefreshDev.Name = "RefreshDev";
            // 
            // PromoteToProd
            // 
            this.PromoteToProd.HeaderText = "Promote to Prod";
            this.PromoteToProd.Name = "PromoteToProd";
            // 
            // RefreshProd
            // 
            this.RefreshProd.HeaderText = "Refresh Prod";
            this.RefreshProd.Name = "RefreshProd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "QlikView EBIA-IT Promotion Request Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PromoteToDev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RefreshDev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PromoteToProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RefreshProd;
        private System.Windows.Forms.Label label1;
    }
}

