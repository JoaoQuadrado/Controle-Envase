namespace ControleEnvase
{



    public partial class Frm_ControleEnvase : Form
    {
        double volumeIniciado;
        double volumeTransferido;
        double volumePurga;
        double volumeFinal;
        double volumeLeveduraReutilizada;
        double volumePerdaTotal;
        double volumePerdaT1;
        double volumePerdaT2;
        double volumeEnvasado;
        double volumeAdicional;
        double volumeTransferidoT1;
        double volumeTransferidoT2;
        double volumeFinalTQ2;
        double volumeFinalTQ3;
        double volumeantesT1;
        double volumeantesT2;
        double leveduraColetada;
        double perdaAdicional;

        public Frm_ControleEnvase()
        {
            InitializeComponent();
        }

        private void Txt_VolumeIniciado_TextChanged(object sender, EventArgs e)
        {
            volumeIniciado = Cls_Uteis.Conversor(Txt_VolumeIniciado);
            AtualizarVolumes();

        }

        private void Txt_VolumeAdicional_TextChanged(object sender, EventArgs e)
        {
            volumeAdicional = Cls_Uteis.Conversor(Txt_VolumeAdicional);
            AtualizarVolumes();
        }

        private void AtualizarVolumes()
        {
            volumeFinal = (volumeIniciado + volumeAdicional + volumeLeveduraReutilizada + leveduraColetada) - (volumeTransferido + volumePurga + volumeEnvasado + perdaAdicional);
            Lbl_VolumeFinal.Text = volumeFinal.ToString();


            volumeFinalTQ2 = (volumeTransferidoT1 + volumeantesT1) - (volumePerdaT1);
            Lbl_VolumeTanqueApos1.Text = volumeFinalTQ2.ToString();


            volumeFinalTQ3 = (volumeTransferidoT2 + volumeantesT2) - (volumePerdaT2);
            Lbl_VolumeTanqueApos2.Text = volumeFinalTQ3.ToString();



        }

        private void Txt_Lbl_VolumeLeveduraReutilizada_TextChanged_1(object sender, EventArgs e)
        {
            volumeLeveduraReutilizada = Cls_Uteis.Conversor(Txt_Lbl_VolumeLeveduraReutilizada);
            AtualizarVolumes();
        }

        private void Txt_VolumePurga_TextChanged(object sender, EventArgs e)
        {
            volumePurga = Cls_Uteis.Conversor(Txt_VolumePurga);
            AtualizarVolumes();
        }

        private void Txt_VolumeEnvasado_TextChanged(object sender, EventArgs e)
        {
            volumeEnvasado = Cls_Uteis.Conversor(Txt_VolumeEnvasado);
            Lbl_EnvaseTotal.Text = volumeEnvasado.ToString();
            AtualizarVolumes();

        }


        private void Txt_VolumePerdaT1_TextChanged(object sender, EventArgs e)
        {
            volumePerdaT1 = Cls_Uteis.Conversor(Txt_VolumePerdaT1);
            AtualizarPerdas();
        }

        private void Txt_VolumePerdaT2_TextChanged(object sender, EventArgs e)
        {
            volumePerdaT2 = Cls_Uteis.Conversor(Txt_VolumePerdaT2);
            AtualizarPerdas();
        }

        private void AtualizarPerdas()
        {
            volumePerdaTotal = volumePerdaT1 + volumePerdaT2;
            Lbl_PerdaTotal.Text = volumePerdaTotal.ToString();
            Txt_VolumePerdaT1.BackColor = Color.LightCoral;
            Txt_VolumePerdaT2.BackColor = Color.LightCoral;
            Lbl_PerdaTotal.BackColor = Color.LightCoral;
            AtualizarVolumes();

        }

        private void AtualizarTransferencias()
        {
            volumeTransferido = volumeTransferidoT1 + volumeTransferidoT2;
            Lbl_TransferenciaTotal.Text = volumeTransferido.ToString();
            AtualizarVolumes();
        }
        private void Txt_VolumeT1_TextChanged(object sender, EventArgs e)
        {
            volumeTransferidoT1 = Cls_Uteis.Conversor(Txt_VolumeT1);
            AtualizarTransferencias();

        }

        private void Txt_VolumeT2_TextChanged(object sender, EventArgs e)
        {
            volumeTransferidoT2 = Cls_Uteis.Conversor(Txt_VolumeT2);
            AtualizarTransferencias();
        }

        private void Txt_VolumeAntesTD1_TextChanged(object sender, EventArgs e)
        {
            volumeantesT1 = Cls_Uteis.Conversor(Txt_VolumeAntesTD1);
            AtualizarVolumes();
        }

        private void Txt_VolumeAntesTD2_TextChanged(object sender, EventArgs e)
        {
            volumeantesT2 = Cls_Uteis.Conversor(Txt_VolumeAntesTD2);
            AtualizarVolumes();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {

            LimparTextBoxes(this);


            Lbl_VolumeFinal.Text = "0";
            Lbl_PerdaTotal.Text = "0";
            Lbl_TransferenciaTotal.Text = "0";
            Lbl_VolumeTanqueApos1.Text = "0";
            Lbl_VolumeTanqueApos2.Text = "0";
            Lbl_EnvaseTotal.Text = "0";


            volumeIniciado = 0;
            volumeTransferido = 0;
            volumePurga = 0;
            volumeFinal = 0;
            volumeLeveduraReutilizada = 0;
            volumePerdaTotal = 0;
            volumePerdaT1 = 0;
            volumePerdaT2 = 0;
            volumeEnvasado = 0;
            volumeAdicional = 0;
            volumeTransferidoT1 = 0;
            volumeTransferidoT2 = 0;
            volumeFinalTQ2 = 0;
            volumeFinalTQ3 = 0;
            volumeantesT1 = 0;
            volumeantesT2 = 0;
        }


        private void LimparTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();

                if (ctrl.HasChildren)
                    LimparTextBoxes(ctrl);
            }
        }

        private void Txt_LeveduraColetada_TextChanged(object sender, EventArgs e)
        {
            leveduraColetada = Cls_Uteis.Conversor(Txt_LeveduraColetada);
            AtualizarVolumes();
        }

        private void Txt_PerdaAdicional_TextChanged(object sender, EventArgs e)
        {
            perdaAdicional = Cls_Uteis.Conversor(Txt_PerdaAdicional);
            AtualizarVolumes();
        }

        private void Frm_ControleEnvase_Load(object sender, EventArgs e)
        {

        }
    }
}

