using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Etudiants
{
    class Personne
    {
        // Declaration of all variables
        string _nom, _prenom1, _prenom2, _nationalite, _adresseRue, _ville, _pays, _telephone, _dateCree;
        int _age;


        // Costructor with some atributs
        public Personne(string Nom, string Prenom1, string Prenom2, int Age)
        {
            this.Nom = Nom;
            this.Prenom1 = Prenom1;
            this.Prenom2 = Prenom2;
            this.Age = Age;

        }
       

        // Contructor with all atributs
        public Personne(string Nom, string Prenom1, string Prenom2, int Age, string Nationalite, string AdresseRue, string Ville, string Pays, string Telephone)
        {
            this.Nom = Nom;
            this.Prenom1 = Prenom1;
            this.Prenom2 = Prenom2;
            this.Age = Age;
            this.Nationalite = Nationalite;
            this.AdresseRue = AdresseRue;
            this.Ville = Ville;
            this.Pays = Pays;
            this.Telephone = Telephone;
            //this.DateCree = DateCree;
        }

        

        // Define getters and setters
        public string Nom
        {
            get => _nom;

            set
            {
                _nom = Capitalize(value.Trim());
            }
        }

        public string Prenom1
        {
            get => _prenom1;

            set
            {
                _prenom1 = Capitalize(value.Trim());
            }
        }


        public string Prenom2
        {
            get => _prenom2;

            set
            {
                _prenom2 = Capitalize(value.Trim());
            }
        }

        public int Age
        {
            get => _age;

            set
            {
                if (value >= 0 && value <= 150)
                {
                    _age = value;
                }
                else
                {
                    _age = -1;
                }
            }
        }

        public string Nationalite
        {
            get => _nationalite;
            set => _nationalite = value;
        }

        public string AdresseRue
        {
            get => _adresseRue;
            set => _adresseRue = value;
        }

        public string Ville
        {
            get => _ville;
            set => _ville = value;
        }

        public string Pays
        {
            get => _pays;
            set => _pays = value;
        }

        public string Telephone
        {
            get => _telephone;
            set => _telephone = value;
        }

        
        public string DateCree
        {
            get => _dateCree;
            set
            {
                // Get the current date
                DateTime now = DateTime.Now;
                string FormatsOfDate = String.Format("{0}/{1}/{2}", now.Day, now.Month, now.Year);
                _dateCree = FormatsOfDate;
            }
        }



        /// <summary>
        /// Method to display the full name of the person
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            return _prenom1 + " " + _prenom2 + " " + _nom;
        }


        /// <summary>
        /// Method to change a string (first letter in uppercase and the rest in lowercase)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Capitalize(string text)
        {
            string result = "";
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string firstLetter = words[i].Substring(0, 1).ToUpper();
                string restText = words[i].Substring(1).ToLower();
                result += firstLetter + restText + " ";
            }

            return result;
        }


    }
}
