using Dapper;
using agropindas.Models;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;


namespace agropindas.Repositories;
public class PedidoRepository
{
    private readonly string _dbConnection;

    public PedidoRepository(string dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<PedidoDto> GetAll()
    {
        using (IDbConnection db = new SqlConnection(_dbConnection))
        {
            return  db.Query<PedidoDto>("SELECT * FROM Pedidos");
        }
    }
}
