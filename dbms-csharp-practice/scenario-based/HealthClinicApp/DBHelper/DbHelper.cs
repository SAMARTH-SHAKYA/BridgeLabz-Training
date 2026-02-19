using System.Data;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.DBHelper;

public static class DbHelper
{
    public static SqlParameter CreateParameter(string name, object? value)
    {
        return new SqlParameter(name, value ?? DBNull.Value);
    }

    public static SqlParameter CreateParameter(string name, SqlDbType dbType, object? value)
    {
        var parameter = new SqlParameter(name, dbType);
        parameter.Value = value ?? DBNull.Value;
        return parameter;
    }
}

