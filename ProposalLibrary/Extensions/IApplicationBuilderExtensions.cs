using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ProposalLibrary.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddLibrary(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseRouting();
            //applicationBuilder.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            applicationBuilder.UseEndpoints(endpoints => endpoints.MapGet("/proposal", async context =>
            {
                await context.Response.WriteAsync("Test Proposal");
            }));
            return applicationBuilder;
        }
    }
}
