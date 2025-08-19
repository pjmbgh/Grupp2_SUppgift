namespace Grupp2_SUppgift
{
    partial class frmStart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lagDBDataSet = new Grupp2_SUppgift.LagDBDataSet();
            this.fKtblLagtblSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLagTableAdapter = new Grupp2_SUppgift.LagDBDataSetTableAdapters.tblLagTableAdapter();
            this.btnNyttLag = new System.Windows.Forms.Button();
            this.cmbValjLag = new System.Windows.Forms.ComboBox();
            this.tblLagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSportTableAdapter = new Grupp2_SUppgift.LagDBDataSetTableAdapters.tblSportTableAdapter();
            this.txtLagEtt = new System.Windows.Forms.TextBox();
            this.txtLagTva = new System.Windows.Forms.TextBox();
            this.txtLagTre = new System.Windows.Forms.TextBox();
            this.txtLagFyra = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVresultat = new System.Windows.Forms.DataGridView();
            this.Resultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTabell = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSparaT = new System.Windows.Forms.Button();
            this.txtSpara = new System.Windows.Forms.TextBox();
            this.btnResultat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblLagtblSportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVresultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTabell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.lagDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // lagDBDataSet
            // 
            this.lagDBDataSet.DataSetName = "LagDBDataSet";
            this.lagDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKtblLagtblSportBindingSource
            // 
            this.fKtblLagtblSportBindingSource.DataMember = "FK_tblLag_tblSport";
            this.fKtblLagtblSportBindingSource.DataSource = this.tblSportBindingSource;
            // 
            // tblSportBindingSource
            // 
            this.tblSportBindingSource.DataMember = "tblSport";
            this.tblSportBindingSource.DataSource = this.bindingSource1;
            // 
            // tblLagBindingSource
            // 
            this.tblLagBindingSource.DataMember = "tblLag";
            this.tblLagBindingSource.DataSource = this.bindingSource1;
            // 
            // tblLagTableAdapter
            // 
            this.tblLagTableAdapter.ClearBeforeFill = true;
            // 
            // btnNyttLag
            // 
            this.btnNyttLag.Location = new System.Drawing.Point(14, 458);
            this.btnNyttLag.Name = "btnNyttLag";
            this.btnNyttLag.Size = new System.Drawing.Size(142, 37);
            this.btnNyttLag.TabIndex = 1;
            this.btnNyttLag.Text = "Lägg till nytt lag";
            this.btnNyttLag.UseVisualStyleBackColor = true;
            this.btnNyttLag.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbValjLag
            // 
            this.cmbValjLag.DataSource = this.tblSportBindingSource;
            this.cmbValjLag.DisplayMember = "SportNamn";
            this.cmbValjLag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValjLag.FormattingEnabled = true;
            this.cmbValjLag.Location = new System.Drawing.Point(13, 41);
            this.cmbValjLag.Name = "cmbValjLag";
            this.cmbValjLag.Size = new System.Drawing.Size(142, 24);
            this.cmbValjLag.TabIndex = 2;
            this.cmbValjLag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbValjLag_MouseClick);
            // 
            // tblLagBindingSource1
            // 
            this.tblLagBindingSource1.DataMember = "tblLag";
            this.tblLagBindingSource1.DataSource = this.bindingSource1;
            // 
            // tblSportTableAdapter
            // 
            this.tblSportTableAdapter.ClearBeforeFill = true;
            // 
            // txtLagEtt
            // 
            this.txtLagEtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagEtt.Location = new System.Drawing.Point(12, 137);
            this.txtLagEtt.Name = "txtLagEtt";
            this.txtLagEtt.Size = new System.Drawing.Size(141, 22);
            this.txtLagEtt.TabIndex = 3;
            // 
            // txtLagTva
            // 
            this.txtLagTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagTva.Location = new System.Drawing.Point(12, 163);
            this.txtLagTva.Name = "txtLagTva";
            this.txtLagTva.Size = new System.Drawing.Size(141, 22);
            this.txtLagTva.TabIndex = 4;
            // 
            // txtLagTre
            // 
            this.txtLagTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagTre.Location = new System.Drawing.Point(12, 189);
            this.txtLagTre.Name = "txtLagTre";
            this.txtLagTre.Size = new System.Drawing.Size(141, 22);
            this.txtLagTre.TabIndex = 5;
            // 
            // txtLagFyra
            // 
            this.txtLagFyra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagFyra.Location = new System.Drawing.Point(12, 215);
            this.txtLagFyra.Name = "txtLagFyra";
            this.txtLagFyra.Size = new System.Drawing.Size(141, 22);
            this.txtLagFyra.TabIndex = 6;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(11, 255);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(142, 37);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "KÖR!";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "RENSA!";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 543);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 37);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "AVSLUTA!";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKtblLagtblSportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(161, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 220);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lagDataGridViewTextBoxColumn
            // 
            this.lagDataGridViewTextBoxColumn.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn.Name = "lagDataGridViewTextBoxColumn";
            // 
            // DGVresultat
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.DGVresultat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVresultat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVresultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVresultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resultat});
            this.DGVresultat.Location = new System.Drawing.Point(310, 12);
            this.DGVresultat.Name = "DGVresultat";
            this.DGVresultat.Size = new System.Drawing.Size(243, 220);
            this.DGVresultat.TabIndex = 13;
            // 
            // Resultat
            // 
            this.Resultat.HeaderText = "Resultat";
            this.Resultat.MinimumWidth = 50;
            this.Resultat.Name = "Resultat";
            this.Resultat.Width = 200;
            // 
            // DGVTabell
            // 
            this.DGVTabell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVTabell.BackgroundColor = System.Drawing.Color.Black;
            this.DGVTabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTabell.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVTabell.Location = new System.Drawing.Point(161, 415);
            this.DGVTabell.Name = "DGVTabell";
            this.DGVTabell.Size = new System.Drawing.Size(744, 165);
            this.DGVTabell.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(727, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(791, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btnSparaT
            // 
            this.btnSparaT.Location = new System.Drawing.Point(753, 358);
            this.btnSparaT.Name = "btnSparaT";
            this.btnSparaT.Size = new System.Drawing.Size(152, 51);
            this.btnSparaT.TabIndex = 18;
            this.btnSparaT.Text = "Spara Tabellen";
            this.btnSparaT.UseVisualStyleBackColor = true;
            this.btnSparaT.Click += new System.EventHandler(this.btnSparaT_Click);
            // 
            // txtSpara
            // 
            this.txtSpara.Location = new System.Drawing.Point(753, 334);
            this.txtSpara.Name = "txtSpara";
            this.txtSpara.Size = new System.Drawing.Size(116, 20);
            this.txtSpara.TabIndex = 19;
            // 
            // btnResultat
            // 
            this.btnResultat.Location = new System.Drawing.Point(15, 415);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(142, 37);
            this.btnResultat.TabIndex = 20;
            this.btnResultat.Text = "Visa resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            this.btnResultat.Click += new System.EventHandler(this.btnResultat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(556, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ange ett värde och tryck spara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Välj sport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Valda lag för gruppspel";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResultat);
            this.Controls.Add(this.txtSpara);
            this.Controls.Add(this.btnSparaT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGVTabell);
            this.Controls.Add(this.DGVresultat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtLagFyra);
            this.Controls.Add(this.txtLagTre);
            this.Controls.Add(this.txtLagTva);
            this.Controls.Add(this.txtLagEtt);
            this.Controls.Add(this.cmbValjLag);
            this.Controls.Add(this.btnNyttLag);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmStart";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "SportApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblLagtblSportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVresultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTabell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private LagDBDataSet lagDBDataSet;
        private System.Windows.Forms.BindingSource tblLagBindingSource;
        private LagDBDataSetTableAdapters.tblLagTableAdapter tblLagTableAdapter;
        private System.Windows.Forms.Button btnNyttLag;
        private System.Windows.Forms.ComboBox cmbValjLag;
        private System.Windows.Forms.BindingSource tblLagBindingSource1;
        private System.Windows.Forms.BindingSource tblSportBindingSource;
        private LagDBDataSetTableAdapters.tblSportTableAdapter tblSportTableAdapter;
        private System.Windows.Forms.BindingSource fKtblLagtblSportBindingSource;
        private System.Windows.Forms.TextBox txtLagEtt;
        private System.Windows.Forms.TextBox txtLagTva;
        private System.Windows.Forms.TextBox txtLagTre;
        private System.Windows.Forms.TextBox txtLagFyra;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGVresultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultat;
        private System.Windows.Forms.DataGridView DGVTabell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSparaT;
        private System.Windows.Forms.TextBox txtSpara;
        private System.Windows.Forms.Button btnResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

