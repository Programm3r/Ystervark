using Autofac;
using Ystervark.Database.Models;
using Ystervark.Repository.Implementation;
using Ystervark.Repository.Interface;

namespace Ystervark.IoC
{
    /// <summary>
    /// Db Context tModule Class
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class DbContextModule : Module
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
            builder.RegisterType<Briteplan>();
            builder.RegisterType<UnitOfWork<Briteplan>>().As<IRepositoryFactory>();
            builder.RegisterType<UnitOfWork<Briteplan>>().As<IUnitOfWork>();
            builder.RegisterType<UnitOfWork<Briteplan>>().As<IUnitOfWork<Briteplan>>();
        }
    }
}