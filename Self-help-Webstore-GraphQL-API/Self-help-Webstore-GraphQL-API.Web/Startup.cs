using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API;

namespace Self_help_Webstore_GraphQL_API.Self_help_Webstore_GraphQL_API.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
        .AddDbContext<SelhelpWebstoreDBContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")))
            .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

        }
    }
}
