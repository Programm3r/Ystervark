﻿using Autofac;
using Ystervark.Providers.Implementation.Claims;
using Ystervark.Providers.Implementation.Mail;
using Ystervark.Providers.Interface;

namespace Ystervark.IoC
{
    /// <summary>
    /// Provider Autofac Module Class
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class ProviderModule : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MailProvider>().As<IMailProvider>().PropertiesAutowired();
            builder.RegisterType<ClaimsProvider>().As<IClaimsProvider>();
        }
    }
}