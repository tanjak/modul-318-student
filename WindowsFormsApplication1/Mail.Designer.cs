namespace WindowsFormsApplication1
{
    partial class Mail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBetreff = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Von";
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(141, 36);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(167, 20);
            this.txtVon.TabIndex = 1;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(141, 62);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(167, 20);
            this.txtPasswort.TabIndex = 2;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(141, 88);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(167, 20);
            this.txtAn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "An";
            // 
            // txtNachricht
            // 
            this.txtNachricht.Location = new System.Drawing.Point(79, 156);
            this.txtNachricht.Multiline = true;
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(229, 113);
            this.txtNachricht.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nachricht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Betreff";
            // 
            // txtBetreff
            // 
            this.txtBetreff.Location = new System.Drawing.Point(141, 114);
            this.txtBetreff.Name = "txtBetreff";
            this.txtBetreff.Size = new System.Drawing.Size(167, 20);
            this.txtBetreff.TabIndex = 4;
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(130, 295);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 6;
            this.btnSenden.Text = "senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 349);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.txtBetreff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNachricht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtVon);
            this.Controls.Add(this.label1);
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBetreff;
        private System.Windows.Forms.Button btnSenden;
    }
}