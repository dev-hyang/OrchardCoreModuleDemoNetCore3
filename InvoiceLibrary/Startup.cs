using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace InvoiceLibrary
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.UseRouting();
            //applicationBuilder.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            app.UseEndpoints(endpoints => endpoints.MapGet("/invoice", async context =>
            {
                await context.Response.WriteAsync("Test Invoice");
            }));
            //return applicationBuilder;
        }
    }
}
