// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="LoginWithRecoveryCodeViewModel.cs" company="MySqlDotnetCoreTemplate">
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
    /// Class LoginWithRecoveryCodeViewModel.
    /// </summary>
    public class LoginWithRecoveryCodeViewModel
    {
        /// <summary>
        /// Gets or sets the recovery code.
        /// </summary>
        /// <value>The recovery code.</value>
        [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Recovery Code")]
            public string RecoveryCode { get; set; }
    }
}
