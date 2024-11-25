using agropindas.Models;
using agropindas.Repositories;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace AgroPindasControl
{
    public partial class FormProducao : Form
    {
        private readonly ProducaoRepository _producaoRepository;
        public FormProducao()
        {
            string connectionString = @"Server=localhost;Database=PINDUCAS_farm;Integrated Security=True;TrustServerCertificate=True;";
            _producaoRepository = new ProducaoRepository(connectionString);
            InitializeComponent();
            AtualizarDataGridProducao();
        }

        private void AtualizarDataGridProducao()
        {
            try
            {
                // Obter todas as produções
                var producoes = _producaoRepository.GetAll(); // Substitua pelo seu método de obtenção das produções

                // Limpar as linhas atuais do DataGridView
                GridProd.Rows.Clear();

                GridProd.DataSource = producoes.Select(p => new
                {
                    p.Id,
                    p.IdLoteUsado,
                    p.IdProdutoProduzido,
                    p.QuantidadeProduzido,
                    p.IdCalha,
                    p.DiaColheita, // Formata a data ou exibe "N/A" se for nulo
                    p.Finalizada
                }).ToList();
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro se ocorrer um problema ao buscar ou exibir os dados
                MessageBox.Show($"Erro ao carregar as produções: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void FormProducao_Load(object sender, EventArgs e)
        {

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter todas as produções
                var producoes = _producaoRepository.GetAll(); // Substitua pelo seu método de obtenção das produções

                // Caminho do arquivo Excel
                string caminhoRelatorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RelatorioProducao" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");

                // Configura EPPlus para licenciamento (necessário para uso)
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Cria o arquivo Excel
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma planilha
                    var worksheet = package.Workbook.Worksheets.Add("Relatório de Produções");

                    // Adiciona o título
                    worksheet.Cells[1, 1].Value = "Relatório de Produções";
                    worksheet.Cells[1, 1].Style.Font.Size = 18;
                    worksheet.Cells[1, 1].Style.Font.Bold = true;

                    // Adiciona os cabeçalhos
                    worksheet.Cells[3, 1].Value = "ID";
                    worksheet.Cells[3, 2].Value = "Lote Usado";
                    worksheet.Cells[3, 3].Value = "Produto Produzido";
                    worksheet.Cells[3, 4].Value = "Quantidade Produzida";
                    worksheet.Cells[3, 5].Value = "Id Calha";
                    worksheet.Cells[3, 6].Value = "Dia de Colheita";
                    worksheet.Cells[3, 7].Value = "Finalizada";

                    // Estilo dos cabeçalhos
                    using (var range = worksheet.Cells[3, 1, 3, 7])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    // Preenche os dados
                    int row = 4; // Linha inicial para os dados
                    foreach (var producao in producoes)
                    {
                        worksheet.Cells[row, 1].Value = producao.Id;
                        worksheet.Cells[row, 2].Value = producao.IdLoteUsado;
                        worksheet.Cells[row, 3].Value = producao.IdProdutoProduzido;
                        worksheet.Cells[row, 4].Value = producao.QuantidadeProduzido;
                        worksheet.Cells[row, 5].Value = producao.IdCalha;
                        worksheet.Cells[row, 6].Value = producao.DiaColheita?.ToString("dd/MM/yyyy") ?? "N/A";
                        worksheet.Cells[row, 7].Value = producao.Finalizada ? "Sim" : "Não";

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
                // Exibe a mensagem de erro se ocorrer um problema ao gerar o relatório
                MessageBox.Show($"Erro ao gerar o relatório Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
