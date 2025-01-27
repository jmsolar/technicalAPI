﻿using Support.DTOs;
using Support.Filters;
using Support.Persistence.Repositories.Interfaces;
using System.Threading.Tasks;
using TechnicalAPI.Services.Interfaces;

namespace TechnicalAPI.Services
{
    public class UserCustomServices : IUserCustomService
    {
        private IUserRepository _userRepository;

        public UserCustomServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ApiResponse<UserResponse>> GetUserByFilter(UserFilter filter) 
        {
            return await _userRepository.GetUserByFilter(filter);
        }
    }
}
