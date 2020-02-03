# Proj-Asp.Net-With-Angula

ASP.NET CORE

Atalhos

ctrc + k + d -> ajusta o codigo
ctrc + r + g -> remove importações desnecessarias
ctrc + k + c -> comenta

 
CRIAR PROJETO MVC CORE 2.2 - para ferramentas de desenvolvimentos web.

Os controladores apontão para as Views atraves dos metodos, é possivel definir as rotas dos metodos com identificadores ==> [Routes("Nome da rota")]

è possivel definir parametros especificos em rotas para a proteção da rota.

_________

Criação do banco: 

Se cria um projeto do tipo biblioteca.

Se cria os objetos do modelo.

Se cria um projeto do tipo biblioteca e uma classe de conecção 

using erikCorp.ITDevelop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace erikCorp.ITDevelop.Data.ORM
{
    public class ITDevelopDataContext : DbContext
    {
        public ITDevelopDataContext(DbContextOptions<ITDevelopDataContext> options) : base(options)
        {
                
        }

        public DbSet<Mural> Mural { get; set; }
    }
}


Se deve baixar o entityFramework na versão do Framework do MVC e o projeto tambem deve esta na mesma versão, 

Apos criar as classes de modelo e a classe de conecção, se define a string de coneção no projeto mvc demtro do pacote appsetingsjson.

  "ConnectionStrings": {
    "DefaulITDevelop": "server=(localdb)\\mssqllocaldb;database=mydatabasedot"
  }

Define-se dentro do Startup do MVC que a classe de conecção deve ser utilizada e a string de conecção deve ser passada por parametro.

 public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ITDevelopDataContext>(options => 
                options.UseSqlServer( Configuration.GetConnectionString("DefaulITDevelop")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

--- apos isso deve se criar uma migration para mapear o objeto e a classe de conecção dentro do projeto de conecção, se utiliza a intergace de gerenciamento do NUGET com o comando:  PM> Add-Migration "Initial-Migration" -Context ITDevelopDataContext -v

Obtendo o sucesso deve se atualizar o banco com o comando: PM> Update-database -v



