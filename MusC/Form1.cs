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
        private void BtnMelanger_Click(object sender, EventArgs e)
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
            MajLstBox();
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
                        if ((string)btn.Tag == "voir")
                        {
                            btn.Text = "0";
                        }
                    }
                }
            }
            BtnMus.Visible = false;
            BtnMusInfo.Visible = true;
        }

        /// <summary>
        /// met à jour la liste des cartes suite à la distribution
        /// </summary>
        private void MajLstBox()
        {
            // mise à jour de la ListBox
            LstCartes.Items.Clear();
            int nombreCartes = cartesMelangees.Count;
            if (nombreCartes == 40)
            {
                LstCartes.Items.Add("16 cartes");
                LstCartes.Items.Add("distribuées");
                for (int k = 0; k < 16; k++)
                {
                    LstCartes.Items.Add(cartesMelangees[k]);
                }
                LstCartes.Items.Add("");
                LstCartes.Items.Add("24 cartes");
                LstCartes.Items.Add("à distribuer");
                for (int k = 16; k < 40; k++)
                {
                    LstCartes.Items.Add(cartesMelangees[k]);
                }
            }
            else
            {
                int nombreJetees = cartesOrdonnees.Count;
                LstCartes.Items.Add(nombreCartes + " cartes");
                LstCartes.Items.Add("à distribuer");
                for (int k = 0; k < nombreCartes; k++)
                {
                    LstCartes.Items.Add(cartesMelangees[k]);
                }
                LstCartes.Items.Add("");
                LstCartes.Items.Add(nombreJetees + " cartes");
                LstCartes.Items.Add("à distribuer");
                for (int k = 0; k < cartesOrdonnees.Count; k++)
                {
                    LstCartes.Items.Add(cartesOrdonnees[k]);
                }
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
        private void BtnCarte1_Click(object sender, EventArgs e)
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
            BtnMus.Visible = ((int)GrpJoueur1.Tag * (int)GrpJoueur2.Tag * (int)GrpJoueur3.Tag * (int)GrpJoueur4.Tag) > 0;
            BtnMusInfo.Visible = !BtnMus.Visible;
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
                        BtnCarte btn = new BtnCarte();
                        grp.Controls.Add(btn);
                        btn.Location = new Point(4 + 104 * k, 12);
                        // affectation de l'événement commun aux boutons cartes
                        btn.Click += new EventHandler(BtnCarte1_Click);
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
            {
                if (btn is BtnCarte)
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
            // procédure désactivée lors des phases de tests
            if (!ChkTest.Checked)
            {
                System.Collections.IList listCartes = grp.Controls;
                foreach (Button btn in grp.Controls)
                {
                    if (btn is BtnCarte)
                    {
                        btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
                    }
                    else
                    {
                        try
                        {
                            btn.Text = (int.Parse(btn.Text) + 1).ToString();
                        }
                        catch { }
                    }
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
            BtnMus.Visible = false;
            BtnMusInfo.Visible = true;
            BtnVoir1.Visible = false;
            BtnVoir2.Visible = false;
            BtnVoir3.Visible = false;
            BtnVoir4.Visible = false;
            GrpJoueur1.Tag = 0;
            GrpJoueur2.Tag = 0;
            GrpJoueur3.Tag = 0;
            GrpJoueur4.Tag = 0;
            // message au survol du bouton BtnMusInfo
            ToolTip mesMus = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500
            };
            mesMus.SetToolTip(BtnMusInfo, "Chaque joueur doit échanger au moins une carte");
            // message au survol du ChecBox ChkTest
            ToolTip mesTest = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500
            };
            mesTest.SetToolTip(ChkTest, "Cochez en phase de tests");
            // message au survol de la ListBox LstCartes
            ToolTip mesCartes = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500
            };
            mesCartes.SetToolTip(LstCartes, "Le chiffre des unités donne la valeur de la carte.\nCas particuliers : 8 est un 10, 9 un 11 et 0 un 12");
        }

        /// <summary>
        /// Evénement MouseHover sur le bouton btnVoir
        /// montre les cartes quand on survole ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVoir1_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(GrpJoueur1, 1);
        }

        /// <summary>
        /// Evénement MouseLeave sur le bouton btnVoir
        /// cache les cartes quand on quitte ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVoir1_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(GrpJoueur1);
        }

        private void BtnVoir2_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(GrpJoueur2, 2);
        }

        private void BtnVoir2_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(GrpJoueur2);
        }

        private void BtnVoir3_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(GrpJoueur3, 3);
        }

        private void BtnVoir3_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(GrpJoueur3);
        }

        private void BtnVoir4_MouseHover(object sender, EventArgs e)
        {
            MettreAJourImages(GrpJoueur4, 4);
        }

        private void BtnVoir4_MouseLeave(object sender, EventArgs e)
        {
            CacherCartes(GrpJoueur4);
        }

        /// <summary>
        /// Evénement click sur le bouton btnMus
        /// Echange les cartes qui sont baissées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMus_Click(object sender, EventArgs e)
        {
            ChangerCartes(0, GrpJoueur1);
            ChangerCartes(4, GrpJoueur2);
            ChangerCartes(8, GrpJoueur3);
            ChangerCartes(12, GrpJoueur4);
            MettreAJourImages(GrpJoueur1, 1);
            CacherCartes(GrpJoueur1);
            MettreAJourImages(GrpJoueur2, 2);
            CacherCartes(GrpJoueur2);
            MettreAJourImages(GrpJoueur3, 3);
            CacherCartes(GrpJoueur3);
            MettreAJourImages(GrpJoueur4, 4);
            CacherCartes(GrpJoueur4);
            BtnVoir1.Text = "0";
            BtnVoir2.Text = "0";
            BtnVoir3.Text = "0";
            BtnVoir4.Text = "0";
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
                if (btn is BtnCarte)
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
                        MajLstBox();
                    }
                    k++;
                }
            }
        }

        /// <summary>
        /// permet de faire apparaître les éléments nécessaires aux tests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkTest_CheckedChanged(object sender, EventArgs e)
        {
            LstCartes.Visible = ChkTest.Checked;
        }

        private void BtnChangeNom(object sender, EventArgs e)
        {
            NouveauNom(GrpJoueur1, 1);
        }

        private void NouveauNom(GroupBox grp, int numJ)
        {
            Form2 maMsgBox = new Form2();
            maMsgBox.ShowDialog();
            string title = maMsgBox.Reponse;
            if (title.Length > 3 && title.EndsWith("%"))
            {
                grp.Text = "J" + numJ + " " + title.Substring(0, title.Length - 1);
            }
        }

        private void BtnChangeNom2_Click(object sender, EventArgs e)
        {
            NouveauNom(GrpJoueur2, 2);
        }

        private void BtnChangeNom3_Click(object sender, EventArgs e)
        {
            NouveauNom(GrpJoueur3, 3);
        }

        private void BtnChangeNom4_Click(object sender, EventArgs e)
        {
            NouveauNom(GrpJoueur4, 4);
        }
    }
}
