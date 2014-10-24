namespace Login_Manager
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Mergner", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Partheymüller", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Brüssow", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Hiller", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Höppel", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Knippert", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Schubert", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Kuhlmann", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Eber", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Wenck", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Springer", System.Windows.Forms.HorizontalAlignment.Left);
            this.buttonNeuerLogin = new System.Windows.Forms.Button();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.txtSinoxPfad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coBoSchicht = new System.Windows.Forms.ComboBox();
            this.coBoPlatz = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Logins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNeuerLogin
            // 
            this.buttonNeuerLogin.Location = new System.Drawing.Point(73, 187);
            this.buttonNeuerLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNeuerLogin.Name = "buttonNeuerLogin";
            this.buttonNeuerLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonNeuerLogin.TabIndex = 2;
            this.buttonNeuerLogin.Text = "Erstellen";
            this.buttonNeuerLogin.UseVisualStyleBackColor = true;
            this.buttonNeuerLogin.Click += new System.EventHandler(this.buttonNeuerLogin_Click);
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(73, 25);
            this.lblBenutzername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(75, 13);
            this.lblBenutzername.TabIndex = 4;
            this.lblBenutzername.Text = "Benutzername";
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Location = new System.Drawing.Point(60, 41);
            this.txtBenutzername.Margin = new System.Windows.Forms.Padding(2);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(100, 20);
            this.txtBenutzername.TabIndex = 5;
            this.txtBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBenutzername.TextChanged += new System.EventHandler(this.txtBenutzername_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(60, 80);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(100, 20);
            this.txtPasswort.TabIndex = 6;
            this.txtPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(85, 65);
            this.lblPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(50, 13);
            this.lblPasswort.TabIndex = 7;
            this.lblPasswort.Text = "Passwort";
            // 
            // txtSinoxPfad
            // 
            this.txtSinoxPfad.Location = new System.Drawing.Point(187, 262);
            this.txtSinoxPfad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSinoxPfad.Name = "txtSinoxPfad";
            this.txtSinoxPfad.Size = new System.Drawing.Size(218, 20);
            this.txtSinoxPfad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SINOx Pfad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coBoSchicht);
            this.groupBox1.Controls.Add(this.coBoPlatz);
            this.groupBox1.Controls.Add(this.lblPasswort);
            this.groupBox1.Controls.Add(this.txtPasswort);
            this.groupBox1.Controls.Add(this.txtBenutzername);
            this.groupBox1.Controls.Add(this.lblBenutzername);
            this.groupBox1.Controls.Add(this.buttonNeuerLogin);
            this.groupBox1.Location = new System.Drawing.Point(187, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuen Login erstellen";
            // 
            // coBoSchicht
            // 
            this.coBoSchicht.FormattingEnabled = true;
            this.coBoSchicht.Location = new System.Drawing.Point(60, 148);
            this.coBoSchicht.Name = "coBoSchicht";
            this.coBoSchicht.Size = new System.Drawing.Size(100, 21);
            this.coBoSchicht.TabIndex = 9;
            // 
            // coBoPlatz
            // 
            this.coBoPlatz.FormattingEnabled = true;
            this.coBoPlatz.Location = new System.Drawing.Point(60, 121);
            this.coBoPlatz.Name = "coBoPlatz";
            this.coBoPlatz.Size = new System.Drawing.Size(100, 21);
            this.coBoPlatz.TabIndex = 8;
            this.coBoPlatz.SelectedIndexChanged += new System.EventHandler(this.coBoPlatz_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Logins});
            listViewGroup1.Header = "Mergner";
            listViewGroup1.Name = "Mergner";
            listViewGroup2.Header = "Partheymüller";
            listViewGroup2.Name = "Partheymüller";
            listViewGroup3.Header = "Brüssow";
            listViewGroup3.Name = "Brüssow";
            listViewGroup4.Header = "Hiller";
            listViewGroup4.Name = "Hiller";
            listViewGroup5.Header = "Höppel";
            listViewGroup5.Name = "Höppel";
            listViewGroup6.Header = "Knippert";
            listViewGroup6.Name = "Knippert";
            listViewGroup7.Header = "Schubert";
            listViewGroup7.Name = "Schubert";
            listViewGroup8.Header = "Kuhlmann";
            listViewGroup8.Name = "Kuhlmann";
            listViewGroup9.Header = "Eber";
            listViewGroup9.Name = "Eber";
            listViewGroup10.Header = "Wenck";
            listViewGroup10.Name = "Wenck";
            listViewGroup11.Header = "Springer";
            listViewGroup11.Name = "Springer";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11});
            this.listView1.Location = new System.Drawing.Point(9, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(165, 268);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Logins
            // 
            this.Logins.Text = "Logins";
            this.Logins.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSinoxPfad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 333);
            this.MinimumSize = new System.Drawing.Size(432, 333);
            this.Name = "Form1";
            this.Text = "SINOx Login Manager - BETA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNeuerLogin;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.TextBox txtBenutzername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox txtSinoxPfad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox coBoSchicht;
        private System.Windows.Forms.ComboBox coBoPlatz;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Logins;
    }
}

