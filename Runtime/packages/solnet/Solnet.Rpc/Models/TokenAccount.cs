// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Solnet.Rpc.Models
{
    /// <summary>
    /// Represents a token account.
    /// </summary>
    public class TokenAccount
    {
        /// <summary>
        /// The token account info.
        /// </summary>
        public TokenAccountInfo Account { get; set; }

        /// <summary>
        /// A base-58 encoded public key representing the account's public key.
        /// </summary>
        public string pubkey { get; set; }
    }
}