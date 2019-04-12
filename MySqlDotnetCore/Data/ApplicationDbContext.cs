// ***********************************************************************
// Assembly         : MySqlDotnetCore
// Author           : admin
// Created          : 06-13-2018
//
// Last Modified By : admin
// Last Modified On : 04-12-2019
// ***********************************************************************
// <copyright file="ApplicationDbContext.cs" company="MySqlDotnetCoreTemplate">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySqlDotnetCore.Models;

namespace MySqlDotnetCore.Data
{
    /// <summary>
    /// Class ApplicationDbContext.
    /// Implements the <see cref="Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext{MySqlDotnetCore.Models.ApplicationUser}" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext{MySqlDotnetCore.Models.ApplicationUser}" />
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// Class BoolToIntConverter.
        /// Implements the <see cref="Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter{System.Boolean, System.Int32}" />
        /// </summary>
        /// <seealso cref="Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter{System.Boolean, System.Int32}" />
        public class BoolToIntConverter : ValueConverter<bool, int>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="BoolToIntConverter"/> class.
            /// </summary>
            /// <param name="mappingHints">The mapping hints.</param>
            public BoolToIntConverter(ConverterMappingHints mappingHints = null)
                : base(
                      v => Convert.ToInt32(v),
                      v => Convert.ToBoolean(v),
                      mappingHints)
            {
            }

            /// <summary>
            /// Gets the default information.
            /// </summary>
            /// <value>The default information.</value>
            public static ValueConverterInfo DefaultInfo { get; }
                = new ValueConverterInfo(typeof(bool), typeof(int), i => new BoolToIntConverter(i.MappingHints));
        }
        /// <summary>
        /// Configures the schema needed for the identity framework.
        /// </summary>
        /// <param name="builder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Shorten key length for Identity
            builder.Entity<ApplicationUser>(entity => entity.Property(m => m.Id).HasMaxLength(127));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(127));
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.Property(m => m.LoginProvider).HasMaxLength(127);
                entity.Property(m => m.ProviderKey).HasMaxLength(127);
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.Property(m => m.UserId).HasMaxLength(127);
                entity.Property(m => m.RoleId).HasMaxLength(127);
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.Property(m => m.UserId).HasMaxLength(127);
                entity.Property(m => m.LoginProvider).HasMaxLength(127);
                entity.Property(m => m.Name).HasMaxLength(127);

            });
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(bool))
                    {
                        property.SetValueConverter(new BoolToIntConverter());
                    }
                }
            }
            //fix bug mysql netcore for only one field
            //builder.Entity<ApplicationUser>().Property(up => up.EmailConfirmed).HasConversion(new BoolToZeroOneConverter<Int16>());
        }
    }
}
