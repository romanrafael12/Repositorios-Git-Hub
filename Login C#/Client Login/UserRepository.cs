using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace Client_Login
{
    class UserRepository : IuserRepository
    {
        public async Task<bool> Insert (User user)
        {
           using(IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(Client_Login.Properties.Resources.InsertUser, new { username = user.email, password = user.Password });
              return result > 0;
            }
        }

        public Task<bool> Insert(UserControl user)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {
    }
}
