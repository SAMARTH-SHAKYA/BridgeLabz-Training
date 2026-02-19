using System.Data;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.DBHelper;

public class TransactionHelper
{
    public static void ExecuteInTransaction(IDbConnection connection, Action<IDbTransaction> action)
    {
        if (connection.State != ConnectionState.Open)
            connection.Open();

        using var transaction = connection.BeginTransaction();
        try
        {
            action(transaction);
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}

