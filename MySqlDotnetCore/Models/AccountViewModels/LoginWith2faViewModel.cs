// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="LoginWith2faViewModel.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlDotnetCore.Models.AccountViewModels
{
    /// <summary>
    /// Class LoginWith2faViewModel.
    /// </summary>
    public class LoginWith2faViewModel
    {
        /// <summary>
        /// Gets or sets the two factor code.
        /// </summary>
        /// <value>The two factor code.</value>
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remember machine].
        /// </summary>
        /// <value><c>true</c> if [remember machine]; otherwise, <c>false</c>.</value>
        [Display(Name = "Remember this machine")]
        public bool RememberMachine { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remember me].
        /// </summary>
        /// <value><c>true</c> if [remember me]; otherwise, <c>false</c>.</value>
        public bool RememberMe { get; set; }
    }
}
