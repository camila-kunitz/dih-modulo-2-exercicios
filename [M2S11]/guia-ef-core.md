# EF Core



## Dependências e configurações necessárias

Adicionar as dependências para trabalhar com EF Core e SQL Server:

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.4" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.4" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer.Design" Version="1.1.6" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.4">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```

```
Install-Package Microsoft.EntityFrameworkCore -Version 3.1.1
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.1
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.1
```

Configurar Conexão no `appsettings.json`

```json
  "ConnectionStrings": {
    "ServerConnection": "Server=DESKTOP-H5FNF7M\\SQLEXPRESS;Database=[NOME_DO_BANCO];Trusted_Connection=True;"
  },
```

Configurar no `Program.cs` o uso do _Contexto_:

```c#
using [PASTA].Context;
using Microsoft.EntityFrameworkCore;

builder.Services.AddDbContext<BankContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));
```



## Usando Console do Gerenciador de Pacotes no VS

### Database-First

#### Criar scaffolding de banco de dados existente

```
Scaffold-DbContext "Server=.\SQLExpress;Database=NOME_DO_BANCO;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Context -Context NOME_DO_BANCOContext
```

#### Migrations

```
Add-Migration InitialCreate

Update-Database

Remove-Migration [nome-da-migration]

Update-Database [nome-da-migration] -> reverte a migration
```



### Code-First

Criar os Models

Criar o Contexto

```c#
using Imobiliaria.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Imobiliaria.API.Context
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }

    }
}
```

Configurar a conexão com o banco no `Program.cs`

```c#
using [PASTA].Context;
using Microsoft.EntityFrameworkCore;

builder.Services.AddDbContext<BankContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));
```

Rodar no Console Gerenciador de Pacotes

```
Add-Migration Initial
Update-Database
```

 

## Usando dotnet CLI

```
dotnet add package
```



## Scaffolding de Controlador de API com Entity Framework

Necessita instalar o pacote **Microsoft.VisualStudio.Web.CodeGeneration.Design**

```xml
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.4" />
```

Sobre a pasta do projeto, clicar com o botão direito e seguir as ações:

```
Adicionar > 'Novo item com scaffold...' > API > 'Controlador de API com ações, usando o Entity Framework'
```

