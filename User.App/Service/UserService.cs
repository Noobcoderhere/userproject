using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.App.ViewModel;
using User.Data;
using User.Domain;
using User.Domain.Model;

namespace User.App.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task AddUser(TestUser user)
        {
            var response = new List<GetUserVM>();
            try
            {
                await _userRepository.AddUser(user);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                await _userRepository.DeleteUser(id);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task<GetUserVM> GetUserById(int id)
        {
            var repositoryReturn = await _userRepository.GetUserById(id);
            var response = _mapper.Map<GetUserVM>(repositoryReturn);
            return response;
        }

        public async Task<List<GetUserVM>> GetUsers()
        {
            var repositoryReturn = await _userRepository.GetUsers();
            var response = repositoryReturn.Select(x => _mapper.Map<GetUserVM>(x)).ToList();
            return response;
        }

        public async Task UpdateUser(TestUser user)
        {
            try
            {
                await _userRepository.UpdateUser(user);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }
    }
}
