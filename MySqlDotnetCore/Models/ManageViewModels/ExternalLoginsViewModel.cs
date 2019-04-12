// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="ExternalLoginsViewModel.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace MySqlDotnetCore.Models.ManageViewModels
{
    /// <summary>
    /// Class ExternalLoginsViewModel.
    /// </summary>
    public class ExternalLoginsViewModel
    {
        /// <summary>
        /// Gets or sets the current logins.
        /// </summary>
        /// <value>The current logins.</value>
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        /// <summary>
        /// Gets or sets the other logins.
        /// </summary>
        /// <value>The other logins.</value>
        public IList<AuthenticationScheme> OtherLogins { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show remove button].
        /// </summary>
        /// <value><c>true</c> if [show remove button]; otherwise, <c>false</c>.</value>
        public bool ShowRemoveButton { get; set; }

        /// <summary>
        /// Gets or sets the status message.
        /// </summary>
        /// <value>The status message.</value>
        public string StatusMessage { get; set; }
    }
}
