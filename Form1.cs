using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Etudiants
{
    /// <summary>
    /// This class creates a form that allows the user 
    /// to save and display data on a person.
    /// </summary>
    public partial class frmEtudiants : Form
    {
        
        List<Personne> personnes = new List<Personne>();
        string fileName = @"personnes.txt";

        // The constructor (initialize all components)
        public frmEtudiants()
        {
            InitializeComponent();
        }

     
        /// <summary>
        /// This method allows the user to save the informations 
        /// collected in the TextBox and display them in the ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get data
            String nom = txtBoxNom.Text;
            String prenom1 = txtBoxPrenom1.Text;
            String prenom2 = txtBoxPrenom2.Text;
            int age = Convert.ToInt32(txtBoxAge.Text);
            String nationalite = txtBoxNationalite.Text;
            String adresse = txtBoxAdresse.Text;
            String ville = txtBoxVille.Text;
            String pays = txtBoxPays.Text;
            String telephone = txtBoxTelephone.Text;

            // Create an instance of the class Personne
            Personne personne = new Personne(nom, prenom1, prenom2, age, nationalite, adresse, ville, pays, telephone);
            personnes.Add(personne);

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(fileName))
            {
                // Format the character string
                string formatData = String.Format("{0}{1}{2}{3} {4} {5} {6} {7} {8}", personne.Nom, personne.Prenom1, personne.Prenom2,
                    personne.Age, personne.Telephone, personne.Nationalite, personne.AdresseRue, personne.Ville, personne.Pays);
                sw.WriteLine(formatData);
            }

            // Add data to the ListView
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = personne.Nom;
            listViewItem.SubItems.Add(personne.Prenom1 + " " + personne.Prenom2);
            listViewItem.SubItems.Add(Convert.ToString(personne.Age));
            listViewItem.SubItems.Add(personne.Telephone);
            lvEtudiants.Items.Add(listViewItem);
        }


        /// <summary>
        /// This method allows the user to clear the TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxNom.Text = "";
            txtBoxPrenom1.Text = "";
            txtBoxPrenom2.Text = "";
            txtBoxAge.Text = "";
            txtBoxNationalite.Text = "";
            txtBoxAdresse.Text = "";
            txtBoxVille.Text = "";
            txtBoxPays.Text = "";
            txtBoxTelephone.Text = "";
            btnSave.Enabled = false;
        }

        /// <summary>
        /// This method allows to readt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEtudiants_Load(object sender, EventArgs e)
        {
            // Add diefferent columns to the ListView
            int width = 160;
            lvEtudiants.View = View.Details;
            lvEtudiants.Columns.Add("Nom", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Prenom", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Age", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Telephone", width, HorizontalAlignment.Left);

            // Opening the file for reading
            FileInfo file = new FileInfo(fileName);

            // Check if the file is existed and if the file is empty
            if(file.Exists && !file.Length.Equals(0))
            {
                // CLear the List, read the file and show content
                lvEtudiants.Items.Clear(); 
                foreach (String line in File.ReadAllLines(fileName))
                {
                    String[] text = line.Split(' ');

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = text[0];
                    listViewItem.SubItems.Add(text[1] + " " + text[2]);
                    listViewItem.SubItems.Add(Convert.ToString(text[3]));
                    listViewItem.SubItems.Add(text[4]);
                    lvEtudiants.Items.Add(listViewItem);
                }
            }
          
        }


        /// <summary>
        /// This method check if all TextBox is not empty to enable the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check(object sender, EventArgs e)
        {

            bool checkNom = txtBoxNom.Text.Trim() != String.Empty;
            bool checkPrenom1 = txtBoxPrenom1.Text.Trim() != String.Empty;
            bool checkPrenom2 = txtBoxPrenom2.Text.Trim() != String.Empty;
            bool checkAge = txtBoxAge.Text.Trim() != String.Empty;
            bool checkNatinalite = txtBoxNationalite.Text.Trim() != String.Empty;
            bool checkAdresse = txtBoxAdresse.Text.Trim() != String.Empty;
            bool checkVille = txtBoxVille.Text.Trim() != String.Empty;
            bool checkPays = txtBoxPays.Text.Trim() != String.Empty;
            bool checkTelephone = txtBoxTelephone.Text.Trim() != String.Empty;

            if (checkNom && checkPrenom1 && checkPrenom2 && checkAge && checkNatinalite && checkAdresse && checkVille && checkPays && checkTelephone)
            {
                btnSave.Enabled = true;
            }
        }

    }
}
