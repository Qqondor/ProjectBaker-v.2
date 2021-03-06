﻿using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
	public interface IUserRepository
	{
		void AddUser(User user);
		Task AddUserAsync(User user);//async
		User GetUserByEmail(string email);
		Task<User> GetUserByEmailAsync(string email);//async
		User ValidateUser(User user);
		Task<User> ValidateUserAsync(User user);//async
		List<User> GetAllUsers();
		List<User> PageUsers(int skip, int take);
		void UpdateUser(User user);
		void DeleteUser(User user);

	}
}
