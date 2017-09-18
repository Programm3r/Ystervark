using System;
using System.Text;
using AutoMapper;
using Ystervark.Models.Interface;
using Ystervark.Providers.Interface;
using Ystervark.Repository.Interface;

namespace Ystervark.Manager.Base
{
    /// <summary>
    /// Base Manager Class
    /// </summary>
    /// <seealso cref="IBaseManager" />
    public abstract class BaseManager : IBaseManager
    {
        #region BaseManager - Private Fields

        /// <summary>
        /// The active resource
        /// </summary>
        private IResource _activeResource;

        #endregion

        #region Implementation of IBaseManager

        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        public IMapper Mapper { get; set; }

        /// <summary>
        /// Gets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// Gets or sets the active resource.
        /// </summary>
        /// <value>
        /// The active resource.
        /// </value>
        public IResource ActiveResource
        {
            get => this._activeResource;
            set
            {
                this._activeResource = value;
                if (this._activeResource != null)
                {
                    this.TenantId = this._activeResource.TenantId;
                }
            }
        }

        /// <summary>
        /// Gets or sets the mail provider.
        /// </summary>
        /// <value>
        /// The mail provider.
        /// </value>
        public IMailProvider MailProvider { get; set; }

        #endregion

        #region BaseManager - Protected Methods

        /// <summary>
        /// Generates the random string.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        protected string GenerateRandomString(int size)
        {
            var builder = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        #endregion

        #region IDisposable Implementation

        /// <summary>
        /// Finalizes an instance of the <see cref="BaseManager"/> class.
        /// </summary>
        ~BaseManager()
        {
            Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
                this.UnitOfWork?.Dispose();
            }

            // Free native resources
        }

        #endregion

        #region Implementation of ITenant

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>
        /// The tenant identifier.
        /// </value>
        public int TenantId { get; set; }

        #endregion
    }
}