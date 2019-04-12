// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="RemoveLoginViewModel.cs" company="MySqlDotnetCoreTemplate">
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
    /// Class RemoveLoginViewModel.
    /// </summary>
    public class RemoveLoginViewModel
    {
        /// <summary>
        /// Gets or sets the login provider.
        /// </summary>
        /// <value>The login provider.</value>
        public string LoginProvider { get; set; }
        /// <summary>
        /// Gets or sets the provider key.
        /// </summary>
        /// <value>The provider key.</value>
        public string ProviderKey { get; set; }
    }
}
