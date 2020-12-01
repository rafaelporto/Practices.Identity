﻿using AutoMapper;
using Identity.Api.AuthEndpoints;
using Identity.Infraestructure.Entities;

namespace Identity.Api.Mapper
{
	public class UserProfile : Profile
	{
		public UserProfile() =>
			CreateMap<RegisterUserRequest, ApplicationUser>()
			.ConstructUsing(input => 
				ApplicationUser.NewUser(input.FirstName, 
										input.LastName, 
										input.Email, 
										input.Phonenumber));
	}
}
