using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;

namespace MSTSC_Manager
{
    public partial class Menu : Form
    {
        private Configuration configuration;
        private string configurationFile;
        private Serveur selectedServer;
        private int lastIndex = -1;


        public Menu()
        {
            InitializeComponent();
        }

        
        private void Menu_Load(object sender, EventArgs e)
        {
            this.loadConfiguration();
        }

        
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.saveConfiguration();
        }
        
        
        private void listBoxServeurs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxServeurs.IndexFromPoint(e.Location);
            if (index == 0)
            {
                this.tabControlMenu.SelectedTab = this.tabControlMenu.TabPages[1];
            }
            else if (index > 0 && this.buttonConnexion.Enabled)
            {
                this.buttonConnexion_Click(null, new EventArgs());
            }
        }


        private void listBoxServeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBoxServeurs.SelectedIndex;
            if (index > 0)
            {
                if (index != this.lastIndex)
                {
                    this.selectedServer = this.configuration.serveurs.Find(x =>
                        x.nom.Equals(this.listBoxServeurs.SelectedItem.ToString()));

                    this.buttonAjouter.Enabled = false;
                    this.buttonModifier.Enabled = true;
                    this.buttonSupprimer.Enabled = true;
                    this.buttonConnexion.Enabled = true;

                    Serveur serveur = this.selectedServer;
                    this.textBoxNom.Text = serveur.nom;
                    this.textBoxAdresse.Text = serveur.adresse;
                    this.textBoxDescription.Text = serveur.description;
                    this.checkBoxGlobale.Checked = serveur.utiliserAuthentificationGlobale;

                    Authentification authentification = serveur.authentification;
                    this.textBoxIdentifiant.Text = authentification.identifiant;
                    this.textBoxMotDePasse.Text = authentification.motDePasse;

                    this.lastIndex = index;
                }
            }
            else
            {
                this.selectedServer = null;
                
                this.buttonAjouter.Enabled = true;
                this.buttonModifier.Enabled = false;
                this.buttonSupprimer.Enabled = false;
                this.buttonConnexion.Enabled = false;

                this.textBoxNom.Text = "";
                this.textBoxAdresse.Text = "";
                this.textBoxDescription.Text = "";
                this.checkBoxGlobale.Checked = true;

                this.textBoxIdentifiant.Text = "";
                this.textBoxMotDePasse.Text = "";

                this.lastIndex = index;
            }
        }


        private void checkBoxGlobale_CheckedChanged(object sender, EventArgs e)
        {
            bool check = !this.checkBoxGlobale.Checked;
            this.textBoxIdentifiant.Enabled = check;
            this.textBoxMotDePasse.Enabled = check;
        }


        private void trackBarSeconde_Scroll(object sender, EventArgs e)
        {
            int second = this.trackBarSeconde.Value;
            this.labelSeconde.Text = second.ToString() + " seconde" + (second > 1 ? "s" : "");
            this.configuration.parametres.delaiSaisie = second;
        }
        

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (this.checkEmptyConfiguration() &&
                this.checkServerExist() &&
                (this.checkBoxGlobale.Checked || this.checkEmptyAuthentification()))
            {
                Serveur serveur = new Serveur();
                serveur.nom = this.textBoxNom.Text.Trim();
                serveur.adresse = this.textBoxAdresse.Text.Trim();
                serveur.description = this.textBoxDescription.Text.Trim();
                serveur.utiliserAuthentificationGlobale = this.checkBoxGlobale.Checked;

                Authentification authentification = new Authentification();
                authentification.identifiant = this.textBoxIdentifiant.Text.Trim();
                authentification.motDePasse = this.textBoxMotDePasse.Text.Trim();

                serveur.authentification = authentification;

                this.configuration.serveurs.Add(serveur);
                this.listBoxServeurs.Items.Add(serveur.nom);
                this.listBoxServeurs.SelectedItem = serveur.nom;
            }
        }
        

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = this.textBoxNom.Text.Trim();
            string previous = this.selectedServer.nom;
            if (previous.Equals(nom) || this.checkServerExist())
            {
                Serveur server = this.selectedServer;
                server.nom = nom;
                server.adresse = this.textBoxAdresse.Text.Trim();
                server.description = this.textBoxDescription.Text.Trim();
                server.utiliserAuthentificationGlobale = this.checkBoxGlobale.Checked;

                Authentification authentification = server.authentification;
                authentification.identifiant = this.textBoxIdentifiant.Text.Trim();
                authentification.motDePasse = this.textBoxMotDePasse.Text.Trim();

                if (!previous.Equals(nom))
                {
                    int index = this.listBoxServeurs.SelectedIndex;
                    this.listBoxServeurs.Items[index] = nom;
                }
            } 
        }

        
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Serveur serveur = this.selectedServer;
            if (MessageBox.Show(
                $"Êtes-vous sure de vouloir supprimer le serveur \"{serveur.nom}\" ?",
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.configuration.serveurs.Remove(serveur);
                this.listBoxServeurs.Items.Remove(this.listBoxServeurs.SelectedItem);
            }
        }

        
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (!this.checkBoxGlobale.Checked || 
                this.checkEmptyAuthentificationGlobale())
            {
                this.Hide();

                Configuration configuration = this.configuration;
                Serveur serveur = this.selectedServer;
                Parametres parametres = configuration.parametres;
                Authentification authentification = serveur.utiliserAuthentificationGlobale ?
                    configuration.authentificationGlobale : serveur.authentification;
                
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "mstsc";
                startInfo.Arguments = (parametres.forcerPleinEcran ? "/f" : "") + 
                                      " " + (parametres.modeAdministrateur ? "/admin" : "") + 
                                      " /v:\"" + serveur.adresse.Replace("\"", "\\\"") + "\"";
                
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                
                Thread.Sleep(parametres.delaiSaisie * 1000);
                
                if (!parametres.uniquementMotDePasse)
                {
                    SendKeys.SendWait(authentification.identifiant);
                    SendKeys.SendWait("{TAB}");
                }
                SendKeys.SendWait(authentification.motDePasse);
                SendKeys.SendWait("{ENTER}");

                this.Show();
            }
        }

        
        private void textBoxIdentifiantGlobale_TextChanged(object sender, EventArgs e)
        {
            this.configuration.authentificationGlobale.identifiant = this.textBoxIdentifiantGlobale.Text;
        }


        private void textBoxMotDePasseGlobale_TextChanged(object sender, EventArgs e)
        {
            this.configuration.authentificationGlobale.motDePasse = this.textBoxMotDePasseGlobale.Text;
        }


        private void checkBoxFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            this.configuration.parametres.forcerPleinEcran = this.checkBoxFullscreen.Checked;
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            this.configuration.parametres.modeAdministrateur = this.checkBoxAdmin.Checked;
        }

        
        private void checkBoxUniquement_CheckedChanged(object sender, EventArgs e)
        {
            this.configuration.parametres.uniquementMotDePasse = this.checkBoxUniquement.Checked;
        }

        
        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/TheRake66/Gestionnaire-de-connexion-bureau-distance") { UseShellExecute = true });
            }
            catch
            {

            }
        }


        private void loadConfiguration()
        {
            this.configurationFile =
                Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData), "mstsc_manager.json");

            if (File.Exists(this.configurationFile))
            {
                try
                {
                    this.configuration = JsonConvert.DeserializeObject<Configuration>(
                        File.ReadAllText(this.configurationFile));
                }
                catch (Exception error)
                {
                    if (MessageBox.Show(
                        "Impossible de charger la configuration. Si vous continuez, une nouvelle sera créée et vous perdrez l'ancienne. Êtes-vous sure de vouloir continuer ?" + Environment.NewLine + Environment.NewLine + "Message : " + error.Message,
                        this.Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }

            if (this.configuration == null)
            {
                this.configuration = new Configuration();
            }

            this.applyConfiguration();
        }

        
        private void saveConfiguration()
        {
            try
            {
                File.WriteAllText(this.configurationFile,
                    JsonConvert.SerializeObject(this.configuration, Formatting.Indented));
            }
            catch (Exception error)
            {
                do
                {

                }
                while (MessageBox.Show(
                    "Impossible de sauvegarder la configuration. Si vous continuez de fermer l'application, elle sera perdue. Êtes-vous sure de vouloir continuer ?" + Environment.NewLine + Environment.NewLine + "Message : " + error.Message,
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes);
            }
        }


        private void applyConfiguration()
        {
            foreach (Serveur serveur in this.configuration.serveurs)
            {
                this.listBoxServeurs.Items.Add(serveur.nom);
            }

            Authentification globale = this.configuration.authentificationGlobale;
            this.textBoxIdentifiantGlobale.Text = globale.identifiant;
            this.textBoxMotDePasseGlobale.Text = globale.motDePasse;

            Parametres parametres = this.configuration.parametres;
            this.checkBoxAdmin.Checked = parametres.modeAdministrateur;
            this.checkBoxFullscreen.Checked = parametres.forcerPleinEcran;
            this.checkBoxUniquement.Checked = parametres.uniquementMotDePasse;

            this.trackBarSeconde.Value = parametres.delaiSaisie;
            this.trackBarSeconde_Scroll(null, new EventArgs());
        }
        
        
        private bool checkEmptyConfiguration()
        {
            if (this.textBoxNom.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un nom !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.textBoxAdresse.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer une adresse distante !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        

        private bool checkEmptyAuthentification()
        {
            if (this.textBoxIdentifiant.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un identifiant !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.textBoxMotDePasse.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un mot de passe !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        
        private bool checkEmptyAuthentificationGlobale()
        {
            if (this.textBoxIdentifiantGlobale.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un identifiant globale !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.textBoxMotDePasseGlobale.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un mot de passe globale !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        

        private bool checkServerExist()
        {
            string name = this.textBoxNom.Text.Trim();
            foreach (Serveur serveur in this.configuration.serveurs)
            {
                if (serveur.nom.Equals(name))
                {
                    MessageBox.Show("Ce serveur existe déjà !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}