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
        public List<int> cartesOrdonnees = new List<int>() { 1 };
        public List<int> cartesMelangees = new List<int>() { 1 };
        public int[] cartesEnMain = new int[16];

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

        /// <summary>
        /// Ensemble des commandes effectuées lors d'une distribution
        /// </summary>
        public void Melanger()
        {
            // initialisation des variables
            //numCarte = 16;
            cartesOrdonnees.Clear();
            // remplissage de liste cartesOrdonnees avec les 40 premiers entiers
            for (int k = 1; k < 41; k++)
            {
                cartesOrdonnees.Add(k);
            }
            MelangeListe(cartesOrdonnees);
            MajLstBox1();
            MajLstBox2();
            // affectation des 16 premières valeurs de cartesMelangees dans le tableau cartes
            for (int k = 0; k < 16; k++)
            {
                cartesEnMain[k] = cartesMelangees[0];
                cartesMelangees.RemoveAt(0);
            }
            // rendre les cartes visibles
            foreach (Control grp in this.Controls)
            {
                if (grp is GroupBox)
                {
                    foreach (Button btn in grp.Controls)
                    {
                        btn.Visible = true;
                    }
                    btnVoir1.Visible = true;
                    btnVoir2.Visible = true;
                    btnVoir3.Visible = true;
                    btnVoir4.Visible = true;
                }
            }
        }

        /// <summary>
        /// met à jour la liste des cartes restantes suite à la distribution
        /// </summary>
        private void MajLstBox1()
        {
            // mise à jour de la ListBox
            lstCartes.Items.Clear();
            for (int k = 0; k < cartesMelangees.Count; k++)
            {
                lstCartes.Items.Add(((k + 1) + " : " + cartesMelangees[k]).ToString());
            }
        }

        /// <summary>
        /// met à jour la liste des cartes jetées suite à la distribution
        /// </summary>
        private void MajLstBox2()
        {
            // mise à jour de la ListBox
            lstJetees.Items.Clear();
            for (int k = 0; k < cartesOrdonnees.Count; k++)
            {
                lstJetees.Items.Add(((k + 1) + " : " + cartesOrdonnees[k]).ToString());
            }
        }

    /// <summary>
    /// mélange la liste cartesOrdonnees pour obtenir la liste cartesMelangees
    /// </summary>
    /// <param name="cartesOrdonnees"></param>
        private void MelangeListe(List<int> cartesOrdonnees)
        {
            // affectation dans la liste cartesMelangees de valeurs mélangées de la liste cartesOrdonnees
            Random rand = new Random();
            cartesMelangees = cartesOrdonnees.OrderBy(_ => rand.Next()).ToList();
            // nettoyage de cartesOrdonnees
            cartesOrdonnees.Clear();
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
                btn.Parent.Tag = (int)btn.Parent.Tag + 1;
            }
            else
            {
                btn.Top = 12;
                btn.Parent.Tag = (int)btn.Parent.Tag - 1;
            }
            // active le bouton btnMus s'il y a au moins une carte à échanger pour chaque joueur
            btnMus.Visible = ((int)grpJoueur1.Tag * (int)grpJoueur2.Tag * (int)grpJoueur3.Tag * (int)grpJoueur4.Tag) > 0;
            btnMusInfo.Visible = !btnMus.Visible;
        }

        /// <summary>
        /// Création des 4 cartes dans chaque grpJoueur
        /// </summary>
        private void CreerPlusieursBoutons()
        {
            int nbGroupes = 0;
            foreach (Control grp in this.Controls)
            {
                if (grp is GroupBox)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        // déclaration et création d'un bouton
                        Button btn = new Button();
                        grp.Controls.Add(btn);
                        // image
                        btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                        // position et autres propriétés
                        btn.Location = new Point(4 + 104 * k, 12);
                        btn.Size = new Size(102, 168);
                        btn.UseVisualStyleBackColor = true;
                        btn.Visible = false;
                        // affectation de l'événement commun aux boutons cartes
                        btn.Click += new EventHandler(btnCarte1_Click);
                    }
                    nbGroupes++;
                }
            }
        }

        /// <summary>
        /// affiche les cartes
        /// </summary>
        private void MettreAJourImages(GroupBox grp, int joueur)
        {
            int j = (joueur - 1) * 4;
            foreach (Button btn in grp.Controls)
                // tous les boutons cartes mais pas le bouton voir
                if(btn.Size.Height > 40)
                {
                    {
                        btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(cartesEnMain[j].ToString());
                        btn.Visible = true;
                        j++;
                    }
            }
        }

        /// <summary>
        /// cache les cartes en remettant l'image sur dos
        /// </summary>
        private void CacherCartes(GroupBox grp)
        {
            foreach (Button btn in grp.Controls)
                if (btn.Size.Height > 40)
                {
                    {
                        btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
                    }
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
            btnMus.Visible = false;
            btnMusInfo.Visible = true;
            btnVoir1.Visible = false;
            btnVoir2.Visible = false;
            btnVoir3.Visible = false;
            btnVoir4.Visible = false;
            grpJoueur1.Tag = 0;
            grpJoueur2.Tag = 0;
            grpJoueur3.Tag = 0;
            grpJoueur4.Tag = 0;
            // message au survol du bouton btnMusInfo
            ToolTip mesMus = new ToolTip();
            mesMus.AutoPopDelay = 5000;
            mesMus.InitialDelay = 1000;
            mesMus.ReshowDelay = 500;
            mesMus.SetToolTip(btnMusInfo, "Chaque joueur doit échanger au moins une carte");
        }

        /// <summary>
        /// Evénement MouseHover sur le bouton btnVoir
        /// montre les cartes quand on survole ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir1_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(grpJoueur1, 1);
        }

        /// <summary>
        /// Evénement MouseLeave sur le bouton btnVoir
        /// cache les cartes quand on quitte ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoir1_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(grpJoueur1);
        }

        private void btnVoir2_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(grpJoueur2, 2);
        }

        private void btnVoir2_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(grpJoueur2);
        }

        private void btnVoir3_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(grpJoueur3, 3);
        }

        private void btnVoir3_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(grpJoueur3);
        }

        private void btnVoir4_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(grpJoueur4, 4);
        }

        private void btnVoir4_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(grpJoueur4);
        }

        /// <summary>
        /// Evénement click sur le bouton btnMus
        /// Echange les cartes qui sont baissées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMus_Click(object sender, EventArgs e)
        {
            ChangerCartes(0, grpJoueur1);
            ChangerCartes(4, grpJoueur2);
            ChangerCartes(8, grpJoueur3);
            ChangerCartes(12, grpJoueur4);
            MettreAJourImages(grpJoueur1, 1);
            CacherCartes(grpJoueur1);
            MettreAJourImages(grpJoueur2, 2);
            CacherCartes(grpJoueur2);
            MettreAJourImages(grpJoueur3, 3);
            CacherCartes(grpJoueur3);
            MettreAJourImages(grpJoueur4, 4);
            CacherCartes(grpJoueur4);
        }

        /// <summary>
        /// échange les cartes qui sont abaissées
        /// </summary>
        /// <param name="k"></param>
        /// <param name="grp"></param>
        private void ChangerCartes(int k, Control grp)
        {
            foreach (Button btn in grp.Controls)
            {
                if (btn.Size.Height > 40)
                {
                    if (btn.Top == 80)
                    {
                        // mélange les cartes jetées s'il ne reste plus de carte à distribuer
                        if (cartesMelangees.Count == 0)
                        {
                            MelangeListe(cartesOrdonnees);
                        }
                        cartesOrdonnees.Add(cartesEnMain[k]);
                        cartesEnMain[k] = cartesMelangees[0];
                        cartesMelangees.RemoveAt(0);
                        btn.Top = 12;
                        MajLstBox1();
                        MajLstBox2();
                    }
                    k++;
                }
            }
        }
    }
}
