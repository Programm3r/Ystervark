namespace Ystervark.Repository.Interface
{
    /// <summary>
    /// Provides methods to enable transaction support.
    /// </summary>
    public interface IHasTransactions
    {
        /// <summary>
        /// Initiates a transaction scope.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Executes the transaction.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        void RollbackTransaction();
    }
}