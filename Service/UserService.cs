using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.Data;
using assestment_JuaJoseZapata.DTOs.Request;
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

        public async Task<User?> Create(RegisterRequest request)
        {
            var newUser = new User
            {
                Name = request.Name.ToLower(),
                Email = request.Email.ToLower(),
                Password = Encrypt(request.Password),
                CreationDate = DateTime.Now,
                RoleId = 2,
            };

            try
            {
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return newUser;
        }

        public bool CheckPassword(string password, User user)
        {
            return BCrypt.Net.BCrypt.Verify(password, user.Password);
        }

        public string Encrypt(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}