using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Domain;
using User.Domain.Model;

namespace User.Data
{
    public interface IUserRepository
    {
        Task<TestUser> GetUserById(int id);
        Task <List<TestUser>> GetUsers();
        Task AddUser(TestUser user);
        Task UpdateUser(TestUser user);
        Task DeleteUser(int id);
    }
}
