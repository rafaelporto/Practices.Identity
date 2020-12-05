﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Identity.Infraestructure.Entities;

namespace Identity.Infraestructure
{
	public interface IUserService
	{
		Task<Result<ApplicationUser, IEnumerable<string>>> Register(ApplicationUser newUser, string password, string confirmedPassword);
	}
}
