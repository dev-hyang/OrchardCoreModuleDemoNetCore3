using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProposalLibrary
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.UseRouting();
            //applicationBuilder.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            app.UseEndpoints(endpoints => endpoints.MapGet("/proposal", async context =>
            {
                await context.Response.WriteAsync("Test Proposal");
            }));
            //return applicationBuilder;
        }
    }
}
