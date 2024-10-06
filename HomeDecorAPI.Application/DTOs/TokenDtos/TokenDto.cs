﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.TokenDtos
{
    public class TokenDto {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public TokenDto()
        {
            
        }
        public TokenDto(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    };
}
