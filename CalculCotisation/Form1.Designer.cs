namespace CalculCotisation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSituationFamiliale = new GroupBox();
            txtEnfantsACharge = new TextBox();
            lblEnfantsACharge = new Label();
            grpParticipationAuxActivites = new GroupBox();
            chkAnimeActivite = new CheckBox();
            chkMembreBureau = new CheckBox();
            grpMontantCotisation = new GroupBox();
            lblResCotisationFinale = new Label();
            lblResCotisationBase = new Label();
            label5 = new Label();
            lblCotisationFinale = new Label();
            lblCotisationBase = new Label();
            lblResReduction = new Label();
            btnQuitter = new Button();
            btnCalcul = new Button();
            grpSituationFamiliale.SuspendLayout();
            grpParticipationAuxActivites.SuspendLayout();
            grpMontantCotisation.SuspendLayout();
            SuspendLayout();
            // 
            // grpSituationFamiliale
            // 
            grpSituationFamiliale.Controls.Add(txtEnfantsACharge);
            grpSituationFamiliale.Controls.Add(lblEnfantsACharge);
            grpSituationFamiliale.Location = new Point(84, 35);
            grpSituationFamiliale.Name = "grpSituationFamiliale";
            grpSituationFamiliale.Size = new Size(943, 200);
            grpSituationFamiliale.TabIndex = 0;
            grpSituationFamiliale.TabStop = false;
            grpSituationFamiliale.Text = "Situation familiale";
            // 
            // txtEnfantsACharge
            // 
            txtEnfantsACharge.Location = new Point(482, 75);
            txtEnfantsACharge.Name = "txtEnfantsACharge";
            txtEnfantsACharge.Size = new Size(200, 39);
            txtEnfantsACharge.TabIndex = 1;
            txtEnfantsACharge.KeyPress += txtEnfantsACharge_KeyPress;
            // 
            // lblEnfantsACharge
            // 
            lblEnfantsACharge.AutoSize = true;
            lblEnfantsACharge.Location = new Point(75, 75);
            lblEnfantsACharge.Name = "lblEnfantsACharge";
            lblEnfantsACharge.Size = new Size(401, 32);
            lblEnfantsACharge.TabIndex = 0;
            lblEnfantsACharge.Text = "Entrez le nombre d'enfants à charge";
            // 
            // grpParticipationAuxActivites
            // 
            grpParticipationAuxActivites.Controls.Add(chkAnimeActivite);
            grpParticipationAuxActivites.Controls.Add(chkMembreBureau);
            grpParticipationAuxActivites.Location = new Point(84, 273);
            grpParticipationAuxActivites.Name = "grpParticipationAuxActivites";
            grpParticipationAuxActivites.Size = new Size(943, 200);
            grpParticipationAuxActivites.TabIndex = 1;
            grpParticipationAuxActivites.TabStop = false;
            grpParticipationAuxActivites.Text = "Participation aux activités";
            // 
            // chkAnimeActivite
            // 
            chkAnimeActivite.AutoSize = true;
            chkAnimeActivite.Location = new Point(246, 121);
            chkAnimeActivite.Name = "chkAnimeActivite";
            chkAnimeActivite.RightToLeft = RightToLeft.Yes;
            chkAnimeActivite.Size = new Size(312, 36);
            chkAnimeActivite.TabIndex = 1;
            chkAnimeActivite.Text = "Vous animez une activité";
            chkAnimeActivite.UseVisualStyleBackColor = true;
            chkAnimeActivite.CheckedChanged += chkAnimeActivite_CheckedChanged;
            // 
            // chkMembreBureau
            // 
            chkMembreBureau.AutoSize = true;
            chkMembreBureau.Location = new Point(196, 65);
            chkMembreBureau.Name = "chkMembreBureau";
            chkMembreBureau.RightToLeft = RightToLeft.Yes;
            chkMembreBureau.Size = new Size(362, 36);
            chkMembreBureau.TabIndex = 0;
            chkMembreBureau.Text = "Vous êtes membre du bureau";
            chkMembreBureau.UseVisualStyleBackColor = true;
            chkMembreBureau.CheckedChanged += chkMembreBureau_CheckedChanged;
            // 
            // grpMontantCotisation
            // 
            grpMontantCotisation.Controls.Add(lblResCotisationFinale);
            grpMontantCotisation.Controls.Add(lblResCotisationBase);
            grpMontantCotisation.Controls.Add(label5);
            grpMontantCotisation.Controls.Add(lblCotisationFinale);
            grpMontantCotisation.Controls.Add(lblCotisationBase);
            grpMontantCotisation.Controls.Add(lblResReduction);
            grpMontantCotisation.Location = new Point(84, 565);
            grpMontantCotisation.Name = "grpMontantCotisation";
            grpMontantCotisation.Size = new Size(802, 352);
            grpMontantCotisation.TabIndex = 2;
            grpMontantCotisation.TabStop = false;
            grpMontantCotisation.Text = "Montant de la cotisation";
            // 
            // lblResCotisationFinale
            // 
            lblResCotisationFinale.AutoSize = true;
            lblResCotisationFinale.Location = new Point(285, 221);
            lblResCotisationFinale.Name = "lblResCotisationFinale";
            lblResCotisationFinale.Size = new Size(47, 32);
            lblResCotisationFinale.TabIndex = 5;
            lblResCotisationFinale.Text = "0 €";
            // 
            // lblResCotisationBase
            // 
            lblResCotisationBase.AutoSize = true;
            lblResCotisationBase.Location = new Point(285, 147);
            lblResCotisationBase.Name = "lblResCotisationBase";
            lblResCotisationBase.Size = new Size(47, 32);
            lblResCotisationBase.TabIndex = 4;
            lblResCotisationBase.Text = "0 €";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 163);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 3;
            // 
            // lblCotisationFinale
            // 
            lblCotisationFinale.AutoSize = true;
            lblCotisationFinale.Location = new Point(50, 221);
            lblCotisationFinale.Name = "lblCotisationFinale";
            lblCotisationFinale.Size = new Size(199, 32);
            lblCotisationFinale.TabIndex = 2;
            lblCotisationFinale.Text = "Cotisation finale :";
            // 
            // lblCotisationBase
            // 
            lblCotisationBase.AutoSize = true;
            lblCotisationBase.Location = new Point(50, 147);
            lblCotisationBase.Name = "lblCotisationBase";
            lblCotisationBase.Size = new Size(223, 32);
            lblCotisationBase.TabIndex = 1;
            lblCotisationBase.Text = "Cotisation de base :";
            // 
            // lblResReduction
            // 
            lblResReduction.AutoSize = true;
            lblResReduction.Location = new Point(50, 72);
            lblResReduction.Name = "lblResReduction";
            lblResReduction.Size = new Size(410, 32);
            lblResReduction.TabIndex = 0;
            lblResReduction.Text = "Vous n'avez droit a aucune réduction";
            lblResReduction.Click += lblResReduction_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(892, 811);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(219, 46);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnCalcul
            // 
            btnCalcul.Location = new Point(892, 728);
            btnCalcul.Name = "btnCalcul";
            btnCalcul.Size = new Size(219, 46);
            btnCalcul.TabIndex = 4;
            btnCalcul.Text = "Lancer le calcul";
            btnCalcul.UseVisualStyleBackColor = true;
            btnCalcul.Click += btnCalcul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 992);
            Controls.Add(btnCalcul);
            Controls.Add(btnQuitter);
            Controls.Add(grpParticipationAuxActivites);
            Controls.Add(grpMontantCotisation);
            Controls.Add(grpSituationFamiliale);
            Name = "Form1";
            Text = "Form1";
            grpSituationFamiliale.ResumeLayout(false);
            grpSituationFamiliale.PerformLayout();
            grpParticipationAuxActivites.ResumeLayout(false);
            grpParticipationAuxActivites.PerformLayout();
            grpMontantCotisation.ResumeLayout(false);
            grpMontantCotisation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSituationFamiliale;
        private TextBox txtEnfantsACharge;
        private Label lblEnfantsACharge;
        private GroupBox grpParticipationAuxActivites;
        private CheckBox chkAnimeActivite;
        private CheckBox chkMembreBureau;
        private GroupBox grpMontantCotisation;
        private Label lblResCotisationFinale;
        private Label lblResCotisationBase;
        private Label label5;
        private Label lblCotisationFinale;
        private Label lblCotisationBase;
        private Label lblResReduction;
        private Button btnQuitter;
        private Button btnCalcul;
    }
}