namespace ClubCosmopolita
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var texto = "Hecho por Cesar Torres";
            texto += Environment.NewLine;
            texto += "Materia: Programacion 1";
            texto += Environment.NewLine;
            texto += "Carrera: TSD Software";
            var titulo = "Acerca de...";
            MessageBox.Show(texto, titulo);
        }

        private void acercaDeSistemaClubSocialCosmopolitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }
    }
}