using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Data;
using assestment_JuaJoseZapata.Models;
using assestment_JuaJoseZapata.Repositories;
using Microsoft.EntityFrameworkCore;

namespace assestment_JuaJoseZapata.Service
{
    public class UserService(ApplicationDbContext context) : IUserRepository
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<User?> GetById(int id)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }
        public async Task<User?> GetByEmail(string email)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == email);

            return user;
        }

        public bool CheckPassword(string password, User user)
        {
            return BCrypt.Net.BCrypt.Verify(password, user.Password);
        }
    }
}