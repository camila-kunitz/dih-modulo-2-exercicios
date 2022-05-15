-- BANCO
DROP DATABASE [Bank];

CREATE DATABASE [Bank];

USE [Bank];

CREATE TABLE [Cliente] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[Sobrenome] VARCHAR(50) NOT NULL,
	[DataNascimento] DATETIME NOT NULL,
	[Ativo] BIT NOT NULL
);

CREATE TABLE [ContaCorrente] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Descricao] VARCHAR(50) NOT NULL,
	[Rendimento] DECIMAL NOT NULL,
	[Codigo] VARCHAR(50) NOT NULL,
	[Ativo] BIT NOT NULL,
	[IdCliente] INT NOT NULL,
	CONSTRAINT [FK_ContaCorrente_Cliente] FOREIGN KEY (IdCliente) REFERENCES [Cliente](Id)
);

-- LOJA
CREATE DATABASE [Loja];

USE [Loja];

CREATE TABLE [Fabricante] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[CNPJ] VARCHAR(50) NOT NULL,
	[RazaoSocial] VARCHAR(50) NOT NULL
);

CREATE TABLE [Produto] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[Descricao] VARCHAR(50) NOT NULL,
	[Preco] MONEY NOT NULL,
	[Status] VARCHAR(50) NOT NULL,
	[IdFabricante] INT UNIQUE NOT NULL,
	CONSTRAINT FK_Produto_Fabricante FOREIGN KEY (IdFabricante) REFERENCES [Fabricante](Id)
);



-- ESCOLA
DROP DATABASE [Escola];

CREATE DATABASE [Escola];

USE [Escola];

CREATE TABLE [Aluno] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[Sobrenome] VARCHAR(50) NOT NULL,
	[Ano] VARCHAR(50) NOT NULL
);

CREATE TABLE [Nota] (
	[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Descricao] VARCHAR(50) NOT NULL,
	[ValorNota] DECIMAL NOT NULL,
	[AlunoId] INT NOT NULL,
	CONSTRAINT FK_Nota_Aluno FOREIGN KEY (AlunoId) REFERENCES [Aluno](Id)
);


