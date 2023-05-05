namespace Sprint_2_Falcão
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadNovo c = new Frm_CadNovo();
            c.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Editar E = new Frm_Editar();
            E.ShowDialog();
        }
    }
}