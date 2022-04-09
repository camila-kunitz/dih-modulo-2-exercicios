-- Exercício 05 - Parte 01
SELECT * FROM Veterinario as V
	INNER JOIN Consulta as C ON V.id = C.idVeterinario
	INNER JOIN Exame as E ON E.idConsulta = C.id
	INNER JOIN Tratamento as T ON T.id = C.idTratamento;

-- Exercício 05 - Parte 02
SELECT * FROM Veterinario as V
	INNER JOIN Consulta as C ON V.id = C.idVeterinario
	INNER JOIN Exame as E ON E.idConsulta = C.id
	INNER JOIN Tratamento as T ON T.id = C.idTratamento
		WHERE V.nome LIKE '%a%';

-- Exercício 06 - Parte 01
SELECT * FROM Cliente as C
	INNER JOIN Animal as A ON A.idCliente = C.id
	INNER JOIN Especie as E ON E.id = A.idEspecie
	INNER JOIN Tratamento as T ON T.idAnimal = A.id;

-- Exercício 06 - Parte 02
SELECT * FROM Cliente as C
	LEFT JOIN Animal as A ON A.idCliente = C.id
	LEFT JOIN Especie as E ON E.id = A.idEspecie
	LEFT JOIN Tratamento as T ON T.idAnimal = A.id;

-- Exercício 07
SELECT COUNT(id) as 'Total de animais' FROM Animal;

-- Exercício 08
SELECT * FROM Tratamento as T
	INNER JOIN Animal as A ON A.id = T.idAnimal
		WHERE T.dataInicial = (SELECT MIN(dataInicial) FROM Tratamento);

-- Exercício 09
SELECT * FROM Cliente as C
	FULL OUTER JOIN Animal as A ON A.idCliente = C.id
	FULL OUTER JOIN Especie as E ON E.id = A.idEspecie
	FULL OUTER JOIN Tratamento as T ON T.idAnimal = A.id;

-- Exercício 10
SELECT * FROM Cliente as C
	RIGHT JOIN Animal as A ON A.idCliente = C.id
	RIGHT JOIN Especie as E ON E.id = A.idEspecie
	RIGHT JOIN Tratamento as T ON T.idAnimal = A.id;
