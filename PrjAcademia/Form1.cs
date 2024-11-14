namespace PrjAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadCliente obj = new FormCadCliente();
            obj.ShowDialog();
        }

        private void roletaDeExercíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtividade obj = new FormAtividade();  
            obj.ShowDialog();
        }
    }
}