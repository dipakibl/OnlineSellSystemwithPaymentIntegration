using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.IRepository
{
  public interface ILoginRepo
    {
        Admin AdminLogin(string email, string password);
        User UserLogin(string email, string password);
        bool Register(User user);
        User GetUser();
    }
}
