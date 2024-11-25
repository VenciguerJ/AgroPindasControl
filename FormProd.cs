using System.Linq;
using agropindas.Repositories;
using OfficeOpenXml;
using System.IO;

namespace AgroPindasControl
{
    public partial class FormProd : Form
    {
        private readonly ProdutoRepository _produtoRepository;
        public FormProd()
        {
            string connectionString = @"Server=localhost;Database=PINDUCAS_farm;Integrated Security=True;TrustServerCertificate=True;";
            _produtoRepository = new ProdutoRepository(connectionString);
            InitializeComponent();
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            var produtos = _produtoRepository.GetAll(); // Obtenha os dados

            DridProd.DataSource = produtos.Select(p => new
            {
                p.Id,
                p.Nome,
                p.Descricao,
                p.TemperaturaPlantio,
                p.DiasColheita,
                p.ValorProduto
            }).ToList();
        }

        private void Tittle_Click(object sender, EventArgs e)
        {

        }

        private void DridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter todos os produtos
                var produtos = _produtoRepository.GetAll();

                // Caminho do arquivo Excel
                string caminhoRelatorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RelatorioProduto" + DateTime.Now.ToString().Replace("/", "").Replace(":", "") + ".xlsx");

                // Configura EPPlus para licenciamento (necessário para uso)
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Cria o arquivo Excel
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma planilha
                    var worksheet = package.Workbook.Worksheets.Add("Relatório de Produtos");

                    // Adiciona o título
                    worksheet.Cells[1, 1].Value = "Relatório de Produtos";
                    worksheet.Cells[1, 1].Style.Font.Size = 18;
                    worksheet.Cells[1, 1].Style.Font.Bold = true;

                    // Adiciona os cabeçalhos
                    worksheet.Cells[3, 1].Value = "ID";
                    worksheet.Cells[3, 2].Value = "Nome";
                    worksheet.Cells[3, 3].Value = "Descrição";
                    worksheet.Cells[3, 4].Value = "Temperatura de Plantio";
                    worksheet.Cells[3, 5].Value = "Dias para Colheita";
                    worksheet.Cells[3, 6].Value = "Unidade de Cadastro";
                    worksheet.Cells[3, 7].Value = "Tipo de Produto";
                    worksheet.Cells[3, 8].Value = "Valor";

                    // Estilo dos cabeçalhos
                    using (var range = worksheet.Cells[3, 1, 3, 8])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    // Preenche os dados
                    int row = 4; // Linha inicial para os dados
                    foreach (var produto in produtos)
                    {
                        worksheet.Cells[row, 1].Value = produto.Id;
                        worksheet.Cells[row, 2].Value = produto.Nome;
                        worksheet.Cells[row, 3].Value = produto.Descricao ?? "N/A";
                        worksheet.Cells[row, 4].Value = produto.TemperaturaPlantio;
                        worksheet.Cells[row, 5].Value = produto.DiasColheita;
                        worksheet.Cells[row, 6].Value = produto.OUnidadeCadastro?.Nome ?? "N/A";
                        worksheet.Cells[row, 7].Value = produto.OTipoProduto?.Nome ?? "N/A";
                        worksheet.Cells[row, 8].Value = produto.ValorProduto;

                        row++;
                    }

                    // Ajusta automaticamente a largura das colunas
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Salva o arquivo
                    package.SaveAs(new FileInfo(caminhoRelatorio));
                }

                // Notifica que o relatório foi gerado
                MessageBox.Show("Relatório Excel gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro
                MessageBox.Show($"Erro ao gerar o relatório Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProd_Load(object sender, EventArgs e)
        {

        }
    }
}
