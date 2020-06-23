using DNOLights.API.Users;
using DNOLights.Shared;
using DNOLights.Shared.MessageQueue;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DNOLights.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<BackgroundProcessor>();
            services.AddControllers();

            var settings = new Settings();
            Configuration.GetSection("DNOLights").Bind(settings);

            services.AddSingleton(settings);
            services.AddSingleton<IMessageQueueHelperFactory, MessageQueueHelperFactory>();
            services.AddSingleton<QueueLogic>();
            services.AddSingleton<IUserQueue, UserQueue>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
