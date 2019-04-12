// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="EmailSenderExtensions.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using MySqlDotnetCore.Services;

namespace MySqlDotnetCore.Services
{
    /// <summary>
    /// Class EmailSenderExtensions.
    /// </summary>
    public static class EmailSenderExtensions
    {
        /// <summary>
        /// Sends the email confirmation asynchronous.
        /// </summary>
        /// <param name="emailSender">The email sender.</param>
        /// <param name="email">The email.</param>
        /// <param name="link">The link.</param>
        /// <returns>Task.</returns>
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
