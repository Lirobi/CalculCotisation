namespace CalculCotisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEnfantsACharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkAnimeActivite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMembreBureau_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblResReduction_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (txtEnfantsACharge.Text != String.Empty)
            {
                double nombreEnfantsACharge = double.Parse(txtEnfantsACharge.Text);
                bool isMembreBureau = chkMembreBureau.Checked;
                bool isAnimeActivite = chkAnimeActivite.Checked;
                double reductionParticipation = 1.0;
                double prix = 0;
                double prixApresReduction;


                //montant r�duction
                if (isAnimeActivite)
                {
                    //reduction de 30%
                    reductionParticipation = 0.7;
                    lblResReduction.Text = "Vous animez une activit� : vous avez droit � 30% de r�duction"
;
                }
                else if (isMembreBureau)
                {
                    //reduction de 20%
                    reductionParticipation = 0.8;
                    lblResReduction.Text = "Vous �tes membre du bureau : vous avez droit � 20% de r�duction";
                }

                switch (nombreEnfantsACharge)
                {
                    case 1.0:
                        prix = 100;
                        break;
                    case 2.0:
                        prix = 185;
                        break;
                    case >= 3.0:
                        prix = 185 + ((nombreEnfantsACharge - 2) * 60);
                        break;
                }

                prixApresReduction = prix * reductionParticipation;

                lblResCotisationBase.Text = prix.ToString() + " �";
                lblResCotisationFinale.Text = prixApresReduction.ToString() + " �";


            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}