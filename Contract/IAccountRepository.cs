using System.Collections.Generic;

public interface IAccountRepository
{
    Account GetAccountById(int id);
    IEnumerable<Account> GetAccountsByFamilyId(int familyId);
}