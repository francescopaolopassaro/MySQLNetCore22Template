// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="UrlHelperExtensions.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlDotnetCore.Controllers;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class UrlHelperExtensions.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Emails the confirmation link.
        /// </summary>
        /// <param name="urlHelper">The URL helper.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="code">The code.</param>
        /// <param name="scheme">The scheme.</param>
        /// <returns>System.String.</returns>
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ConfirmEmail),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        /// <summary>
        /// Resets the password callback link.
        /// </summary>
        /// <param name="urlHelper">The URL helper.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="code">The code.</param>
        /// <param name="scheme">The scheme.</param>
        /// <returns>System.String.</returns>
        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ResetPassword),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
