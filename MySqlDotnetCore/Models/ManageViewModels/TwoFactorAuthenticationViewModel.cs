// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="TwoFactorAuthenticationViewModel.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlDotnetCore.Models.ManageViewModels
{
    /// <summary>
    /// Class TwoFactorAuthenticationViewModel.
    /// </summary>
    public class TwoFactorAuthenticationViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance has authenticator.
        /// </summary>
        /// <value><c>true</c> if this instance has authenticator; otherwise, <c>false</c>.</value>
        public bool HasAuthenticator { get; set; }

        /// <summary>
        /// Gets or sets the recovery codes left.
        /// </summary>
        /// <value>The recovery codes left.</value>
        public int RecoveryCodesLeft { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is2fa enabled].
        /// </summary>
        /// <value><c>true</c> if [is2fa enabled]; otherwise, <c>false</c>.</value>
        public bool Is2faEnabled { get; set; }
    }
}
