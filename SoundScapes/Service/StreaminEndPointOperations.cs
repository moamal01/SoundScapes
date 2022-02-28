using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Media;
using Microsoft.Azure.Management.Media.Models;
using Microsoft.Rest.Azure;

namespace SoundScapes.Service
{
    internal class StreaminEndPointOperations : IStreamingEndpointsOperations
    {
        public Task<AzureOperationResponse<StreamingEndpoint>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, bool? autoStart = null, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> BeginScaleWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, int? scaleUnit = null, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<StreamingEndpoint>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<StreamingEndpoint>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, bool? autoStart = null, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<StreamingEndpoint>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<IPage<StreamingEndpoint>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<IPage<StreamingEndpoint>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> ScaleWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, int? scaleUnit = null, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AzureOperationResponse<StreamingEndpoint>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingEndpointName, StreamingEndpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
