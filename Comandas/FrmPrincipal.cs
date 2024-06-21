using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        // método (visibilidade=private, retorno =

        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo AppDbContext
            // usar a variavel e acessar o contexto
            // executar a migração == F5
            using (var banco = new AppDbContext())
            {
                banco.Database.Migrate();
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dungeonButtonRight1_Click(object sender, EventArgs e)
        {

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {

        }

        private void cyberGroupBox1_Load(object sender, EventArgs e)
        {

        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {

        }

        private void cyberGroupBox2_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // encerra o aplicativo
            Application.Exit();
        }
    }
}
