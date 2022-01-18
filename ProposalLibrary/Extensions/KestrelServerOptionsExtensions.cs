using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace ProposalLibrary.Extensions
{
    public static class KestrelServerOptionsExtensions
    {
        public static void AddLibrary(this KestrelServerOptions kestrelServerOptions)
        {
            kestrelServerOptions.ListenLocalhost(5000); // value from config
        }
    }
}
