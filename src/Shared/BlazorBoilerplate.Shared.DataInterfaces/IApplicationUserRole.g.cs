//Autogenerated by BlazorBoilerplate.EntityGenerator
using BlazorBoilerplate.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IApplicationUserRole
    {
        string TenantId { get; set; }

        IApplicationUser User { get; set; }

        IApplicationRole Role { get; set; }

        Guid UserId { get; set; }

        Guid RoleId { get; set; }

    }
}
