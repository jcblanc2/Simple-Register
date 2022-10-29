
namespace Etudiants
{
    partial class frmEtudiants
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
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxNationalite = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom2 = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom1 = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxTelephone = new System.Windows.Forms.TextBox();
            this.txtBoxPays = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNationalite = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPrenom2 = new System.Windows.Forms.Label();
            this.lblPrenom1 = new System.Windows.Forms.Label();
            this.lblAdresseRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvEtudiants = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(93, 51);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(97, 21);
            this.txtBoxNom.TabIndex = 0;
            this.txtBoxNom.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxNationalite
            // 
            this.txtBoxNationalite.Location = new System.Drawing.Point(93, 227);
            this.txtBoxNationalite.Name = "txtBoxNationalite";
            this.txtBoxNationalite.Size = new System.Drawing.Size(97, 21);
            this.txtBoxNationalite.TabIndex = 4;
            this.txtBoxNationalite.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(93, 186);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(97, 21);
            this.txtBoxAge.TabIndex = 3;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxPrenom2
            // 
            this.txtBoxPrenom2.Location = new System.Drawing.Point(93, 141);
            this.txtBoxPrenom2.Name = "txtBoxPrenom2";
            this.txtBoxPrenom2.Size = new System.Drawing.Size(97, 21);
            this.txtBoxPrenom2.TabIndex = 2;
            this.txtBoxPrenom2.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxPrenom1
            // 
            this.txtBoxPrenom1.Location = new System.Drawing.Point(93, 101);
            this.txtBoxPrenom1.Name = "txtBoxPrenom1";
            this.txtBoxPrenom1.Size = new System.Drawing.Size(97, 21);
            this.txtBoxPrenom1.TabIndex = 1;
            this.txtBoxPrenom1.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(580, 103);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(97, 21);
            this.txtBoxVille.TabIndex = 6;
            this.txtBoxVille.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(580, 54);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(97, 21);
            this.txtBoxAdresse.TabIndex = 5;
            this.txtBoxAdresse.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxTelephone
            // 
            this.txtBoxTelephone.Location = new System.Drawing.Point(580, 189);
            this.txtBoxTelephone.Name = "txtBoxTelephone";
            this.txtBoxTelephone.Size = new System.Drawing.Size(97, 21);
            this.txtBoxTelephone.TabIndex = 8;
            this.txtBoxTelephone.TextChanged += new System.EventHandler(this.check);
            // 
            // txtBoxPays
            // 
            this.txtBoxPays.Location = new System.Drawing.Point(580, 144);
            this.txtBoxPays.Name = "txtBoxPays";
            this.txtBoxPays.Size = new System.Drawing.Size(97, 21);
            this.txtBoxPays.TabIndex = 7;
            this.txtBoxPays.TextChanged += new System.EventHandler(this.check);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(26, 54);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nom";
            // 
            // lblNationalite
            // 
            this.lblNationalite.AutoSize = true;
            this.lblNationalite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNationalite.ForeColor = System.Drawing.Color.Black;
            this.lblNationalite.Location = new System.Drawing.Point(26, 234);
            this.lblNationalite.Name = "lblNationalite";
            this.lblNationalite.Size = new System.Drawing.Size(66, 15);
            this.lblNationalite.TabIndex = 20;
            this.lblNationalite.Text = "Nationalite";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(26, 193);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age";
            // 
            // lblPrenom2
            // 
            this.lblPrenom2.AutoSize = true;
            this.lblPrenom2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrenom2.ForeColor = System.Drawing.Color.Black;
            this.lblPrenom2.Location = new System.Drawing.Point(26, 147);
            this.lblPrenom2.Name = "lblPrenom2";
            this.lblPrenom2.Size = new System.Drawing.Size(58, 15);
            this.lblPrenom2.TabIndex = 22;
            this.lblPrenom2.Text = "Prenom2";
            // 
            // lblPrenom1
            // 
            this.lblPrenom1.AutoSize = true;
            this.lblPrenom1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrenom1.ForeColor = System.Drawing.Color.Black;
            this.lblPrenom1.Location = new System.Drawing.Point(26, 103);
            this.lblPrenom1.Name = "lblPrenom1";
            this.lblPrenom1.Size = new System.Drawing.Size(58, 15);
            this.lblPrenom1.TabIndex = 23;
            this.lblPrenom1.Text = "Prenom1";
            // 
            // lblAdresseRue
            // 
            this.lblAdresseRue.AutoSize = true;
            this.lblAdresseRue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdresseRue.ForeColor = System.Drawing.Color.Black;
            this.lblAdresseRue.Location = new System.Drawing.Point(494, 57);
            this.lblAdresseRue.Name = "lblAdresseRue";
            this.lblAdresseRue.Size = new System.Drawing.Size(77, 15);
            this.lblAdresseRue.TabIndex = 24;
            this.lblAdresseRue.Text = "Adresse Rue";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVille.ForeColor = System.Drawing.Color.Black;
            this.lblVille.Location = new System.Drawing.Point(494, 107);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(30, 15);
            this.lblVille.TabIndex = 28;
            this.lblVille.Text = "Ville";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTelephone.ForeColor = System.Drawing.Color.Black;
            this.lblTelephone.Location = new System.Drawing.Point(494, 197);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(66, 15);
            this.lblTelephone.TabIndex = 26;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPays.ForeColor = System.Drawing.Color.Black;
            this.lblPays.Location = new System.Drawing.Point(494, 152);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(33, 15);
            this.lblPays.TabIndex = 27;
            this.lblPays.Text = "Pays";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(29, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 26);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(590, 489);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 26);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Annuler";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvEtudiants
            // 
            this.lvEtudiants.HideSelection = false;
            this.lvEtudiants.Location = new System.Drawing.Point(29, 280);
            this.lvEtudiants.Name = "lvEtudiants";
            this.lvEtudiants.Size = new System.Drawing.Size(648, 190);
            this.lvEtudiants.TabIndex = 11;
            this.lvEtudiants.UseCompatibleStateImageBehavior = false;
            // 
            // frmEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 527);
            this.Controls.Add(this.lvEtudiants);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblAdresseRue);
            this.Controls.Add(this.lblPrenom1);
            this.Controls.Add(this.lblPrenom2);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNationalite);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxPays);
            this.Controls.Add(this.txtBoxTelephone);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.txtBoxPrenom1);
            this.Controls.Add(this.txtBoxPrenom2);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxNationalite);
            this.Controls.Add(this.txtBoxNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEtudiants";
            this.Text = "frmEtudiant";
            this.Load += new System.EventHandler(this.frmEtudiants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxNationalite;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxPrenom2;
        private System.Windows.Forms.TextBox txtBoxPrenom1;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxTelephone;
        private System.Windows.Forms.TextBox txtBoxPays;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNationalite;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPrenom2;
        private System.Windows.Forms.Label lblPrenom1;
        private System.Windows.Forms.Label lblAdresseRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvEtudiants;
    }
}

