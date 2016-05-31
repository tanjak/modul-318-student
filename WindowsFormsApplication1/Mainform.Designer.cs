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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMapsFrom = new System.Windows.Forms.Button();
            this.btnMapsTo = new System.Windows.Forms.Button();
            this.llblMail = new System.Windows.Forms.LinkLabel();
            this.rbSearchStation = new System.Windows.Forms.RadioButton();
            this.panelTimeTabel = new System.Windows.Forms.Panel();
            this.panelSearchStation = new System.Windows.Forms.Panel();
            this.txtPlz = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.panelTimeTabel.SuspendLayout();
            this.panelSearchStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeTable.Location = new System.Drawing.Point(9, 138);
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
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nach";
            // 
            // txtfromStation
            // 
            this.txtfromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromStation.Location = new System.Drawing.Point(57, 7);
            this.txtfromStation.Name = "txtfromStation";
            this.txtfromStation.Size = new System.Drawing.Size(213, 22);
            this.txtfromStation.TabIndex = 8;
            this.txtfromStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.showAutoCompletion);
            // 
            // txttoStation
            // 
            this.txttoStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoStation.Location = new System.Drawing.Point(57, 37);
            this.txttoStation.Name = "txttoStation";
            this.txttoStation.Size = new System.Drawing.Size(213, 22);
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
            this.btnDepartures.Location = new System.Drawing.Point(9, 138);
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
            this.rbTimeTable.Location = new System.Drawing.Point(48, 22);
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
            this.rbDepartueTable.Location = new System.Drawing.Point(147, 24);
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
            this.label3.Size = new System.Drawing.Size(371, 2);
            this.label3.TabIndex = 15;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(57, 67);
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
            this.dtpZeit.Location = new System.Drawing.Point(57, 97);
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
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Zeit";
            // 
            // btnMapsFrom
            // 
            this.btnMapsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapsFrom.Location = new System.Drawing.Point(290, 6);
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
            this.btnMapsTo.Location = new System.Drawing.Point(290, 36);
            this.btnMapsTo.Name = "btnMapsTo";
            this.btnMapsTo.Size = new System.Drawing.Size(69, 23);
            this.btnMapsTo.TabIndex = 23;
            this.btnMapsTo.Text = "Maps";
            this.btnMapsTo.UseVisualStyleBackColor = true;
            this.btnMapsTo.Click += new System.EventHandler(this.showOnMaps);
            // 
            // llblMail
            // 
            this.llblMail.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llblMail.AutoSize = true;
            this.llblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMail.LinkColor = System.Drawing.Color.Black;
            this.llblMail.Location = new System.Drawing.Point(303, 238);
            this.llblMail.Name = "llblMail";
            this.llblMail.Size = new System.Drawing.Size(91, 16);
            this.llblMail.TabIndex = 25;
            this.llblMail.TabStop = true;
            this.llblMail.Text = "per Mail teilen";
            this.llblMail.Click += new System.EventHandler(this.sendMail);
            this.llblMail.MouseLeave += new System.EventHandler(this.llblMail_MouseLeave);
            this.llblMail.MouseHover += new System.EventHandler(this.llblMail_MouseHover);
            // 
            // rbSearchStation
            // 
            this.rbSearchStation.AutoSize = true;
            this.rbSearchStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchStation.Location = new System.Drawing.Point(277, 24);
            this.rbSearchStation.Name = "rbSearchStation";
            this.rbSearchStation.Size = new System.Drawing.Size(129, 24);
            this.rbSearchStation.TabIndex = 26;
            this.rbSearchStation.Text = "Stationssuche";
            this.rbSearchStation.UseVisualStyleBackColor = true;
            // 
            // panelTimeTabel
            // 
            this.panelTimeTabel.Controls.Add(this.panelSearchStation);
            this.panelTimeTabel.Controls.Add(this.label1);
            this.panelTimeTabel.Controls.Add(this.btnTimeTable);
            this.panelTimeTabel.Controls.Add(this.label2);
            this.panelTimeTabel.Controls.Add(this.txtfromStation);
            this.panelTimeTabel.Controls.Add(this.btnMapsTo);
            this.panelTimeTabel.Controls.Add(this.txttoStation);
            this.panelTimeTabel.Controls.Add(this.btnMapsFrom);
            this.panelTimeTabel.Controls.Add(this.btnDepartures);
            this.panelTimeTabel.Controls.Add(this.label5);
            this.panelTimeTabel.Controls.Add(this.dtpDatum);
            this.panelTimeTabel.Controls.Add(this.label4);
            this.panelTimeTabel.Controls.Add(this.dtpZeit);
            this.panelTimeTabel.Location = new System.Drawing.Point(29, 72);
            this.panelTimeTabel.Name = "panelTimeTabel";
            this.panelTimeTabel.Size = new System.Drawing.Size(362, 163);
            this.panelTimeTabel.TabIndex = 28;
            // 
            // panelSearchStation
            // 
            this.panelSearchStation.Controls.Add(this.label8);
            this.panelSearchStation.Controls.Add(this.label13);
            this.panelSearchStation.Controls.Add(this.btnSearchStation);
            this.panelSearchStation.Controls.Add(this.label14);
            this.panelSearchStation.Controls.Add(this.txtAdresse);
            this.panelSearchStation.Controls.Add(this.txtOrt);
            this.panelSearchStation.Controls.Add(this.txtPlz);
            this.panelSearchStation.Location = new System.Drawing.Point(0, 0);
            this.panelSearchStation.Name = "panelSearchStation";
            this.panelSearchStation.Size = new System.Drawing.Size(362, 163);
            this.panelSearchStation.TabIndex = 30;
            this.panelSearchStation.Visible = false;
            // 
            // txtPlz
            // 
            this.txtPlz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlz.Location = new System.Drawing.Point(57, 37);
            this.txtPlz.Name = "txtPlz";
            this.txtPlz.Size = new System.Drawing.Size(43, 22);
            this.txtPlz.TabIndex = 9;
            // 
            // txtOrt
            // 
            this.txtOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrt.Location = new System.Drawing.Point(57, 65);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(213, 22);
            this.txtOrt.TabIndex = 2;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(57, 7);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(213, 22);
            this.txtAdresse.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "PLZ";
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStation.Location = new System.Drawing.Point(9, 138);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(120, 23);
            this.btnSearchStation.TabIndex = 24;
            this.btnSearchStation.Text = "Station suchen";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.searchStation);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Str.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ort";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 505);
            this.Controls.Add(this.panelTimeTabel);
            this.Controls.Add(this.rbSearchStation);
            this.Controls.Add(this.llblMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbDepartueTable);
            this.Controls.Add(this.rbTimeTable);
            this.Controls.Add(this.dgvConnections);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.panelTimeTabel.ResumeLayout(false);
            this.panelTimeTabel.PerformLayout();
            this.panelSearchStation.ResumeLayout(false);
            this.panelSearchStation.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpZeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMapsFrom;
        private System.Windows.Forms.Button btnMapsTo;
        private System.Windows.Forms.LinkLabel llblMail;
        private System.Windows.Forms.RadioButton rbSearchStation;
        private System.Windows.Forms.Panel panelTimeTabel;
        private System.Windows.Forms.Panel panelSearchStation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtPlz;
    }
}

