using System;
using GuestBook.ServiceReference;

namespace GuestBook
{
    internal sealed class ServiceProvider
    {
        private static readonly Lazy<GuestServiceClient> ServiceClient = new Lazy<GuestServiceClient>(() => new GuestServiceClient());
      
        public static GuestServiceClient Instance
        {
            get
            {
                return ServiceClient.Value;               
            }
        }
    }
}
