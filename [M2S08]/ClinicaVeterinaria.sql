CREATE DATABASE ClinicaVeterinaria;

USE ClinicaVeterinaria;

CREATE TABLE Cliente (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	nome VARCHAR(50) NOT NULL, 
	endereco VARCHAR(150),
	bairro VARCHAR(100),
	cep VARCHAR(20),
	cidade VARCHAR(30),
	estado CHAR(2),
	telefone VARCHAR(20) NOT NULL
);

CREATE TABLE Especie (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	descricao VARCHAR(200),
);

CREATE TABLE Animal (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	nome VARCHAR(50) NOT NULL, 
	idade INT NOT NULL, 
	sexo VARCHAR(10) NOT NULL,
	idEspecie INT NOT NULL, 
	idCliente INT NOT NULL, 
	CONSTRAINT FK_Especie_Animal FOREIGN KEY (idEspecie) REFERENCES Especie(Id),
	CONSTRAINT FK_Cliente_Animal FOREIGN KEY (idCliente) REFERENCES Cliente(Id)
);

CREATE TABLE Tratamento (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	dataInicial DATETIME,
	dataFinal DATETIME,
	idAnimal INT NOT NULL, 
	CONSTRAINT FK_Especie_Tratamento FOREIGN KEY (idAnimal) REFERENCES Animal(Id)
);

CREATE TABLE Veterinario (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	nome VARCHAR(50) NOT NULL, 
	endereco VARCHAR(150), 
	telefone VARCHAR(20) NOT NULL
);

CREATE TABLE Consulta (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	data DATETIME NOT NULL,
	historico VARCHAR(MAX),
	idTratamento INT NOT NULL, 
	idVeterinario INT NOT NULL, 
	CONSTRAINT FK_Tratamento_Consulta FOREIGN KEY (idTratamento) REFERENCES Tratamento(Id),
	CONSTRAINT FK_Veterinario_Consulta FOREIGN KEY (idVeterinario) REFERENCES Veterinario(Id)
);

CREATE TABLE Exame (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
	descricao VARCHAR(200),
	idConsulta INT NOT NULL, 
	CONSTRAINT FK_Consulta_Exame FOREIGN KEY (idConsulta) REFERENCES Consulta(Id)
);
