using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusC
{
    public partial class Form1 : Form
    {
        List<int> shuffled = new List<int>() {1};
        int[] cartes = new int[4];
        int numCarte = 4, nombreMus = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evénement click sur le bouton btnMelanger
        /// appelle la procédure Melanger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMelanger_Click(object sender, EventArgs e)
        {
            Melanger();
        }

        public void Melanger()
        {
            List<int> values = new List<int>() { 1 };
            // remplissage de liste values avec les 40 premiers entiers
            for (int k = 2; k < 41; k++)
            {
                values.Add(k);
            }
            // affectation dans la liste shuffled de valeurs mélangées de la liste values
            Random rand = new Random();
            shuffled = values.OrderBy(_ => rand.Next()).ToList();
            // mise à jour de la ListBox
            lstCartes.Items.Clear();
            for (int k = 0; k < 40; k++)
            {
                lstCartes.Items.Add(shuffled[k]);
            }
            // affectation des 4 premières valeurs de shuffled dans le tableau cartes
            for (int k = 0; k < 4; k++)
            {
                cartes[k] = shuffled[k];
            }
            // rendre les cartes visibles
            foreach (Button btn in grpJoueur1.Controls)
            {
                btn.Visible = true;
            }
            btnVoir.Enabled = true;
        }

        /// <summary>
        /// Evénement click sur un bouton carte
        /// déplace la carte vers le bas (échangée) ou vers le haut(conservée)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarte1_Click(object sender, EventArgs e)
        {
            // récupération de l'objet concerné par le clic
            Button btn = (Button)sender;
            // modifie la position du bouton et compte les cartes à échanger
            if(btn.Top == 12)
            {
                btn.Top = 80;
                nombreMus++;
            }
            else
            {
                btn.Top = 12;
                nombreMus--;
            }
            // active le bouton btnMus s'il y a au moins une carte à échanger
            btnMus.Enabled = nombreMus > 0;
        }

        /// <summary>
        /// Création des 4 cartes dans grpJoueur1
        /// </summary>
        private void CreerPlusieursBoutons()
        {
            for (int k = 0; k < 4; k++)
            {
                // déclaration et création d'un bouton
                Button btn = new Button();
                grpJoueur1.Controls.Add(btn);
                // image
                btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                // position et autres propriétés
                btn.Location = new System.Drawing.Point(4+104 * k, 12);
                btn.Name = "btnCarte" + k;
                btn.Size = new System.Drawing.Size(102, 168);
                btn.TabIndex = 3 + k;
                btn.UseVisualStyleBackColor = true;
                btn.Visible = false;
                // affectation de l'événement commun aux boutons cartes
                btn.Click += new EventHandler(btnCarte1_Click);
            }
        }
        /// <summary>
        /// affiche les cartes
        /// </summary>
        private void MettreAJourImages()
        {
            int k = 0;
            foreach (Button btn in grpJoueur1.Controls)
            {
                btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(cartes[k].ToString());
                btn.Visible = true;
                k++;
            }
        }
        /// <summary>
        /// cache les cartes en remettant l'image sur dos
        /// </summary>
        private void CacherCartes()
        {
            foreach (Button btn in grpJoueur1.Controls)
            {
                btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
            }
        }

        /// <summary>
        /// chargement du form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            CreerPlusieursBoutons();
            btnMus.Enabled = false;
            btnVoir.Enabled = false;
        }

        /// <summary>
        /// Evénement MouseHover sur le bouton btnVoir
        /// montre les cartes quand on survole ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages();
        }

        /// <summary>
        /// Evénement MouseLeave sur le bouton btnVoir
        /// cache les cartes quand on quitte ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes();
        }

        /// <summary>
        /// Evénement click sur le bouton btnMus
        /// Echange les cartes qui sont baissées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMus_Click(object sender, EventArgs e)
        {
            {
                int k = 0;
                foreach (Button btn in grpJoueur1.Controls)
                {
                    if(btn.Top == 80)
                    {
                        cartes[k] = shuffled[numCarte];
                        btn.Top = 12;
                        numCarte++;
                    }
                    k++;
                    MettreAJourImages();
                    CacherCartes();
                }
            }
        }
    }
}
