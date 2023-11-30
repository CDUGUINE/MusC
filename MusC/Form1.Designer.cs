
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
            this.components = new System.ComponentModel.Container();
            this.LstCartes = new System.Windows.Forms.ListBox();
            this.BtnMelanger = new System.Windows.Forms.Button();
            this.GrpJoueur1 = new System.Windows.Forms.GroupBox();
            this.BtnChangeNom1 = new System.Windows.Forms.Button();
            this.BtnVoir1 = new System.Windows.Forms.Button();
            this.BtnMus = new System.Windows.Forms.Button();
            this.GrpJoueur2 = new System.Windows.Forms.GroupBox();
            this.BtnChangeNom2 = new System.Windows.Forms.Button();
            this.BtnVoir2 = new System.Windows.Forms.Button();
            this.GrpJoueur4 = new System.Windows.Forms.GroupBox();
            this.BtnChangeNom4 = new System.Windows.Forms.Button();
            this.BtnVoir4 = new System.Windows.Forms.Button();
            this.GrpJoueur3 = new System.Windows.Forms.GroupBox();
            this.BtnChangeNom3 = new System.Windows.Forms.Button();
            this.BtnVoir3 = new System.Windows.Forms.Button();
            this.BtnMusInfo = new System.Windows.Forms.Button();
            this.ChkTest = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerLeNomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpJoueur1.SuspendLayout();
            this.GrpJoueur2.SuspendLayout();
            this.GrpJoueur4.SuspendLayout();
            this.GrpJoueur3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstCartes
            // 
            this.LstCartes.FormattingEnabled = true;
            this.LstCartes.ItemHeight = 16;
            this.LstCartes.Location = new System.Drawing.Point(580, 78);
            this.LstCartes.Name = "LstCartes";
            this.LstCartes.Size = new System.Drawing.Size(84, 516);
            this.LstCartes.TabIndex = 10;
            this.LstCartes.Visible = false;
            // 
            // BtnMelanger
            // 
            this.BtnMelanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMelanger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMelanger.Location = new System.Drawing.Point(580, 12);
            this.BtnMelanger.Name = "BtnMelanger";
            this.BtnMelanger.Size = new System.Drawing.Size(84, 27);
            this.BtnMelanger.TabIndex = 0;
            this.BtnMelanger.Text = "distribuer";
            this.BtnMelanger.UseVisualStyleBackColor = true;
            this.BtnMelanger.Click += new System.EventHandler(this.BtnMelanger_Click);
            // 
            // GrpJoueur1
            // 
            this.GrpJoueur1.BackColor = System.Drawing.Color.Yellow;
            this.GrpJoueur1.Controls.Add(this.BtnChangeNom1);
            this.GrpJoueur1.Controls.Add(this.BtnVoir1);
            this.GrpJoueur1.Location = new System.Drawing.Point(12, 12);
            this.GrpJoueur1.Name = "GrpJoueur1";
            this.GrpJoueur1.Size = new System.Drawing.Size(562, 230);
            this.GrpJoueur1.TabIndex = 6;
            this.GrpJoueur1.TabStop = false;
            this.GrpJoueur1.Tag = "";
            this.GrpJoueur1.Text = "Joueur 1";
            // 
            // BtnChangeNom1
            // 
            this.BtnChangeNom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChangeNom1.BackgroundImage = global::MusC.Properties.Resources.PersIcJ;
            this.BtnChangeNom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnChangeNom1.Location = new System.Drawing.Point(6, 21);
            this.BtnChangeNom1.Name = "BtnChangeNom1";
            this.BtnChangeNom1.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeNom1.TabIndex = 2;
            this.BtnChangeNom1.UseVisualStyleBackColor = true;
            this.BtnChangeNom1.Click += new System.EventHandler(this.BtnChangeNom);
            // 
            // BtnVoir1
            // 
            this.BtnVoir1.BackColor = System.Drawing.Color.White;
            this.BtnVoir1.BackgroundImage = global::MusC.Properties.Resources.oeilvide2;
            this.BtnVoir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoir1.Location = new System.Drawing.Point(7, 188);
            this.BtnVoir1.Name = "BtnVoir1";
            this.BtnVoir1.Size = new System.Drawing.Size(84, 36);
            this.BtnVoir1.TabIndex = 1;
            this.BtnVoir1.Tag = "voir";
            this.BtnVoir1.Text = "0";
            this.BtnVoir1.UseVisualStyleBackColor = false;
            this.BtnVoir1.MouseLeave += new System.EventHandler(this.BtnVoir1_MouseLeave);
            this.BtnVoir1.MouseHover += new System.EventHandler(this.BtnVoir1_MouseHover);
            // 
            // BtnMus
            // 
            this.BtnMus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMus.Location = new System.Drawing.Point(580, 45);
            this.BtnMus.Name = "BtnMus";
            this.BtnMus.Size = new System.Drawing.Size(84, 27);
            this.BtnMus.TabIndex = 5;
            this.BtnMus.Text = "mus";
            this.BtnMus.UseVisualStyleBackColor = true;
            this.BtnMus.Click += new System.EventHandler(this.BtnMus_Click);
            // 
            // GrpJoueur2
            // 
            this.GrpJoueur2.BackColor = System.Drawing.Color.White;
            this.GrpJoueur2.Controls.Add(this.BtnChangeNom2);
            this.GrpJoueur2.Controls.Add(this.BtnVoir2);
            this.GrpJoueur2.Location = new System.Drawing.Point(12, 363);
            this.GrpJoueur2.Name = "GrpJoueur2";
            this.GrpJoueur2.Size = new System.Drawing.Size(562, 230);
            this.GrpJoueur2.TabIndex = 7;
            this.GrpJoueur2.TabStop = false;
            this.GrpJoueur2.Tag = "0";
            this.GrpJoueur2.Text = "Joueur 2";
            // 
            // BtnChangeNom2
            // 
            this.BtnChangeNom2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChangeNom2.BackgroundImage = global::MusC.Properties.Resources.PersIcB;
            this.BtnChangeNom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnChangeNom2.Location = new System.Drawing.Point(7, 22);
            this.BtnChangeNom2.Name = "BtnChangeNom2";
            this.BtnChangeNom2.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeNom2.TabIndex = 3;
            this.BtnChangeNom2.UseVisualStyleBackColor = true;
            this.BtnChangeNom2.Click += new System.EventHandler(this.BtnChangeNom2_Click);
            // 
            // BtnVoir2
            // 
            this.BtnVoir2.BackColor = System.Drawing.Color.White;
            this.BtnVoir2.BackgroundImage = global::MusC.Properties.Resources.oeilvide2;
            this.BtnVoir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoir2.Location = new System.Drawing.Point(6, 188);
            this.BtnVoir2.Name = "BtnVoir2";
            this.BtnVoir2.Size = new System.Drawing.Size(84, 36);
            this.BtnVoir2.TabIndex = 2;
            this.BtnVoir2.Tag = "voir";
            this.BtnVoir2.Text = "0";
            this.BtnVoir2.UseVisualStyleBackColor = false;
            this.BtnVoir2.MouseLeave += new System.EventHandler(this.BtnVoir2_MouseLeave);
            this.BtnVoir2.MouseHover += new System.EventHandler(this.BtnVoir2_MouseHover);
            // 
            // GrpJoueur4
            // 
            this.GrpJoueur4.BackColor = System.Drawing.Color.White;
            this.GrpJoueur4.Controls.Add(this.BtnChangeNom4);
            this.GrpJoueur4.Controls.Add(this.BtnVoir4);
            this.GrpJoueur4.Location = new System.Drawing.Point(670, 12);
            this.GrpJoueur4.Name = "GrpJoueur4";
            this.GrpJoueur4.Size = new System.Drawing.Size(561, 230);
            this.GrpJoueur4.TabIndex = 9;
            this.GrpJoueur4.TabStop = false;
            this.GrpJoueur4.Tag = "0";
            this.GrpJoueur4.Text = "Joueur 4";
            // 
            // BtnChangeNom4
            // 
            this.BtnChangeNom4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChangeNom4.BackgroundImage = global::MusC.Properties.Resources.PersIcB;
            this.BtnChangeNom4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnChangeNom4.Location = new System.Drawing.Point(7, 21);
            this.BtnChangeNom4.Name = "BtnChangeNom4";
            this.BtnChangeNom4.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeNom4.TabIndex = 4;
            this.BtnChangeNom4.UseVisualStyleBackColor = true;
            this.BtnChangeNom4.Click += new System.EventHandler(this.BtnChangeNom4_Click);
            // 
            // BtnVoir4
            // 
            this.BtnVoir4.BackColor = System.Drawing.Color.White;
            this.BtnVoir4.BackgroundImage = global::MusC.Properties.Resources.oeilvide2;
            this.BtnVoir4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoir4.Location = new System.Drawing.Point(7, 188);
            this.BtnVoir4.Name = "BtnVoir4";
            this.BtnVoir4.Size = new System.Drawing.Size(84, 36);
            this.BtnVoir4.TabIndex = 4;
            this.BtnVoir4.Tag = "voir";
            this.BtnVoir4.Text = "0";
            this.BtnVoir4.UseVisualStyleBackColor = false;
            this.BtnVoir4.MouseLeave += new System.EventHandler(this.BtnVoir4_MouseLeave);
            this.BtnVoir4.MouseHover += new System.EventHandler(this.BtnVoir4_MouseHover);
            // 
            // GrpJoueur3
            // 
            this.GrpJoueur3.BackColor = System.Drawing.Color.Yellow;
            this.GrpJoueur3.Controls.Add(this.BtnChangeNom3);
            this.GrpJoueur3.Controls.Add(this.BtnVoir3);
            this.GrpJoueur3.Location = new System.Drawing.Point(670, 357);
            this.GrpJoueur3.Name = "GrpJoueur3";
            this.GrpJoueur3.Size = new System.Drawing.Size(561, 230);
            this.GrpJoueur3.TabIndex = 8;
            this.GrpJoueur3.TabStop = false;
            this.GrpJoueur3.Tag = "0";
            this.GrpJoueur3.Text = "Joueur 3";
            // 
            // BtnChangeNom3
            // 
            this.BtnChangeNom3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChangeNom3.BackgroundImage = global::MusC.Properties.Resources.PersIcJ;
            this.BtnChangeNom3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnChangeNom3.Location = new System.Drawing.Point(7, 21);
            this.BtnChangeNom3.Name = "BtnChangeNom3";
            this.BtnChangeNom3.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeNom3.TabIndex = 3;
            this.BtnChangeNom3.UseVisualStyleBackColor = true;
            this.BtnChangeNom3.Click += new System.EventHandler(this.BtnChangeNom3_Click);
            // 
            // BtnVoir3
            // 
            this.BtnVoir3.BackColor = System.Drawing.Color.White;
            this.BtnVoir3.BackgroundImage = global::MusC.Properties.Resources.oeilvide2;
            this.BtnVoir3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoir3.Location = new System.Drawing.Point(8, 188);
            this.BtnVoir3.Name = "BtnVoir3";
            this.BtnVoir3.Size = new System.Drawing.Size(83, 36);
            this.BtnVoir3.TabIndex = 3;
            this.BtnVoir3.Tag = "voir";
            this.BtnVoir3.Text = "0";
            this.BtnVoir3.UseVisualStyleBackColor = false;
            this.BtnVoir3.MouseLeave += new System.EventHandler(this.BtnVoir3_MouseLeave);
            this.BtnVoir3.MouseHover += new System.EventHandler(this.BtnVoir3_MouseHover);
            // 
            // BtnMusInfo
            // 
            this.BtnMusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnMusInfo.Location = new System.Drawing.Point(580, 45);
            this.BtnMusInfo.Name = "BtnMusInfo";
            this.BtnMusInfo.Size = new System.Drawing.Size(84, 27);
            this.BtnMusInfo.TabIndex = 11;
            this.BtnMusInfo.TabStop = false;
            this.BtnMusInfo.Text = "mus";
            this.BtnMusInfo.UseVisualStyleBackColor = true;
            // 
            // ChkTest
            // 
            this.ChkTest.AutoSize = true;
            this.ChkTest.Location = new System.Drawing.Point(1172, 248);
            this.ChkTest.Name = "ChkTest";
            this.ChkTest.Size = new System.Drawing.Size(58, 21);
            this.ChkTest.TabIndex = 13;
            this.ChkTest.Text = "Test";
            this.ChkTest.UseVisualStyleBackColor = true;
            this.ChkTest.CheckedChanged += new System.EventHandler(this.ChkTest_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.effacerLeNomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // effacerLeNomToolStripMenuItem
            // 
            this.effacerLeNomToolStripMenuItem.Name = "effacerLeNomToolStripMenuItem";
            this.effacerLeNomToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.effacerLeNomToolStripMenuItem.Text = "Effacer le nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 605);
            this.Controls.Add(this.ChkTest);
            this.Controls.Add(this.BtnMusInfo);
            this.Controls.Add(this.BtnMus);
            this.Controls.Add(this.GrpJoueur3);
            this.Controls.Add(this.GrpJoueur4);
            this.Controls.Add(this.GrpJoueur2);
            this.Controls.Add(this.GrpJoueur1);
            this.Controls.Add(this.BtnMelanger);
            this.Controls.Add(this.LstCartes);
            this.Name = "Form1";
            this.Text = "Mus en C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpJoueur1.ResumeLayout(false);
            this.GrpJoueur2.ResumeLayout(false);
            this.GrpJoueur4.ResumeLayout(false);
            this.GrpJoueur3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstCartes;
        private System.Windows.Forms.Button BtnMelanger;
        private System.Windows.Forms.GroupBox GrpJoueur1;
        private System.Windows.Forms.Button BtnVoir1;
        private System.Windows.Forms.Button BtnMus;
        private System.Windows.Forms.GroupBox GrpJoueur2;
        private System.Windows.Forms.Button BtnVoir2;
        private System.Windows.Forms.GroupBox GrpJoueur4;
        private System.Windows.Forms.GroupBox GrpJoueur3;
        private System.Windows.Forms.Button BtnVoir4;
        private System.Windows.Forms.Button BtnVoir3;
        private System.Windows.Forms.Button BtnMusInfo;
        private System.Windows.Forms.CheckBox ChkTest;
        private System.Windows.Forms.Button BtnChangeNom1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem effacerLeNomToolStripMenuItem;
        private System.Windows.Forms.Button BtnChangeNom2;
        private System.Windows.Forms.Button BtnChangeNom4;
        private System.Windows.Forms.Button BtnChangeNom3;
    }
}

