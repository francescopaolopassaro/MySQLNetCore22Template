// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 06-13-2018
// ***********************************************************************
// <copyright file="ManageNavPages.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MySqlDotnetCore.Views.Manage
{
    /// <summary>
    /// Class ManageNavPages.
    /// </summary>
    public static class ManageNavPages
    {
        /// <summary>
        /// Gets the active page key.
        /// </summary>
        /// <value>The active page key.</value>
        public static string ActivePageKey => "ActivePage";

        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <value>The index.</value>
        public static string Index => "Index";

        /// <summary>
        /// Gets the change password.
        /// </summary>
        /// <value>The change password.</value>
        public static string ChangePassword => "ChangePassword";

        /// <summary>
        /// Gets the external logins.
        /// </summary>
        /// <value>The external logins.</value>
        public static string ExternalLogins => "ExternalLogins";

        /// <summary>
        /// Gets the two factor authentication.
        /// </summary>
        /// <value>The two factor authentication.</value>
        public static string TwoFactorAuthentication => "TwoFactorAuthentication";

        /// <summary>
        /// Indexes the nav class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <returns>System.String.</returns>
        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        /// <summary>
        /// Changes the password nav class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <returns>System.String.</returns>
        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);

        /// <summary>
        /// Externals the logins nav class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <returns>System.String.</returns>
        public static string ExternalLoginsNavClass(ViewContext viewContext) => PageNavClass(viewContext, ExternalLogins);

        /// <summary>
        /// Twoes the factor authentication nav class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <returns>System.String.</returns>
        public static string TwoFactorAuthenticationNavClass(ViewContext viewContext) => PageNavClass(viewContext, TwoFactorAuthentication);

        /// <summary>
        /// Pages the nav class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <param name="page">The page.</param>
        /// <returns>System.String.</returns>
        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        /// <summary>
        /// Adds the active page.
        /// </summary>
        /// <param name="viewData">The view data.</param>
        /// <param name="activePage">The active page.</param>
        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}
