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
            this.listBoxServeurs = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxMotDePasseGlobale = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiantGlobale = new System.Windows.Forms.TextBox();
            this.checkBoxGlobale = new System.Windows.Forms.CheckBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.labelSeconde = new System.Windows.Forms.Label();
            this.trackBarSeconde = new System.Windows.Forms.TrackBar();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.checkBoxUniquement = new System.Windows.Forms.CheckBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeconde)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Red;
            this.buttonSupprimer.Location = new System.Drawing.Point(340, 308);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 30);
            this.buttonSupprimer.TabIndex = 8;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // listBoxServeurs
            // 
            this.listBoxServeurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxServeurs.FormattingEnabled = true;
            this.listBoxServeurs.ItemHeight = 15;
            this.listBoxServeurs.Items.AddRange(new object[] {
            "+ Nouveau serveur"});
            this.listBoxServeurs.Location = new System.Drawing.Point(12, 12);
            this.listBoxServeurs.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.listBoxServeurs.Name = "listBoxServeurs";
            this.listBoxServeurs.Size = new System.Drawing.Size(403, 326);
            this.listBoxServeurs.TabIndex = 0;
            this.listBoxServeurs.SelectedIndexChanged += new System.EventHandler(this.listBoxServeurs_SelectedIndexChanged);
            this.listBoxServeurs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxServeurs_MouseDoubleClick);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(12, 82);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PlaceholderText = "Description (optionnel)";
            this.textBoxDescription.Size = new System.Drawing.Size(403, 113);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresse.Location = new System.Drawing.Point(12, 47);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.PlaceholderText = "Adresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(403, 23);
            this.textBoxAdresse.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNom.Location = new System.Drawing.Point(12, 12);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PlaceholderText = "Nom";
            this.textBoxNom.Size = new System.Drawing.Size(403, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(99, 308);
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
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAjouter.Location = new System.Drawing.Point(12, 308);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 30);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxMotDePasseGlobale
            // 
            this.textBoxMotDePasseGlobale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMotDePasseGlobale.Location = new System.Drawing.Point(12, 47);
            this.textBoxMotDePasseGlobale.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMotDePasseGlobale.Name = "textBoxMotDePasseGlobale";
            this.textBoxMotDePasseGlobale.PlaceholderText = "Mot de passe";
            this.textBoxMotDePasseGlobale.Size = new System.Drawing.Size(403, 23);
            this.textBoxMotDePasseGlobale.TabIndex = 1;
            this.textBoxMotDePasseGlobale.UseSystemPasswordChar = true;
            this.textBoxMotDePasseGlobale.TextChanged += new System.EventHandler(this.textBoxMotDePasseGlobale_TextChanged);
            // 
            // textBoxIdentifiantGlobale
            // 
            this.textBoxIdentifiantGlobale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdentifiantGlobale.Location = new System.Drawing.Point(12, 12);
            this.textBoxIdentifiantGlobale.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxIdentifiantGlobale.Name = "textBoxIdentifiantGlobale";
            this.textBoxIdentifiantGlobale.PlaceholderText = "Identifiant";
            this.textBoxIdentifiantGlobale.Size = new System.Drawing.Size(403, 23);
            this.textBoxIdentifiantGlobale.TabIndex = 0;
            this.textBoxIdentifiantGlobale.TextChanged += new System.EventHandler(this.textBoxIdentifiantGlobale_TextChanged);
            // 
            // checkBoxGlobale
            // 
            this.checkBoxGlobale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxGlobale.AutoSize = true;
            this.checkBoxGlobale.Checked = true;
            this.checkBoxGlobale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlobale.Location = new System.Drawing.Point(12, 207);
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
            this.textBoxMotDePasse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMotDePasse.Enabled = false;
            this.textBoxMotDePasse.Location = new System.Drawing.Point(12, 273);
            this.textBoxMotDePasse.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PlaceholderText = "Mot de passe";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(403, 23);
            this.textBoxMotDePasse.TabIndex = 5;
            this.textBoxMotDePasse.UseSystemPasswordChar = true;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdentifiant.Enabled = false;
            this.textBoxIdentifiant.Location = new System.Drawing.Point(12, 238);
            this.textBoxIdentifiant.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.PlaceholderText = "Identifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(403, 23);
            this.textBoxIdentifiant.TabIndex = 4;
            // 
            // labelSeconde
            // 
            this.labelSeconde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSeconde.AutoSize = true;
            this.labelSeconde.Location = new System.Drawing.Point(183, 57);
            this.labelSeconde.Margin = new System.Windows.Forms.Padding(0);
            this.labelSeconde.Name = "labelSeconde";
            this.labelSeconde.Size = new System.Drawing.Size(60, 15);
            this.labelSeconde.TabIndex = 6;
            this.labelSeconde.Text = "1 seconde";
            this.labelSeconde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSeconde
            // 
            this.trackBarSeconde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSeconde.BackColor = System.Drawing.Color.White;
            this.trackBarSeconde.Location = new System.Drawing.Point(12, 12);
            this.trackBarSeconde.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarSeconde.Minimum = 1;
            this.trackBarSeconde.Name = "trackBarSeconde";
            this.trackBarSeconde.Size = new System.Drawing.Size(403, 45);
            this.trackBarSeconde.TabIndex = 0;
            this.trackBarSeconde.Value = 1;
            this.trackBarSeconde.Scroll += new System.EventHandler(this.trackBarSeconde_Scroll);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnexion.Enabled = false;
            this.buttonConnexion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnexion.Location = new System.Drawing.Point(362, 422);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(85, 30);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // checkBoxUniquement
            // 
            this.checkBoxUniquement.AutoSize = true;
            this.checkBoxUniquement.Checked = true;
            this.checkBoxUniquement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUniquement.Location = new System.Drawing.Point(12, 12);
            this.checkBoxUniquement.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxUniquement.Name = "checkBoxUniquement";
            this.checkBoxUniquement.Size = new System.Drawing.Size(206, 19);
            this.checkBoxUniquement.TabIndex = 0;
            this.checkBoxUniquement.Text = "Saisir uniquement le mot de passe";
            this.checkBoxUniquement.UseVisualStyleBackColor = true;
            this.checkBoxUniquement.CheckedChanged += new System.EventHandler(this.checkBoxUniquement_CheckedChanged);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Checked = true;
            this.checkBoxAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdmin.Location = new System.Drawing.Point(12, 73);
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
            this.checkBoxFullscreen.Location = new System.Drawing.Point(12, 43);
            this.checkBoxFullscreen.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(132, 19);
            this.checkBoxFullscreen.TabIndex = 1;
            this.checkBoxFullscreen.Text = "Forcer le plein écran";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            this.checkBoxFullscreen.CheckedChanged += new System.EventHandler(this.checkBoxFullscreen_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 72);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(70, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connexion bureau à distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestionnaire de";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 398);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxServeurs);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage1.Size = new System.Drawing.Size(427, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des serveurs distants";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxGlobale);
            this.tabPage2.Controls.Add(this.textBoxMotDePasse);
            this.tabPage2.Controls.Add(this.textBoxNom);
            this.tabPage2.Controls.Add(this.buttonModifier);
            this.tabPage2.Controls.Add(this.textBoxAdresse);
            this.tabPage2.Controls.Add(this.buttonSupprimer);
            this.tabPage2.Controls.Add(this.textBoxDescription);
            this.tabPage2.Controls.Add(this.buttonAjouter);
            this.tabPage2.Controls.Add(this.textBoxIdentifiant);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage2.Size = new System.Drawing.Size(427, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration du serveur distant";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxMotDePasseGlobale);
            this.tabPage3.Controls.Add(this.textBoxIdentifiantGlobale);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage3.Size = new System.Drawing.Size(427, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authentification globale";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelSeconde);
            this.tabPage4.Controls.Add(this.trackBarSeconde);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage4.Size = new System.Drawing.Size(427, 350);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Délai de saisie du mot de passe";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkBoxAdmin);
            this.tabPage5.Controls.Add(this.checkBoxUniquement);
            this.tabPage5.Controls.Add(this.checkBoxFullscreen);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage5.Size = new System.Drawing.Size(427, 350);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Paramètres";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabelGithub);
            this.panel2.Controls.Add(this.buttonConnexion);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12);
            this.panel2.Size = new System.Drawing.Size(459, 464);
            this.panel2.TabIndex = 9;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(12, 430);
            this.linkLabelGithub.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(140, 15);
            this.linkLabelGithub.TabIndex = 9;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "⇱ Ouvrir le dépôt GitHub";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 575);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de connexion bureau à distance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeconde)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSupprimer;
        private ListBox listBoxServeurs;
        private Button buttonModifier;
        private Button buttonAjouter;
        private TextBox textBoxAdresse;
        private TextBox textBoxNom;
        private TextBox textBoxDescription;
        private CheckBox checkBoxGlobale;
        private TextBox textBoxMotDePasse;
        private TextBox textBoxIdentifiant;
        private TextBox textBoxMotDePasseGlobale;
        private TextBox textBoxIdentifiantGlobale;
        private Label labelSeconde;
        private TrackBar trackBarSeconde;
        private Button buttonConnexion;
        private CheckBox checkBoxUniquement;
        private CheckBox checkBoxAdmin;
        private CheckBox checkBoxFullscreen;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel2;
        private LinkLabel linkLabelGithub;
    }
}