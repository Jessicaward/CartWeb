using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class AccountManager : IAccountRepository
{
    private readonly string _connectionString;
    public AccountManager(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public Account GetAccountById(int id)
    {
        var sql = "select * from Account where ID = @ID;";

        using var connection = new SqlConnection(_connectionString);
        
        connection.Open();

        return connection.QueryFirstOrDefault<Account>(sql, new {id = id});
    }

    public IEnumerable<Account> GetAccountsByFamilyId(int familyId)
    {
        throw new NotImplementedException();
    }
}