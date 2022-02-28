using Microsoft.Azure.Management.Media;
using Microsoft.Azure.Management.Media.Models;
using SoundScapes.Model;
using SoundScapes.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace SoundScapes.ViewModel
{
    public class MainPageViewModel
    {
        private ObservableCollection<Track> TrackList { get; set; }
        private string AccountName = "soundscapes";
        private string ResourceGroup = "soundScapes";

        public List<Microsoft.Rest.Azure.IPage<Track>> tracks = new List<Microsoft.Rest.Azure.IPage<Track>>();


        public MainPageViewModel()
        {
            // List metoden skal bruge: Operations, resourceGroup og accountName

            //ResourceGroup = "soundScapes";
            //AccountName = "bnsounds";

            //tracks = Microsoft.Azure.Management.Media.StreamingEndpointsOperationsExtensions.List(this operations, ResourceGroup, AccountName);

            TrackList = new ObservableCollection<Track>() { new Track("locator-20220122-143816"), new Track("locator-20220122-143816") };

            ClientClass client = new ClientClass();


            //Task<List<string>> Urls1 = new Task<List<string>>;
            Task<List<string>> Urls2;
            //
            //Urls1 = GetStreamingUrlsAsync(client, ResourceGroup, AccountName, TrackList[0].Locator);
            GetStreamingUrlsAsync(client, ResourceGroup, AccountName, TrackList[1].Locator);

            Console.WriteLine("------------------------------");
            //foreach (List<string> l in Urls2)
            //Console.WriteLine(Urls2);

        }

        private static async Task<IList<string>> GetStreamingUrlsAsync(IAzureMediaServicesClient client,
            string resourceGroupName,
            string accountName,
            String locatorName)
        {
            const string DefaultStreamingEndpointName = "default";

            IList<string> streamingUrls = new List<string>();

            StreamingEndpoint streamingEndpoint = await client.StreamingEndpoints.GetAsync(resourceGroupName, accountName, DefaultStreamingEndpointName);

            if (streamingEndpoint.ResourceState != StreamingEndpointResourceState.Running)
            {
                await client.StreamingEndpoints.StartAsync(resourceGroupName, accountName, DefaultStreamingEndpointName);
            }

            ListPathsResponse paths = await client.StreamingLocators.ListPathsAsync(resourceGroupName, accountName, locatorName);

            foreach (StreamingPath path in paths.StreamingPaths)
            {
                UriBuilder uriBuilder = new UriBuilder
                {
                    Scheme = "https",
                    Host = streamingEndpoint.HostName,

                    Path = path.Paths[0]
                };
                streamingUrls.Add(uriBuilder.ToString());
            }

            Console.WriteLine("-------------11-----------------");
            foreach (string url in streamingUrls)
            {
                Console.WriteLine("-------------11-----------------");
                Console.WriteLine(url);
            }

            return streamingUrls;
        }

        private class Clinet
        {
        }
    }
}
