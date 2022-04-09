USE ClinicaVeterinaria;

INSERT INTO Cliente (nome, endereco, bairro, cep, cidade, estado, telefone)
VALUES
    ('João', 'Rua Azul', 'São Luiz', '00000001', 'Florianópolis', 'SC', '00000000001'),
	('Maria', 'Rua Amarela', 'São José', '00000002', 'São José', 'SC', '00000000002'),
	('José', 'Rua Verde', 'São Francisco', '00000003', 'Palhoça', 'SC', '00000000003'),
	('Luana', 'Rua Rosa', 'São Pedro', '00000004', 'Brusque', 'SC', '00000000004'),
	('Pedro', 'Rua Roxa', 'São Sebastião', '00000005', 'Blumenau', 'SC', '00000000005');

INSERT INTO Especie (descricao)
VALUES
    ('Gato'),
	('Cachorro'),
	('Cavalo'),
	('Coelho');

INSERT INTO Animal (nome, idade, sexo, idEspecie, idCliente)
VALUES
    ('Chico', 1, 'M', 1, 1),
    ('Nina', 2, 'F', 1, 2),
    ('Luke', 3, 'M', 2, 3),
    ('Thor', 4, 'M', 3, 4),
    ('Floquinho', 5, 'M', 4, 5);

INSERT INTO Tratamento (dataInicial, dataFinal, idAnimal)
VALUES
    ('2022-01-01T00:00:00', '2022-01-15T00:00:00', 1),
	('2022-02-01T00:00:00', '2022-02-15T00:00:00', 2),
	('2022-03-01T00:00:00', '2022-03-15T00:00:00', 3),
	('2022-04-01T00:00:00', '2022-04-15T00:00:00', 4),
	('2022-05-01T00:00:00', '2022-05-15T00:00:00', 5);

INSERT INTO Veterinario (nome, endereco, telefone)
VALUES
    ('Dr. Renato', 'Rua X', '11111111111'),
	('Dr. Rodrigo', 'Rua Y', '22222222222');

INSERT INTO Consulta (data, historico, idTratamento, idVeterinario)
VALUES
	('2022-01-01T00:00:00', 'Animal com raiva', 1, 1),
	('2022-01-01T00:00:00', 'Animal com febra', 2, 2),
	('2022-01-01T00:00:00', 'Animal com dor', 3, 1),
	('2022-01-01T00:00:00', 'Animal com vômito', 4, 2),
	('2022-01-01T00:00:00', 'Animal com sonolência', 5, 1);

INSERT INTO Exame (descricao, idConsulta)
VALUES
    ('Exame 1', 1),
    ('Exame 2', 2),
    ('Exame 3', 3),
    ('Exame 4', 4),
    ('Exame 5', 5);
