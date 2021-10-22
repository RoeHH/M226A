namespace PersonenverwaltungV3
{
    partial class Form1
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.s = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pNr = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.vorname = new System.Windows.Forms.TextBox();
            this.jahrgang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(124, 199);
            this.ListBox.TabIndex = 0;
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(154, 12);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 1;
            this.s.Text = "S";
            this.s.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(235, 12);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(75, 23);
            this.d.TabIndex = 2;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = true;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(316, 12);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(75, 23);
            this.n.TabIndex = 3;
            this.n.Text = "N";
            this.n.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // pNr
            // 
            this.pNr.Location = new System.Drawing.Point(224, 58);
            this.pNr.Name = "pNr";
            this.pNr.ReadOnly = true;
            this.pNr.Size = new System.Drawing.Size(100, 20);
            this.pNr.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(224, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 6;
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(224, 110);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(100, 20);
            this.vorname.TabIndex = 7;
            // 
            // jahrgang
            // 
            this.jahrgang.Location = new System.Drawing.Point(224, 137);
            this.jahrgang.Name = "jahrgang";
            this.jahrgang.Size = new System.Drawing.Size(100, 20);
            this.jahrgang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jahrgang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alter";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(224, 163);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 193);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jahrgang);
            this.Controls.Add(this.vorname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.ListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pNr;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox vorname;
        private System.Windows.Forms.TextBox jahrgang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

