using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
   public interface IUserRepository
    {
      
        Task<bool> Insert(User user);
    }



    public class User
    {

        public string username { get; set; }
        public string password { get; set; }

    }
}
