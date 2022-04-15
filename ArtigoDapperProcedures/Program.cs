using System.Data;
using System.Data.SqlClient;
using Dapper;

using (IDbConnection db = new SqlConnection("Server=localhost; Database=Sales; User Id=sa; Password=MyPass@word")) {
    const int id = 1;

    db.Execute("spMarcarBoletoComoPago", new { id, data_pagamento = DateTime.Now }, commandType: CommandType.StoredProcedure);
}

Console.WriteLine("Boleto marcado como pago.");