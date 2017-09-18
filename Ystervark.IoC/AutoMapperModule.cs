using Autofac;
using AutoMapper;
using Ystervark.Mapping;

namespace Ystervark.IoC
{
    /// <summary>
    /// Auto Mapper Module Class
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class AutoMapperModule : Module
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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ResourceProfileConfiguration());
                cfg.AddProfile(new ClientProfileConfiguration());
                cfg.AddProfile(new ResourceRoleProfileConfiguration());
                cfg.AddProfile(new RoleProfileConfiguration());
                cfg.AddProfile(new RegionProfileConfiguration());
            });
            var mapper = config.CreateMapper();
            builder.RegisterInstance(mapper);
        }
    }
}