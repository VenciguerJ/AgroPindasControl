using Dapper;
using agropindas.Models;
using System.Data;
using System.Data.SqlClient;

namespace agropindas.Repositories;
public class FornecedorRepository
{
    private readonly string _dbConnection;

    public FornecedorRepository(string dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Fornecedor> GetAll()
    {
        using (IDbConnection db = new SqlConnection(_dbConnection))
        {
            return db.Query<Fornecedor>("SELECT * FROM Fornecedor");
        }
    }
}
