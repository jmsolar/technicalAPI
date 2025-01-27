﻿using Microsoft.EntityFrameworkCore;
using Support.Domain;
using Support.DTOs;
using Support.Filters;
using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Impl
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(ApplicationContext context) : base(context)
        {
            _users = context.Set<User>();
        }

        /// <summary>
        /// Search and return a user by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<ApiResponse<UserResponse>> GetUserByFilter(UserFilter filter) 
        {
            var result = new UserResponse
            {
                username = filter.username,
            };

            var response = new ApiResponse<UserResponse>() { Data = result, Success = false, Errors = new List<string>() };

            var resultQuery = await _users.FromSqlRaw<User>("GetUserByFilter {0}, {1}", filter.username, filter.password).ToListAsync();
            if (resultQuery.Any())
            {
                response.Success = true;
            }
            else {
                // Manejar errores de otra forma
                response.Errors.Add("Please, check your credenctials");
            }
            return response;
        }
    }
}
