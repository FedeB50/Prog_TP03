using Microsoft.Data.SqlClient;
using Dapper;
namespace ActBD.Models;

public class DB
{
    private string conexionBD = @"Server=localhost; DataBase = Ahorcado;Integrated Security = True; TrustServerCertificate=True;";
    public List<string> traerPalabras()
    {
        List<string> palabras = new List<string>{};
        using(SqlConnection conexion = new SqlConnection(conexionBD))
        {
            string query = "SELECT palabra FROM Palabras";
            palabras = conexion.Query<string>(query).ToList();
        }
        return palabras;
    }
}