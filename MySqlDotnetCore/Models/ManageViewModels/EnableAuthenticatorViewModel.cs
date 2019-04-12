// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="EnableAuthenticatorViewModel.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MySqlDotnetCore.Models.ManageViewModels
{
    /// <summary>
    /// Class EnableAuthenticatorViewModel.
    /// </summary>
    public class EnableAuthenticatorViewModel
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        [Required]
            [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Text)]
            [Display(Name = "Verification Code")]
            public string Code { get; set; }

        /// <summary>
        /// Gets or sets the shared key.
        /// </summary>
        /// <value>The shared key.</value>
        [BindNever]
            public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets the authenticator URI.
        /// </summary>
        /// <value>The authenticator URI.</value>
        [BindNever]
            public string AuthenticatorUri { get; set; }
    }
}
