using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Model;
using User1.Data;
using User1.Data.Context;

namespace User.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public async Task AddUser(TestUser user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task<TestUser> GetUserById(int id)
        {
            var response = new TestUser();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            response = user;
            return response;
        }

        public async Task<List<TestUser>> GetUsers()
        {
            var response = new List<TestUser>();
            var users = await _context.Users.ToListAsync();
            response = users;
            return response;
        }

        public async Task UpdateUser(TestUser user)
        {
            try
            {
                //var userForUpdate = await _context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
                //userForUpdate.Name = user.Name;
                //userForUpdate.Age = user.Age;
                //await _context.SaveChangesAsync();
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException();
            }
            
        }
    }
}
