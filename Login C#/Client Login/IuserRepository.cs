﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
   public interface IuserRepository
    {
        Task<bool> Insert(UserControl User);
        Task<bool> Insert(User user);
    }
}
