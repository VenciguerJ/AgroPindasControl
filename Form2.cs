using agropindas.Models;
using agropindas.Repositories;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AgroPindasControl
{
    public partial class Form2 : Form
    {
        private readonly PedidoRepository _pedido;
        public Form2()
        {
            string connectionString = @"Server=localhost;Database=PINDUCAS_farm;Integrated Security=True;TrustServerCertificate=True;";
            _pedido = new PedidoRepository(connectionString);
            InitializeComponent();
            AtualizarDataGridPedidos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarDataGridPedidos()
        {
            try
            {
                // Obter todos os pedidos
                var pedidos = _pedido.GetAll(); // Substitua pelo seu método de obtenção dos pedidos

                // Limpar as linhas atuais do DataGridView
                GridPedidos.DataSource = pedidos.Select(p => new
                {
                    p.Id,
                    p.CPF,
                    p.Produtos,
                    p.DataPedido
                }).ToList();
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro se ocorrer um problema ao buscar ou exibir os dados
                MessageBox.Show($"Erro ao carregar os pedidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarRelatorioPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter todos os pedidos
                var pedidos = _pedido.GetAll(); // Substitua pelo seu repositório de pedidos

                // Caminho do arquivo Excel
                string caminhoRelatorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RelatorioPedidos" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");

                // Configura o licenciamento do EPPlus
                // Para uso não comercial, defina LicenseContext para NonCommercial
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  // Para fins não comerciais

                // Cria o arquivo Excel
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma planilha
                    var worksheet = package.Workbook.Worksheets.Add("Relatório de Pedidos");

                    // Adiciona o título
                    worksheet.Cells[1, 1].Value = "Relatório de Pedidos";
                    worksheet.Cells[1, 1].Style.Font.Size = 18;
                    worksheet.Cells[1, 1].Style.Font.Bold = true;

                    // Adiciona os cabeçalhos
                    worksheet.Cells[3, 1].Value = "ID";
                    worksheet.Cells[3, 2].Value = "CPF";
                    worksheet.Cells[3, 3].Value = "Produtos";
                    worksheet.Cells[3, 4].Value = "Data do Pedido";

                    // Estilo dos cabeçalhos
                    using (var range = worksheet.Cells[3, 1, 3, 4])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    // Preenche os dados
                    int row = 4; // Linha inicial para os dados
                    foreach (var pedido in pedidos)
                    {
                        worksheet.Cells[row, 1].Value = pedido.Id;
                        worksheet.Cells[row, 2].Value = pedido.CPF;
                        worksheet.Cells[row, 3].Value = pedido.Produtos ?? "N/A";
                        worksheet.Cells[row, 4].Value = pedido.DataPedido.ToString("dd/MM/yyyy");

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
    }
}
