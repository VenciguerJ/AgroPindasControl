using Dapper;
using agropindas.Models;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using agropindas.Repositories;
using OfficeOpenXml;
using System.IO;

namespace agropindas.Repositories;
public class ProducaoRepository
{
    private readonly string _dbConnection;

    public ProducaoRepository(string dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Producao> GetAll()
    {
        using (IDbConnection db = new SqlConnection(_dbConnection))
        {
            return db.Query<Producao>("SELECT * FROM Producao");
        }
    }
}
