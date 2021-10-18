using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.App.ViewModel;
using User.Domain.Model;

namespace User.App.Service
{
    public interface IUserService
    {
        Task<GetUserVM> GetUserById(int id);
        Task<List<GetUserVM>> GetUsers();
        Task AddUser(TestUser user);
        Task UpdateUser(TestUser user);
        Task DeleteUser(int id);
    }
}
