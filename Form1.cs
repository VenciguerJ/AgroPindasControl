using agropindas.Repositories;

namespace AgroPindasControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRelProdutos_Click(object sender, EventArgs e)
        {
            FormProd f = new FormProd();
            f.Show();
        }

        private void btnRelFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores form = new FormFornecedores();
            form.Show();
        }

        private void btnRelPedidos_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnRelProd_Click(object sender, EventArgs e)
        {
            FormProducao f = new FormProducao();
            f.Show();
        }
    }
}
