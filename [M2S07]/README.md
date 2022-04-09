### [M2S07] Ex 1 - Criação de banco de dados

Crie um Banco de Dados com nome Clinica

OBS.: A entrega esse exercício será um print de tela da Instância e do Banco de Dados Clínica.

### [M2S07] Ex 2 - Criação da tabela Sala

No banco de dados Clinica, criar a tabela Sala, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  Numero_Sala: inteiro, único e não nulo.
3.  Andar: inteiro e não nulo.

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql) - veja o exemplo anexo.

### [M2S07] Ex 3 - Criação da tabela Medico

No banco de dados Clinica, criar a tabela Medico, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  CRM: varchar (15), único e não nulo
3.  Nome: varchar (200) e não nulo
4.  DataNascimento: Datetime
5.  Especialidade: varchar (100), não nulo
6.  CPF: varchar (15), único e não nulo
7.  Data de admissão: datetime, não nulo

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 4 - Criação da tabela PlanoSaude

No banco de dados Clinica, criar a tabela PlanoSaude, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  Nome: varchar (200), não nulo
3.  DataAtivo: Datetime, não nulo
4.  DataInativacao: Datetime, nulo
5.  Ativo: bit, não nulo

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 5 - Criação da tabela Paciente

No banco de dados Clinica, criar a tabela Paciente, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  RG: varchar (15), não nulo
3.  Nome: varchar (200), não nulo
4.  Data_Nascimento: Datetime, não nulo
5.  Endereco: varchar (300)
6.  IdPlanoSaude: inteiro, chave estrangeira, nulo

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 6 - Criação da tabela Cargo

No banco de dados Clinica, criar a tabela Cargo, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  Nome: varchar (200), não nulo

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 7 - Criaçaõ da tabela Funcionario

No banco de dados Clinica, criar a tabela Funcionario, com as seguintes colunas:

1.  Id: campo inteiro , chave primária;
2.  Matricula: varchar (15), único, não nulo
3.  Nome: varchar (200), não nulo
4.  DataNascimento: Datetime, não nula
5.  DataAdmissao: Datetime, não nulo
6.  IdCargo: inteiro e chave estrangeira
7.  Salario: money, não nulo

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 8 - Criação da tabela Consulta

No banco de dados Clinica, criar a tabela Consulta, com as seguintes colunas:

1. Id: campo inteiro , chave primária;
2. DataConsulta: Datetime
3. IdPaciente: inteiro e chave estrangeira
4. IdFuncionario: inteiro e chave estrangeira
5. Relatorio: varchar(MAX)
6. PrescricaoRemedio: varchar(500)
7. Observacao: varchar(300)

OBS.: A entrega esse exercício será anexar o script de criação da tabela (arquivo extensão .sql).

### [M2S07] Ex 9 - Criação do Diagrama do banco de dados Clinica

Agora que você já criou todas as tabelas do banco de dados Clinica, vamos criar o diagrama de dados e visualizar todas os relacionamentos entre as tabelas.

1. Clique no banco de dados Clinica para expandir todas as pastas e clique com o botão direito na pasta DATABASE DIAGRAMS;
2. Escolha a opção NEW DATABASE DIAGRAM;
3. Selecione todas as tabelas criadas;
4. Gerar o diagrama.

OBS.: Salve o arquivo gerado e anexar nesse exercício.
