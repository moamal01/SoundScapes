using Microsoft.Azure.Management.Media;
using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundScapes.Service
{
    internal class ClientClass : IAzureMediaServicesClient
    {
        public Uri BaseUri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public JsonSerializerSettings SerializationSettings => throw new NotImplementedException();

        public JsonSerializerSettings DeserializationSettings => throw new NotImplementedException();

        public ServiceClientCredentials Credentials => throw new NotImplementedException();

        public string SubscriptionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string ApiVersion => throw new NotImplementedException();

        public string AcceptLanguage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? LongRunningOperationRetryTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool? GenerateClientRequestId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IOperations Operations => throw new NotImplementedException();

        public IMediaservicesOperations Mediaservices => throw new NotImplementedException();

        public IPrivateLinkResourcesOperations PrivateLinkResources => throw new NotImplementedException();

        public IPrivateEndpointConnectionsOperations PrivateEndpointConnections => throw new NotImplementedException();

        public ILocationsOperations Locations => throw new NotImplementedException();

        public IAccountFiltersOperations AccountFilters => throw new NotImplementedException();

        public IAssetsOperations Assets => throw new NotImplementedException();

        public IAssetFiltersOperations AssetFilters => throw new NotImplementedException();

        public IContentKeyPoliciesOperations ContentKeyPolicies => throw new NotImplementedException();

        public ITransformsOperations Transforms => throw new NotImplementedException();

        public IJobsOperations Jobs => throw new NotImplementedException();

        public IStreamingPoliciesOperations StreamingPolicies => throw new NotImplementedException();

        public IStreamingLocatorsOperations StreamingLocators => throw new NotImplementedException();

        public ILiveEventsOperations LiveEvents => throw new NotImplementedException();

        public ILiveOutputsOperations LiveOutputs => throw new NotImplementedException();

        IStreamingEndpointsOperations IAzureMediaServicesClient.StreamingEndpoints => throw new NotImplementedException();

        public IStreamingEndpointsOperations StreamingEndpoints(string resourceGroup, string accountName, string locatorName)
        {
            return new StreaminEndPointOperations();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
