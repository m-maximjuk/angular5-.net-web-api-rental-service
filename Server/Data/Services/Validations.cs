using Library.Entities;
using Library.Enums;
using Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class Validations
    {
        public Validations()
        {

        }

        public async Task<KeyValuePair<DataResult, Account>> AccountCheck(Account account)
        {
            if ((await UsernameCheck(account)).Key == DataResult.UsernameExists)
            {
                if ((await PasswordCheck(account)).Key == DataResult.ValidPassword)
                {
                    return new KeyValuePair<DataResult, Account>(DataResult.Success, (await PasswordCheck(account)).Value);
                }
                return new KeyValuePair<DataResult, Account>(DataResult.InvalidPassword, null);
            }
            return new KeyValuePair<DataResult, Account>(DataResult.InvalidUsername, null);
        }
        public async Task<KeyValuePair<DataResult, Account>> UsernameCheck(Account account)
        {
            using (DataManager<Account> DataManager = new DataManager<Account>())
            {
                var result = await DataManager.CheckModel(account, x => x.Username == account.Username);
                if (result.Key == DataResult.Success) { return new KeyValuePair<DataResult, Account>(DataResult.UsernameExists, result.Value); }
                else { return new KeyValuePair<DataResult, Account>(DataResult.InvalidUsername, null); }
            }
        }
        public async Task<KeyValuePair<DataResult, Account>> PasswordCheck(Account account)
        {
            using (DataManager<Account> Manager = new DataManager<Account>())
            {
                var result = await Manager.CheckModel(account, x => x.Password == account.Password);
                if (result.Key == DataResult.Success) { return new KeyValuePair<DataResult, Account>(DataResult.ValidPassword, result.Value); }
                else { return new KeyValuePair<DataResult, Account>(DataResult.InvalidPassword, null); }
            }
        }
    }
}
