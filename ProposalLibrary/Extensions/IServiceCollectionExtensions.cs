using Microsoft.Extensions.DependencyInjection;

namespace ProposalLibrary.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddLibrary(this IServiceCollection services)
        {
            //services.AddMvc(); // this might be not needed
            //services.AddControllers();
            //return services;
            services
            .AddControllers()
            // Notice the assembly is the type of this class, as this
            // is the assembly the controller is in.
            // You'll have to call this for every assembly you have
            // controllers in, except for any controllers
            // you might put in your worker service project.
            .AddApplicationPart(typeof(IServiceCollectionExtensions).Assembly);

            return services;
        }
    }
}
