﻿//Autogenerated from ResourceDtoCustomUserClaims.tt
using System.Collections.Generic;

namespace BlazorBoilerplate.Shared.Dto.Admin
{
    public partial class IdentityResourceDto
    {
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<string> CustomUserClaims { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CustomUserClaimsText
        {
            get => JoinLines(CustomUserClaims);
            set => CustomUserClaims = SplitLines(value);
        }
    }
}
