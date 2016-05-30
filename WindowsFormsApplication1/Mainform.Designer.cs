namespace WindowsFormsApplication1
{
    partial class mainForm
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
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfromStation = new System.Windows.Forms.TextBox();
            this.txttoStation = new System.Windows.Forms.TextBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.btnDepartures = new System.Windows.Forms.Button();
            this.rbTimeTable = new System.Windows.Forms.RadioButton();
            this.rbDepartueTable = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bntMail = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMapsFrom = new System.Windows.Forms.Button();
            this.btnMapsTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeTable.Location = new System.Drawing.Point(100, 214);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(120, 23);
            this.btnTimeTable.TabIndex = 0;
            this.btnTimeTable.Text = "Fahrplan suchen";
            this.btnTimeTable.UseVisualStyleBackColor = true;
            this.btnTimeTable.Click += new System.EventHandler(this.searchTimeTable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nach";
            // 
            // txtfromStation
            // 
            this.txtfromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromStation.Location = new System.Drawing.Point(89, 83);
            this.txtfromStation.Name = "txtfromStation";
            this.txtfromStation.Size = new System.Drawing.Size(212, 22);
            this.txtfromStation.TabIndex = 8;
            this.txtfromStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.showAutoCompletion);
            // 
            // txttoStation
            // 
            this.txttoStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoStation.Location = new System.Drawing.Point(89, 113);
            this.txttoStation.Name = "txttoStation";
            this.txttoStation.Size = new System.Drawing.Size(212, 22);
            this.txttoStation.TabIndex = 9;
            this.txttoStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.showAutoCompletion);
            // 
            // dgvConnections
            // 
            this.dgvConnections.AllowUserToAddRows = false;
            this.dgvConnections.AllowUserToDeleteRows = false;
            this.dgvConnections.AllowUserToResizeColumns = false;
            this.dgvConnections.AllowUserToResizeRows = false;
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConnections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Location = new System.Drawing.Point(38, 257);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ReadOnly = true;
            this.dgvConnections.RowHeadersWidth = 25;
            this.dgvConnections.RowTemplate.Height = 35;
            this.dgvConnections.Size = new System.Drawing.Size(353, 216);
            this.dgvConnections.TabIndex = 10;
            // 
            // btnDepartures
            // 
            this.btnDepartures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartures.Location = new System.Drawing.Point(100, 214);
            this.btnDepartures.Name = "btnDepartures";
            this.btnDepartures.Size = new System.Drawing.Size(120, 23);
            this.btnDepartures.TabIndex = 12;
            this.btnDepartures.Text = "Abfahrt suchen";
            this.btnDepartures.UseVisualStyleBackColor = true;
            this.btnDepartures.Visible = false;
            this.btnDepartures.Click += new System.EventHandler(this.searchDepatures);
            // 
            // rbTimeTable
            // 
            this.rbTimeTable.Checked = true;
            this.rbTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTimeTable.Location = new System.Drawing.Point(90, 22);
            this.rbTimeTable.Name = "rbTimeTable";
            this.rbTimeTable.Size = new System.Drawing.Size(103, 29);
            this.rbTimeTable.TabIndex = 13;
            this.rbTimeTable.TabStop = true;
            this.rbTimeTable.Text = "Fahrplan";
            this.rbTimeTable.UseVisualStyleBackColor = true;
            this.rbTimeTable.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // rbDepartueTable
            // 
            this.rbDepartueTable.AutoSize = true;
            this.rbDepartueTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartueTable.Location = new System.Drawing.Point(217, 24);
            this.rbDepartueTable.Name = "rbDepartueTable";
            this.rbDepartueTable.Size = new System.Drawing.Size(119, 24);
            this.rbDepartueTable.TabIndex = 14;
            this.rbDepartueTable.Text = "Abfahrtstafel";
            this.rbDepartueTable.UseVisualStyleBackColor = true;
            this.rbDepartueTable.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 2);
            this.label3.TabIndex = 15;
            // 
            // bntMail
            // 
            this.bntMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMail.Location = new System.Drawing.Point(243, 214);
            this.bntMail.Name = "bntMail";
            this.bntMail.Size = new System.Drawing.Size(101, 23);
            this.bntMail.TabIndex = 17;
            this.bntMail.Text = "per Mail teilen";
            this.bntMail.UseVisualStyleBackColor = true;
            this.bntMail.Click += new System.EventHandler(this.sendMail);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(89, 143);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dtpDatum.MinDate = new System.DateTime(2016, 5, 25, 15, 53, 6, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(109, 22);
            this.dtpDatum.TabIndex = 18;
            this.dtpDatum.Value = new System.DateTime(2016, 5, 25, 15, 53, 6, 0);
            // 
            // dtpZeit
            // 
            this.dtpZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZeit.Location = new System.Drawing.Point(89, 173);
            this.dtpZeit.MinDate = new System.DateTime(2016, 5, 25, 15, 53, 6, 0);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.ShowUpDown = true;
            this.dtpZeit.Size = new System.Drawing.Size(87, 22);
            this.dtpZeit.TabIndex = 19;
            this.dtpZeit.Value = new System.DateTime(2016, 5, 30, 14, 14, 38, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Zeit";
            // 
            // btnMapsFrom
            // 
            this.btnMapsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapsFrom.Location = new System.Drawing.Point(322, 82);
            this.btnMapsFrom.Name = "btnMapsFrom";
            this.btnMapsFrom.Size = new System.Drawing.Size(69, 23);
            this.btnMapsFrom.TabIndex = 22;
            this.btnMapsFrom.Text = "Maps";
            this.btnMapsFrom.UseVisualStyleBackColor = true;
            this.btnMapsFrom.Click += new System.EventHandler(this.showOnMaps);
            // 
            // btnMapsTo
            // 
            this.btnMapsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapsTo.Location = new System.Drawing.Point(322, 112);
            this.btnMapsTo.Name = "btnMapsTo";
            this.btnMapsTo.Size = new System.Drawing.Size(69, 23);
            this.btnMapsTo.TabIndex = 23;
            this.btnMapsTo.Text = "Maps";
            this.btnMapsTo.UseVisualStyleBackColor = true;
            this.btnMapsTo.Click += new System.EventHandler(this.showOnMaps);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 505);
            this.Controls.Add(this.btnMapsTo);
            this.Controls.Add(this.btnMapsFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpZeit);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.bntMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbDepartueTable);
            this.Controls.Add(this.rbTimeTable);
            this.Controls.Add(this.btnDepartures);
            this.Controls.Add(this.dgvConnections);
            this.Controls.Add(this.txttoStation);
            this.Controls.Add(this.txtfromStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimeTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfromStation;
        private System.Windows.Forms.TextBox txttoStation;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.Button btnDepartures;
        private System.Windows.Forms.RadioButton rbTimeTable;
        private System.Windows.Forms.RadioButton rbDepartueTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntMail;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMapsFrom;
        private System.Windows.Forms.Button btnMapsTo;
    }
}

