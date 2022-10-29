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
/// <summary>
/// Cours: C#
/// Name: John Clayton Blanc
/// Date: 30 sep 2022
/// Univérsite Espoir
/// </summary>

namespace Etudiants
{
    /// <summary>
    /// This class creates a form that allows the user 
    /// to save and display data about a person.
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
            String age = txtBoxAge.Text;
            String nationalite = txtBoxNationalite.Text;
            String adresse = txtBoxAdresse.Text;
            String ville = txtBoxVille.Text;
            String pays = txtBoxPays.Text;
            String telephone = txtBoxTelephone.Text;

            // Check if all data are in the right format
            if (!isDigit(txtBoxAge.Text) || !isDigit(telephone) || !isAlpha(nom) || !isAlpha(prenom1) || !isAlpha(prenom2)
                || !isAlpha(nationalite) || !isAlpha(ville) || !isAlpha(pays))
            {
                messageErrorNotDigit(isDigit(age), "Age");
                messageErrorNotDigit(isDigit(telephone), "Téléphone");
                messageErrorNotLetter(isAlpha(nom), "Nom");
                messageErrorNotLetter(isAlpha(prenom1), "Prénom1");
                messageErrorNotLetter(isAlpha(prenom2), "Prénom2");
                messageErrorNotLetter(isAlpha(nationalite), "Nationalité");
                messageErrorNotLetter(isAlpha(ville), "Ville");
                messageErrorNotLetter(isAlpha(pays), "Pays");
            }
            else
            {
                int Age = Convert.ToInt32(age);
                // Create an instance of the class Personne
                Personne personne = new Personne(nom, prenom1, prenom2, Age, nationalite, adresse, ville, pays, telephone, Personne.currentDate);
                personnes.Add(personne);

                // Appending the given texts
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    // Format the character string
                    string formatData = String.Format("{0}{1}{2}{3} {4} {5} {6} {7} {8} {9}", personne.Nom, personne.Prenom1, personne.Prenom2,
                        personne.Age, personne.Telephone, personne.Nationalite, personne.AdresseRue, personne.Ville, personne.Pays, personne.DateCree);
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
        /// This method load the form and read the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEtudiants_Load(object sender, EventArgs e)
        {
            // Add different columns to the ListView
            int width = 160;
            lvEtudiants.View = View.Details;
            lvEtudiants.Columns.Add("Nom", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Prénom", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Age", width, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Téléphone", width, HorizontalAlignment.Left);

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
            bool checkAge = txtBoxAge.Text.Trim() != String.Empty;
            bool checkNatinalite = txtBoxNationalite.Text.Trim() != String.Empty;
            bool checkAdresse = txtBoxAdresse.Text.Trim() != String.Empty;
            bool checkVille = txtBoxVille.Text.Trim() != String.Empty;
            bool checkPays = txtBoxPays.Text.Trim() != String.Empty;
            bool checkTelephone = txtBoxTelephone.Text.Trim() != String.Empty;

            if (checkNom && checkPrenom1 &&  checkAge && checkNatinalite && checkAdresse && checkVille && checkPays && checkTelephone)
            {
                btnSave.Enabled = true;
            }
        }

        /// <summary>
        /// Method to show a massage on the screen 
        /// if age or telephone don't have only digit
        /// </summary>
        /// <param name="val"></param>
        /// <param name="nameComponent"></param>
        private void messageErrorNotDigit(bool val, string nameComponent)
        {
            if (!val)
            {
                MessageBox.Show($"Only digit for {nameComponent}", "frmEtudiant");
            }
        }

        /// <summary>
        /// Method to show a massage on the screen 
        /// if nom, prenom ... don't have only letter
        /// </summary>
        /// <param name="val"></param>
        /// <param name="nameComponent"></param>
        private void messageErrorNotLetter(bool val, string nameComponent)
        {
            if (!val)
            {
                MessageBox.Show($"{nameComponent} must contain only letters", "frmEtudiant");
            }
        }

        /// <summary>
        /// Methode to check if a string contain only letter
        /// </summary>
        /// <param name="chaine"></param>
        /// <returns></returns>
        private bool isAlpha(string chaine)
        {
            return chaine.All(c => !Char.IsDigit(c));
            
        }

        /// <summary>
        ///  Methode to check if a string contain only digit
        /// </summary>
        /// <param name="chaine"></param>
        /// <returns></returns>
        private bool isDigit(string chaine)
        {
            return chaine.All(c => !Char.IsLetter(c));
        }
    }
}
