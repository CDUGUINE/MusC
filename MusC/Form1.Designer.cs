
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
            this.btnVoir = new System.Windows.Forms.Button();
            this.btnMus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCartes
            // 
            this.lstCartes.FormattingEnabled = true;
            this.lstCartes.ItemHeight = 16;
            this.lstCartes.Location = new System.Drawing.Point(580, 12);
            this.lstCartes.Name = "lstCartes";
            this.lstCartes.Size = new System.Drawing.Size(84, 132);
            this.lstCartes.TabIndex = 0;
            // 
            // btnMelanger
            // 
            this.btnMelanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMelanger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMelanger.Location = new System.Drawing.Point(580, 150);
            this.btnMelanger.Name = "btnMelanger";
            this.btnMelanger.Size = new System.Drawing.Size(84, 27);
            this.btnMelanger.TabIndex = 1;
            this.btnMelanger.Text = "mélanger";
            this.btnMelanger.UseVisualStyleBackColor = true;
            this.btnMelanger.Click += new System.EventHandler(this.btnMelanger_Click);
            // 
            // grpJoueur1
            // 
            this.grpJoueur1.Location = new System.Drawing.Point(12, 12);
            this.grpJoueur1.Name = "grpJoueur1";
            this.grpJoueur1.Size = new System.Drawing.Size(562, 230);
            this.grpJoueur1.TabIndex = 4;
            this.grpJoueur1.TabStop = false;
            this.grpJoueur1.Text = "Joueur 1";
            // 
            // btnVoir
            // 
            this.btnVoir.Location = new System.Drawing.Point(12, 248);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(75, 23);
            this.btnVoir.TabIndex = 5;
            this.btnVoir.Text = "voir";
            this.btnVoir.UseVisualStyleBackColor = true;
            this.btnVoir.MouseLeave += new System.EventHandler(this.btnVoir_MouseLeave);
            this.btnVoir.MouseHover += new System.EventHandler(this.btnVoir_MouseHover);
            // 
            // btnMus
            // 
            this.btnMus.Location = new System.Drawing.Point(93, 248);
            this.btnMus.Name = "btnMus";
            this.btnMus.Size = new System.Drawing.Size(75, 23);
            this.btnMus.TabIndex = 6;
            this.btnMus.Text = "mus";
            this.btnMus.UseVisualStyleBackColor = true;
            this.btnMus.Click += new System.EventHandler(this.btnMus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 279);
            this.Controls.Add(this.btnMus);
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.grpJoueur1);
            this.Controls.Add(this.btnMelanger);
            this.Controls.Add(this.lstCartes);
            this.Name = "Form1";
            this.Text = "Mus en C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartes;
        private System.Windows.Forms.Button btnMelanger;
        private System.Windows.Forms.GroupBox grpJoueur1;
        private System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Button btnMus;
    }
}

