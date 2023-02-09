namespace MSTSC_Manager
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxServeurs = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMotDePasseGlobale = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiantGlobale = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxGlobale = new System.Windows.Forms.CheckBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSeconde = new System.Windows.Forms.Label();
            this.trackBarSeconde = new System.Windows.Forms.TrackBar();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.checkBoxUniquement = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeconde)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Red;
            this.buttonSupprimer.Location = new System.Drawing.Point(213, 221);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 30);
            this.buttonSupprimer.TabIndex = 8;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxServeurs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox1.Size = new System.Drawing.Size(300, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des serveurs distants";
            // 
            // listBoxServeurs
            // 
            this.listBoxServeurs.FormattingEnabled = true;
            this.listBoxServeurs.ItemHeight = 15;
            this.listBoxServeurs.Items.AddRange(new object[] {
            "+ Nouveau serveur"});
            this.listBoxServeurs.Location = new System.Drawing.Point(12, 28);
            this.listBoxServeurs.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.listBoxServeurs.Name = "listBoxServeurs";
            this.listBoxServeurs.Size = new System.Drawing.Size(275, 229);
            this.listBoxServeurs.TabIndex = 0;
            this.listBoxServeurs.SelectedIndexChanged += new System.EventHandler(this.listBoxServeurs_SelectedIndexChanged);
            this.listBoxServeurs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxServeurs_MouseDoubleClick);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 63);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PlaceholderText = "Description (optionnel)";
            this.textBoxDescription.Size = new System.Drawing.Size(276, 80);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(156, 28);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.PlaceholderText = "Adresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(132, 23);
            this.textBoxAdresse.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(12, 28);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PlaceholderText = "Nom";
            this.textBoxNom.Size = new System.Drawing.Size(132, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(99, 221);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 30);
            this.buttonModifier.TabIndex = 7;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(12, 221);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 30);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMotDePasseGlobale);
            this.groupBox2.Controls.Add(this.textBoxIdentifiantGlobale);
            this.groupBox2.Location = new System.Drawing.Point(324, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox2.Size = new System.Drawing.Size(300, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentification globale";
            // 
            // textBoxMotDePasseGlobale
            // 
            this.textBoxMotDePasseGlobale.Location = new System.Drawing.Point(156, 28);
            this.textBoxMotDePasseGlobale.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMotDePasseGlobale.Name = "textBoxMotDePasseGlobale";
            this.textBoxMotDePasseGlobale.PlaceholderText = "Mot de passe";
            this.textBoxMotDePasseGlobale.Size = new System.Drawing.Size(132, 23);
            this.textBoxMotDePasseGlobale.TabIndex = 1;
            this.textBoxMotDePasseGlobale.UseSystemPasswordChar = true;
            this.textBoxMotDePasseGlobale.TextChanged += new System.EventHandler(this.textBoxMotDePasseGlobale_TextChanged);
            // 
            // textBoxIdentifiantGlobale
            // 
            this.textBoxIdentifiantGlobale.Location = new System.Drawing.Point(12, 28);
            this.textBoxIdentifiantGlobale.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxIdentifiantGlobale.Name = "textBoxIdentifiantGlobale";
            this.textBoxIdentifiantGlobale.PlaceholderText = "Identifiant";
            this.textBoxIdentifiantGlobale.Size = new System.Drawing.Size(132, 23);
            this.textBoxIdentifiantGlobale.TabIndex = 0;
            this.textBoxIdentifiantGlobale.TextChanged += new System.EventHandler(this.textBoxIdentifiantGlobale_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxGlobale);
            this.groupBox3.Controls.Add(this.textBoxMotDePasse);
            this.groupBox3.Controls.Add(this.textBoxIdentifiant);
            this.groupBox3.Controls.Add(this.buttonModifier);
            this.groupBox3.Controls.Add(this.textBoxDescription);
            this.groupBox3.Controls.Add(this.buttonAjouter);
            this.groupBox3.Controls.Add(this.textBoxAdresse);
            this.groupBox3.Controls.Add(this.buttonSupprimer);
            this.groupBox3.Controls.Add(this.textBoxNom);
            this.groupBox3.Location = new System.Drawing.Point(324, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox3.Size = new System.Drawing.Size(300, 264);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration du serveur distant";
            // 
            // checkBoxGlobale
            // 
            this.checkBoxGlobale.AutoSize = true;
            this.checkBoxGlobale.Checked = true;
            this.checkBoxGlobale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlobale.Location = new System.Drawing.Point(12, 155);
            this.checkBoxGlobale.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.checkBoxGlobale.Name = "checkBoxGlobale";
            this.checkBoxGlobale.Size = new System.Drawing.Size(197, 19);
            this.checkBoxGlobale.TabIndex = 3;
            this.checkBoxGlobale.Text = "Utiliser l\'authentification globale";
            this.checkBoxGlobale.UseVisualStyleBackColor = true;
            this.checkBoxGlobale.CheckedChanged += new System.EventHandler(this.checkBoxGlobale_CheckedChanged);
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Enabled = false;
            this.textBoxMotDePasse.Location = new System.Drawing.Point(156, 186);
            this.textBoxMotDePasse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PlaceholderText = "Mot de passe";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(132, 23);
            this.textBoxMotDePasse.TabIndex = 5;
            this.textBoxMotDePasse.UseSystemPasswordChar = true;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Enabled = false;
            this.textBoxIdentifiant.Location = new System.Drawing.Point(12, 186);
            this.textBoxIdentifiant.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.PlaceholderText = "Identifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(132, 23);
            this.textBoxIdentifiant.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSeconde);
            this.groupBox4.Controls.Add(this.trackBarSeconde);
            this.groupBox4.Location = new System.Drawing.Point(324, 369);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox4.Size = new System.Drawing.Size(300, 103);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Délai de saisie du mot de passe";
            // 
            // labelSeconde
            // 
            this.labelSeconde.AutoSize = true;
            this.labelSeconde.Location = new System.Drawing.Point(120, 73);
            this.labelSeconde.Margin = new System.Windows.Forms.Padding(0);
            this.labelSeconde.Name = "labelSeconde";
            this.labelSeconde.Size = new System.Drawing.Size(60, 15);
            this.labelSeconde.TabIndex = 6;
            this.labelSeconde.Text = "1 seconde";
            this.labelSeconde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSeconde
            // 
            this.trackBarSeconde.Location = new System.Drawing.Point(12, 28);
            this.trackBarSeconde.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarSeconde.Minimum = 1;
            this.trackBarSeconde.Name = "trackBarSeconde";
            this.trackBarSeconde.Size = new System.Drawing.Size(276, 45);
            this.trackBarSeconde.TabIndex = 0;
            this.trackBarSeconde.Value = 1;
            this.trackBarSeconde.Scroll += new System.EventHandler(this.trackBarSeconde_Scroll);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Enabled = false;
            this.buttonConnexion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnexion.Location = new System.Drawing.Point(12, 425);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(300, 47);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "~ Connexion ~";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // checkBoxUniquement
            // 
            this.checkBoxUniquement.AutoSize = true;
            this.checkBoxUniquement.Checked = true;
            this.checkBoxUniquement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUniquement.Location = new System.Drawing.Point(12, 28);
            this.checkBoxUniquement.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxUniquement.Name = "checkBoxUniquement";
            this.checkBoxUniquement.Size = new System.Drawing.Size(206, 19);
            this.checkBoxUniquement.TabIndex = 0;
            this.checkBoxUniquement.Text = "Saisir uniquement le mot de passe";
            this.checkBoxUniquement.UseVisualStyleBackColor = true;
            this.checkBoxUniquement.CheckedChanged += new System.EventHandler(this.checkBoxUniquement_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxAdmin);
            this.groupBox5.Controls.Add(this.checkBoxFullscreen);
            this.groupBox5.Controls.Add(this.checkBoxUniquement);
            this.groupBox5.Location = new System.Drawing.Point(12, 295);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox5.Size = new System.Drawing.Size(300, 118);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Paramètres";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Checked = true;
            this.checkBoxAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdmin.Location = new System.Drawing.Point(12, 89);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(198, 19);
            this.checkBoxAdmin.TabIndex = 2;
            this.checkBoxAdmin.Text = "Lancer en tant qu\'administrateur";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Checked = true;
            this.checkBoxFullscreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullscreen.Location = new System.Drawing.Point(12, 59);
            this.checkBoxFullscreen.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(132, 19);
            this.checkBoxFullscreen.TabIndex = 1;
            this.checkBoxFullscreen.Text = "Forcer le plein écran";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            this.checkBoxFullscreen.CheckedChanged += new System.EventHandler(this.checkBoxFullscreen_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 484);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 523);
            this.MinimumSize = new System.Drawing.Size(652, 523);
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSTSC Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeconde)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSupprimer;
        private GroupBox groupBox1;
        private ListBox listBoxServeurs;
        private Button buttonModifier;
        private Button buttonAjouter;
        private GroupBox groupBox2;
        private TextBox textBoxAdresse;
        private TextBox textBoxNom;
        private TextBox textBoxDescription;
        private GroupBox groupBox3;
        private CheckBox checkBoxGlobale;
        private TextBox textBoxMotDePasse;
        private TextBox textBoxIdentifiant;
        private TextBox textBoxMotDePasseGlobale;
        private TextBox textBoxIdentifiantGlobale;
        private GroupBox groupBox4;
        private Label labelSeconde;
        private TrackBar trackBarSeconde;
        private Button buttonConnexion;
        private CheckBox checkBoxUniquement;
        private GroupBox groupBox5;
        private CheckBox checkBoxAdmin;
        private CheckBox checkBoxFullscreen;
    }
}