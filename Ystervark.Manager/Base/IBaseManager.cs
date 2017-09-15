using System;
using AutoMapper;
using Ystervark.Models.Interface;
using Ystervark.Providers.Mail;
using Ystervark.Repository.Interface;

namespace Ystervark.Manager.Base
{
    /// <summary>
    /// Base Manager Interface Declaration
    /// </summary>
    /// <seealso cref="Ystervark.Manager.Base.IActiveResource" />
    /// <seealso cref="Ystervark.Models.Interface.ITenant" />
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="IActiveResource" />
    /// <seealso cref="IDisposable" />
    public interface IBaseManager : IActiveResource, ITenant, IDisposable
    {
        /// <summary>
        /// Gets or sets the mail provider.
        /// </summary>
        /// <value>
        /// The mail provider.
        /// </value>
        IMailProvider MailProvider { get; }

        /// <summary>
        /// Gets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        IMapper Mapper { get; }

        /// <summary>
        /// Gets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        IUnitOfWork UnitOfWork { get; }
    }
}