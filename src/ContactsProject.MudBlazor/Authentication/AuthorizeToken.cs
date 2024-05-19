﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsWebClientMudBlazor.Authentication
{
    public sealed class AutorizeToken
    {
        public int? Id { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? Username { get; init; }
        public string? Token { get; set; }
    }

    public sealed class AccessTokenResponse
    {
        public string Token_Type { get; } = "Bearer";

        public required string Access_Token { get; init; }

        public required long Expires_In { get; init; }

    }

}
