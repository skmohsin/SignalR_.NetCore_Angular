//https://medium.com/@akhouri/cors-issues-and-resolutions-803e6abda52a

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using signalrsample.Hubs;

namespace signalrsample {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            services.AddSignalR ();
            services.AddCors (options => {
                options.AddPolicy ("CorsPolicy", builder => builder.WithOrigins ("http://localhost:4200")
                    .AllowCredentials ()
                    .AllowAnyMethod ()
                    .AllowAnyHeader ());
            });
            services.AddMvc ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            app.UseCors ("CorsPolicy");
            app.UseSignalR (routes => {
                routes.MapHub<MessageHub> ("/message");
            });
            
            app.UseMvc ();
        }
    }
}