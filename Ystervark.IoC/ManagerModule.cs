using Autofac;
using Ystervark.Manager.Implementation;
using Ystervark.Manager.Interface;

namespace Ystervark.IoC
{
    /// <summary>
    /// manager Autofac Module Class
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class ManagerModule : Module
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
            builder.RegisterType<ResourceManager>().As<IResourceManager>().PropertiesAutowired();
            builder.RegisterType<ClientManager>().As<IClientManager>().PropertiesAutowired();
            builder.RegisterType<RegionManager>().As<IRegionManager>().PropertiesAutowired();
        }
    }
}