using Dapper;
using agropindas.Models;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;


namespace agropindas.Repositories;
public class ProdutoRepository
{
    private readonly string _dbConnection;

    public ProdutoRepository(string connectionString)
    {
        _dbConnection = connectionString;
    }



    public IEnumerable<Produto> GetAll()
    {
        var query = @"
        SELECT 
            p.Id, p.Nome, p.Descricao, p.TemperaturaPlantio, p.DiasColheita, 
            p.UnidadeCadastro, p.TipoProduto, p.ValorProduto,
            uc.Id AS UnidadeCadastroId, uc.Nome AS UnidadeCadastroNome,
            tp.Id AS TipoProdutoId, tp.Nome AS TipoProdutoNome
        FROM Produto p
        LEFT JOIN UnidadeCadastro uc ON p.UnidadeCadastro = uc.Id
        LEFT JOIN TipoProduto tp ON p.TipoProduto = tp.Id";

        using (IDbConnection db = new SqlConnection(_dbConnection))
        {
            return db.Query<Produto>(query);
        }
    }
}
