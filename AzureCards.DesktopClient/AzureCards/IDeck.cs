// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AzureCards.DesktopClient.Models;
using Microsoft.Rest;

namespace AzureCards.DesktopClient
{
    public partial interface IDeck
    {
        /// <param name='deckId'>
        /// Required.
        /// </param>
        /// <param name='cardCount'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<DealResponseMessage>> DealWithOperationResponseAsync(string deckId, int cardCount, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> NewWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='deckId'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<bool>> ShuffleWithOperationResponseAsync(string deckId, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
