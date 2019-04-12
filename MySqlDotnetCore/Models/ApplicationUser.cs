// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="ApplicationUser.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MySqlDotnetCore.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    /// <summary>
    /// Class ApplicationUser.
    /// Implements the <see cref="Microsoft.AspNetCore.Identity.IdentityUser" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.IdentityUser" />
    public class ApplicationUser : IdentityUser
    {
    }
}
