using Microsoft.AspNetCore.Http;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Repository
{
    public class LoginRepo : ILoginRepo
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private readonly  SiteDbContext _context;
        public LoginRepo(SiteDbContext context, IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
            _context = context;
        }
        public Admin AdminLogin(string email, string password)
        {
            try
            {
                Admin user = _context.Admins.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        public User GetUser()
        {
            string userid = _session.GetString("UserId");
            return _context.Users.Where(a => a.Id == Convert.ToInt32(userid)).FirstOrDefault();
        }

        public bool Register(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public User UserLogin(string email, string password)
        {
            try
            {
                User user = _context.Users.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    }
}
