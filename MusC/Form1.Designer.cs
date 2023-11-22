
namespace MusC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCartes = new System.Windows.Forms.ListBox();
            this.btnMelanger = new System.Windows.Forms.Button();
            this.grpJoueur1 = new System.Windows.Forms.GroupBox();
            this.btnVoir1 = new System.Windows.Forms.Button();
            this.btnMus = new System.Windows.Forms.Button();
            this.grpJoueur2 = new System.Windows.Forms.GroupBox();
            this.btnVoir2 = new System.Windows.Forms.Button();
            this.grpJoueur4 = new System.Windows.Forms.GroupBox();
            this.btnVoir4 = new System.Windows.Forms.Button();
            this.grpJoueur3 = new System.Windows.Forms.GroupBox();
            this.btnVoir3 = new System.Windows.Forms.Button();
            this.btnMusInfo = new System.Windows.Forms.Button();
            this.lstJetees = new System.Windows.Forms.ListBox();
            this.grpJoueur1.SuspendLayout();
            this.grpJoueur2.SuspendLayout();
            this.grpJoueur4.SuspendLayout();
            this.grpJoueur3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCartes
            // 
            this.lstCartes.FormattingEnabled = true;
            this.lstCartes.ItemHeight = 16;
            this.lstCartes.Location = new System.Drawing.Point(580, 78);
            this.lstCartes.Name = "lstCartes";
            this.lstCartes.Size = new System.Drawing.Size(84, 196);
            this.lstCartes.TabIndex = 10;
            // 
            // btnMelanger
            // 
            this.btnMelanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMelanger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMelanger.Location = new System.Drawing.Point(580, 12);
            this.btnMelanger.Name = "btnMelanger";
            this.btnMelanger.Size = new System.Drawing.Size(84, 27);
            this.btnMelanger.TabIndex = 0;
            this.btnMelanger.Text = "distribuer";
            this.btnMelanger.UseVisualStyleBackColor = true;
            this.btnMelanger.Click += new System.EventHandler(this.btnMelanger_Click);
            // 
            // grpJoueur1
            // 
            this.grpJoueur1.BackColor = System.Drawing.Color.Yellow;
            this.grpJoueur1.Controls.Add(this.btnVoir1);
            this.grpJoueur1.Location = new System.Drawing.Point(12, 12);
            this.grpJoueur1.Name = "grpJoueur1";
            this.grpJoueur1.Size = new System.Drawing.Size(562, 230);
            this.grpJoueur1.TabIndex = 6;
            this.grpJoueur1.TabStop = false;
            this.grpJoueur1.Tag = "";
            this.grpJoueur1.Text = "Joueur 1";
            // 
            // btnVoir1
            // 
            this.btnVoir1.BackColor = System.Drawing.Color.White;
            this.btnVoir1.BackgroundImage = global::MusC.Properties.Resources.oeil;
            this.btnVoir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir1.Location = new System.Drawing.Point(6, 197);
            this.btnVoir1.Name = "btnVoir1";
            this.btnVoir1.Size = new System.Drawing.Size(84, 27);
            this.btnVoir1.TabIndex = 1;
            this.btnVoir1.UseVisualStyleBackColor = false;
            this.btnVoir1.MouseLeave += new System.EventHandler(this.btnVoir1_MouseLeave);
            this.btnVoir1.MouseHover += new System.EventHandler(this.btnVoir1_MouseHover);
            // 
            // btnMus
            // 
            this.btnMus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMus.Location = new System.Drawing.Point(580, 45);
            this.btnMus.Name = "btnMus";
            this.btnMus.Size = new System.Drawing.Size(84, 27);
            this.btnMus.TabIndex = 5;
            this.btnMus.Text = "mus";
            this.btnMus.UseVisualStyleBackColor = true;
            this.btnMus.Click += new System.EventHandler(this.btnMus_Click);
            // 
            // grpJoueur2
            // 
            this.grpJoueur2.BackColor = System.Drawing.Color.White;
            this.grpJoueur2.Controls.Add(this.btnVoir2);
            this.grpJoueur2.Location = new System.Drawing.Point(12, 363);
            this.grpJoueur2.Name = "grpJoueur2";
            this.grpJoueur2.Size = new System.Drawing.Size(562, 230);
            this.grpJoueur2.TabIndex = 7;
            this.grpJoueur2.TabStop = false;
            this.grpJoueur2.Tag = "0";
            this.grpJoueur2.Text = "Joueur 2";
            // 
            // btnVoir2
            // 
            this.btnVoir2.BackColor = System.Drawing.Color.White;
            this.btnVoir2.BackgroundImage = global::MusC.Properties.Resources.oeil;
            this.btnVoir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir2.Location = new System.Drawing.Point(6, 197);
            this.btnVoir2.Name = "btnVoir2";
            this.btnVoir2.Size = new System.Drawing.Size(84, 27);
            this.btnVoir2.TabIndex = 2;
            this.btnVoir2.UseVisualStyleBackColor = false;
            this.btnVoir2.MouseLeave += new System.EventHandler(this.btnVoir2_MouseLeave);
            this.btnVoir2.MouseHover += new System.EventHandler(this.btnVoir2_MouseHover);
            // 
            // grpJoueur4
            // 
            this.grpJoueur4.BackColor = System.Drawing.Color.White;
            this.grpJoueur4.Controls.Add(this.btnVoir4);
            this.grpJoueur4.Location = new System.Drawing.Point(670, 12);
            this.grpJoueur4.Name = "grpJoueur4";
            this.grpJoueur4.Size = new System.Drawing.Size(561, 230);
            this.grpJoueur4.TabIndex = 9;
            this.grpJoueur4.TabStop = false;
            this.grpJoueur4.Tag = "0";
            this.grpJoueur4.Text = "Joueur 4";
            // 
            // btnVoir4
            // 
            this.btnVoir4.BackColor = System.Drawing.Color.White;
            this.btnVoir4.BackgroundImage = global::MusC.Properties.Resources.oeil;
            this.btnVoir4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir4.Location = new System.Drawing.Point(6, 197);
            this.btnVoir4.Name = "btnVoir4";
            this.btnVoir4.Size = new System.Drawing.Size(84, 27);
            this.btnVoir4.TabIndex = 4;
            this.btnVoir4.UseVisualStyleBackColor = false;
            this.btnVoir4.MouseLeave += new System.EventHandler(this.btnVoir4_MouseLeave);
            this.btnVoir4.MouseHover += new System.EventHandler(this.btnVoir4_MouseHover);
            // 
            // grpJoueur3
            // 
            this.grpJoueur3.BackColor = System.Drawing.Color.Yellow;
            this.grpJoueur3.Controls.Add(this.btnVoir3);
            this.grpJoueur3.Location = new System.Drawing.Point(670, 357);
            this.grpJoueur3.Name = "grpJoueur3";
            this.grpJoueur3.Size = new System.Drawing.Size(561, 230);
            this.grpJoueur3.TabIndex = 8;
            this.grpJoueur3.TabStop = false;
            this.grpJoueur3.Tag = "0";
            this.grpJoueur3.Text = "Joueur 3";
            // 
            // btnVoir3
            // 
            this.btnVoir3.BackColor = System.Drawing.Color.White;
            this.btnVoir3.BackgroundImage = global::MusC.Properties.Resources.oeil;
            this.btnVoir3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoir3.Location = new System.Drawing.Point(7, 197);
            this.btnVoir3.Name = "btnVoir3";
            this.btnVoir3.Size = new System.Drawing.Size(83, 27);
            this.btnVoir3.TabIndex = 3;
            this.btnVoir3.UseVisualStyleBackColor = false;
            this.btnVoir3.MouseLeave += new System.EventHandler(this.btnVoir3_MouseLeave);
            this.btnVoir3.MouseHover += new System.EventHandler(this.btnVoir3_MouseHover);
            // 
            // btnMusInfo
            // 
            this.btnMusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMusInfo.Location = new System.Drawing.Point(580, 45);
            this.btnMusInfo.Name = "btnMusInfo";
            this.btnMusInfo.Size = new System.Drawing.Size(84, 27);
            this.btnMusInfo.TabIndex = 11;
            this.btnMusInfo.TabStop = false;
            this.btnMusInfo.Text = "mus";
            this.btnMusInfo.UseVisualStyleBackColor = true;
            // 
            // lstJetees
            // 
            this.lstJetees.FormattingEnabled = true;
            this.lstJetees.ItemHeight = 16;
            this.lstJetees.Location = new System.Drawing.Point(580, 280);
            this.lstJetees.Name = "lstJetees";
            this.lstJetees.Size = new System.Drawing.Size(84, 308);
            this.lstJetees.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 605);
            this.Controls.Add(this.lstJetees);
            this.Controls.Add(this.btnMusInfo);
            this.Controls.Add(this.btnMus);
            this.Controls.Add(this.grpJoueur3);
            this.Controls.Add(this.grpJoueur4);
            this.Controls.Add(this.grpJoueur2);
            this.Controls.Add(this.grpJoueur1);
            this.Controls.Add(this.btnMelanger);
            this.Controls.Add(this.lstCartes);
            this.Name = "Form1";
            this.Text = "Mus en C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpJoueur1.ResumeLayout(false);
            this.grpJoueur2.ResumeLayout(false);
            this.grpJoueur4.ResumeLayout(false);
            this.grpJoueur3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartes;
        private System.Windows.Forms.Button btnMelanger;
        private System.Windows.Forms.GroupBox grpJoueur1;
        private System.Windows.Forms.Button btnVoir1;
        private System.Windows.Forms.Button btnMus;
        private System.Windows.Forms.GroupBox grpJoueur2;
        private System.Windows.Forms.Button btnVoir2;
        private System.Windows.Forms.GroupBox grpJoueur4;
        private System.Windows.Forms.GroupBox grpJoueur3;
        private System.Windows.Forms.Button btnVoir4;
        private System.Windows.Forms.Button btnVoir3;
        private System.Windows.Forms.Button btnMusInfo;
        private System.Windows.Forms.ListBox lstJetees;
    }
}

