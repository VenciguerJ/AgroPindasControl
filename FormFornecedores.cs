using agropindas.Repositories;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AgroPindasControl
{
    public partial class FormFornecedores : Form
    {
        private readonly FornecedorRepository _repository;
        public FormFornecedores()
        {
            string connectionString = @"Server=localhost;Database=PINDUCAS_farm;Integrated Security=True;TrustServerCertificate=True;";
            _repository = new FornecedorRepository(connectionString);
            InitializeComponent();
            CarregarFornecedores();
        }


        private void CarregarFornecedores()
        {
            try
            {
                var fornecedores = _repository.GetAll();

                GridFornecedores.DataSource = fornecedores.Select(f => new
                {
                    f.Id,
                    f.CNPJ,
                    f.RazaoSocial,
                    f.Endereco,
                    f.Fone,
                    f.Email
                }).ToList();

                // Opcional: Ajustar a largura das colunas automaticamente
                GridFornecedores.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fornecedores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNGerarFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter todos os fornecedores
                var fornecedores = _repository.GetAll(); // Substitua pelo seu repositório de fornecedores

                // Caminho do arquivo Excel
                string caminhoRelatorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RelatorioFornecedores" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");

                // Configura EPPlus para licenciamento (necessário para uso)
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Cria o arquivo Excel
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma planilha
                    var worksheet = package.Workbook.Worksheets.Add("Relatório de Fornecedores");

                    // Adiciona o título
                    worksheet.Cells[1, 1].Value = "Relatório de Fornecedores";
                    worksheet.Cells[1, 1].Style.Font.Size = 18;
                    worksheet.Cells[1, 1].Style.Font.Bold = true;

                    // Adiciona os cabeçalhos
                    worksheet.Cells[3, 1].Value = "CNPJ";
                    worksheet.Cells[3, 2].Value = "Razão Social";
                    worksheet.Cells[3, 3].Value = "Endereço";
                    worksheet.Cells[3, 4].Value = "Telefone";
                    worksheet.Cells[3, 5].Value = "Email";

                    // Estilo dos cabeçalhos
                    using (var range = worksheet.Cells[3, 1, 3, 5])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    // Preenche os dados
                    int row = 4; // Linha inicial para os dados
                    foreach (var fornecedor in fornecedores)
                    {
                        worksheet.Cells[row, 1].Value = fornecedor.CNPJ;
                        worksheet.Cells[row, 2].Value = fornecedor.RazaoSocial;
                        worksheet.Cells[row, 3].Value = fornecedor.Endereco ?? "N/A";
                        worksheet.Cells[row, 4].Value = fornecedor.Fone ?? "N/A";
                        worksheet.Cells[row, 5].Value = fornecedor.Email ?? "N/A";

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

        private void FormFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
