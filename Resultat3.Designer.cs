namespace Grupp2_SUppgift
{
    partial class frmResultat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultat));
            this.DGVVisaResultat = new System.Windows.Forms.DataGridView();
            this.cmbValjResultat = new System.Windows.Forms.ComboBox();
            this.btnVisaCmb = new System.Windows.Forms.Button();
            this.btnAvsl = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisaResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVVisaResultat
            // 
            this.DGVVisaResultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVVisaResultat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVVisaResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisaResultat.Location = new System.Drawing.Point(13, 120);
            this.DGVVisaResultat.Name = "DGVVisaResultat";
            this.DGVVisaResultat.Size = new System.Drawing.Size(775, 292);
            this.DGVVisaResultat.TabIndex = 0;
            // 
            // cmbValjResultat
            // 
            this.cmbValjResultat.FormattingEnabled = true;
            this.cmbValjResultat.Location = new System.Drawing.Point(12, 12);
            this.cmbValjResultat.Name = "cmbValjResultat";
            this.cmbValjResultat.Size = new System.Drawing.Size(160, 21);
            this.cmbValjResultat.TabIndex = 1;
            // 
            // btnVisaCmb
            // 
            this.btnVisaCmb.Location = new System.Drawing.Point(178, 12);
            this.btnVisaCmb.Name = "btnVisaCmb";
            this.btnVisaCmb.Size = new System.Drawing.Size(158, 21);
            this.btnVisaCmb.TabIndex = 2;
            this.btnVisaCmb.Text = "Visa resultat";
            this.btnVisaCmb.UseVisualStyleBackColor = true;
            this.btnVisaCmb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVisaCmb_MouseClick);
            // 
            // btnAvsl
            // 
            this.btnAvsl.Location = new System.Drawing.Point(630, 46);
            this.btnAvsl.Name = "btnAvsl";
            this.btnAvsl.Size = new System.Drawing.Size(158, 28);
            this.btnAvsl.TabIndex = 3;
            this.btnAvsl.Text = "Avsluta";
            this.btnAvsl.UseVisualStyleBackColor = true;
            this.btnAvsl.Click += new System.EventHandler(this.btnAvsl_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(630, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 28);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Gå till start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAvsl);
            this.Controls.Add(this.btnVisaCmb);
            this.Controls.Add(this.cmbValjResultat);
            this.Controls.Add(this.DGVVisaResultat);
            this.Name = "frmResultat";
            this.Text = "Resultat";
            this.Load += new System.EventHandler(this.Resultat3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisaResultat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVVisaResultat;
        private System.Windows.Forms.ComboBox cmbValjResultat;
        private System.Windows.Forms.Button btnVisaCmb;
        private System.Windows.Forms.Button btnAvsl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}