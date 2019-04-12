// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="ShowRecoveryCodesViewModel.cs" company="MySqlDotnetCoreTemplate">
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
    /// Class ShowRecoveryCodesViewModel.
    /// </summary>
    public class ShowRecoveryCodesViewModel
    {
        /// <summary>
        /// Gets or sets the recovery codes.
        /// </summary>
        /// <value>The recovery codes.</value>
        public string[] RecoveryCodes { get; set; }
    }
}
