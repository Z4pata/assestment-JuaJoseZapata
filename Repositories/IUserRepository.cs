using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assestment_JuaJoseZapata.DTOs.Request;
using assestment_JuaJoseZapata.Models;

namespace assestment_JuaJoseZapata.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);
        Task<User?> GetByEmail(string email);
        Task<User?> Create(RegisterRequest request);
        bool CheckPassword(string password, User user);
        string Encrypt(string password);
    }
}