namespace TeamPunkte
{
    partial class Startfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblListe = new System.Windows.Forms.DataGridView();
            this.Platz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPunkte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNeustart = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnMOne = new System.Windows.Forms.Button();
            this.btnMFive = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tblListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblListe
            // 
            this.tblListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platz,
            this.Team,
            this.colPunkte});
            this.tblListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListe.Location = new System.Drawing.Point(0, 0);
            this.tblListe.Name = "tblListe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblListe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblListe.Size = new System.Drawing.Size(764, 446);
            this.tblListe.TabIndex = 7;
            this.tblListe.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tblListe_CellBeginEdit);
            this.tblListe.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.tblListe_SortCompare);
            this.tblListe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tblListe_RowsAdded);
            this.tblListe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.tblListe_RowsRemoved);
            // 
            // Platz
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Platz.DefaultCellStyle = dataGridViewCellStyle1;
            this.Platz.HeaderText = "Platz";
            this.Platz.Name = "Platz";
            this.Platz.ReadOnly = true;
            this.Platz.Width = 55;
            // 
            // Team
            // 
            this.Team.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Team.DefaultCellStyle = dataGridViewCellStyle2;
            this.Team.HeaderText = "Teamname";
            this.Team.Name = "Team";
            this.Team.ToolTipText = "Geben Sie den Teamnamen ein";
            // 
            // colPunkte
            // 
            this.colPunkte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colPunkte.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPunkte.HeaderText = "Punkte";
            this.colPunkte.Name = "colPunkte";
            this.colPunkte.ReadOnly = true;
            this.colPunkte.Width = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNeustart);
            this.panel1.Controls.Add(this.btnToggle);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.btnMOne);
            this.panel1.Controls.Add(this.btnMFive);
            this.panel1.Controls.Add(this.btnTen);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 67);
            this.panel1.TabIndex = 14;
            // 
            // btnNeustart
            // 
            this.btnNeustart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNeustart.Location = new System.Drawing.Point(677, 3);
            this.btnNeustart.Name = "btnNeustart";
            this.btnNeustart.Size = new System.Drawing.Size(75, 59);
            this.btnNeustart.TabIndex = 21;
            this.btnNeustart.Text = "&Punkte löschen";
            this.btnNeustart.UseVisualStyleBackColor = true;
            this.btnNeustart.Click += new System.EventHandler(this.btnNeustart_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(511, 3);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 59);
            this.btnToggle.TabIndex = 20;
            this.btnToggle.Text = "&Bearbeitung beenden";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Enabled = false;
            this.btnColor.Location = new System.Drawing.Point(417, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 59);
            this.btnColor.TabIndex = 19;
            this.btnColor.Text = "&Farbe";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(592, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 59);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "&Sortieren";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnMOne
            // 
            this.btnMOne.Enabled = false;
            this.btnMOne.Location = new System.Drawing.Point(336, 3);
            this.btnMOne.Name = "btnMOne";
            this.btnMOne.Size = new System.Drawing.Size(75, 59);
            this.btnMOne.TabIndex = 17;
            this.btnMOne.Text = "-1";
            this.btnMOne.UseVisualStyleBackColor = true;
            this.btnMOne.Click += new System.EventHandler(this.btnMOne_Click);
            // 
            // btnMFive
            // 
            this.btnMFive.Enabled = false;
            this.btnMFive.Location = new System.Drawing.Point(255, 3);
            this.btnMFive.Name = "btnMFive";
            this.btnMFive.Size = new System.Drawing.Size(75, 59);
            this.btnMFive.TabIndex = 16;
            this.btnMFive.Text = "-5";
            this.btnMFive.UseVisualStyleBackColor = true;
            this.btnMFive.Click += new System.EventHandler(this.btnMFive_Click);
            // 
            // btnTen
            // 
            this.btnTen.Enabled = false;
            this.btnTen.Location = new System.Drawing.Point(174, 3);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 59);
            this.btnTen.TabIndex = 15;
            this.btnTen.Text = "+1&0";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnFive
            // 
            this.btnFive.Enabled = false;
            this.btnFive.Location = new System.Drawing.Point(93, 3);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 59);
            this.btnFive.TabIndex = 14;
            this.btnFive.Text = "+&5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnOne
            // 
            this.btnOne.Enabled = false;
            this.btnOne.Location = new System.Drawing.Point(12, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 59);
            this.btnOne.TabIndex = 13;
            this.btnOne.Text = "+&1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // Startfenster
            // 
            this.AcceptButton = this.btnToggle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNeustart;
            this.ClientSize = new System.Drawing.Size(764, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblListe);
            this.Name = "Startfenster";
            this.Text = "Punktestandzähler - www.cvjm-feriendorf.de";
            ((System.ComponentModel.ISupportInitialize)(this.tblListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblListe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnMOne;
        private System.Windows.Forms.Button btnMFive;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnNeustart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPunkte;
    }
}

