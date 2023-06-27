using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API;

namespace Self_help_Webstore_GraphQL_API.Self_help_Webstore_GraphQL_API.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
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
