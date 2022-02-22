﻿using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
    }
}
