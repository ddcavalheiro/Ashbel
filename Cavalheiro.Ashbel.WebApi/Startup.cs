﻿using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Swagger;

using Cavalheiro.Ashbel.Persistance.Repository;
using Microsoft.EntityFrameworkCore;
using Cavalheiro.Ashbel.Persistance;
using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Application.Application;
using Cavalheiro.Ashbel.Model;

namespace Cavalheiro.Ashbel.WebApi
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
            services.AddDbContext<AshbelDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Ashbel"));
            });

            services
                .AddTransient<IAlunoApp<AlunoModel>, AlunoApp>()
                .AddTransient<IAulaApp<AulaModel>, AulaApp>()
                .AddTransient<ICargoApp<CargoModel>, CargoApp>()
                .AddTransient<ICargoGrupoTrabalhoApp<CargoGrupoTrabalhoModel>, CargoGrupoTrabalhoApp>()
                .AddTransient<IGrupoTrabalhoApp<GrupoTrabalhoModel>, GrupoTrabalhoApp>()
                .AddTransient<IPessoaApp<PessoaModel>, PessoaApp>()
                .AddTransient<IPessoaGrupoTrabalhoApp<PessoaGrupoTrabalhoModel>, PessoaGrupoTrabalhoApp>()
                .AddTransient<IRegistroPresencaApp<RegistroPresencaModel>, RegistroPresencaApp>()
                .AddTransient<IStatusPessoaApp<StatusPessoaModel>, StatusPessoaApp>()
                .AddTransient<ITipoGrupoTrabalhoApp<TipoGrupoTrabalhoModel>, TipoGrupoTrabalhoApp>()
                .AddTransient<ITurmaApp<TurmaModel>, TurmaApp>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Ashbel Church Software",
                    Description = "A Simple Presbiterian Church Management Software",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Denis Douglas Cavalheiro",
                        Email = "denisddc@gmail.com",
                        Url = "https://denisdouglascavalheiro.dev/ashbel"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://denisdouglascavalheiro.dev/ashbel/license"
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
