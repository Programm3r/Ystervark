using Ystervark.Models.Interface;

namespace Ystervark.Manager.Base
{
    /// <summary>
    /// Active Resource Interface Declaration
    /// </summary>
    public interface IActiveResource
    {
        /// <summary>
        /// Gets or sets the active resource.
        /// </summary>
        /// <value>
        /// The active resource.
        /// </value>
        IResource ActiveResource { get; set; }
    }
}