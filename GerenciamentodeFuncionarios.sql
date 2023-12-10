Create database Gerenciamentos_Funcionarios;
use Gerenciamentos_Funcionarios;
create table departamentos(
  id_dep int auto_increment primary key,
  cargo_dep varchar(200) not null
);
create table funcionarios(
  id int auto_increment primary key,
  nome varchar (200) not null,
  dt_Nascimento date,
  cargo varchar(200) not null,
  fK_Id_Dep INT,
  salario decimal (10, 2),
  CONSTRAINT fk_dep FOREIGN KEY(fk_id_dep) REFERENCES Departamentos (id_dep)
);
INSERT INTO departamentos (cargo_dep)
VALUES ('Desenvolvedor de Software');
INSERT INTO departamentos (cargo_dep)
VALUES ('Analista de Dados');
INSERT INTO departamentos (cargo_dep)
VALUES ('Gerente de Projeto');
INSERT INTO departamentos (cargo_dep)
VALUES ('Designer Gráfico');
INSERT INTO departamentos (cargo_dep)
VALUES ('Analista de Recursos Humanos');
SELECT *
FROM departamentos;
INSERT INTO funcionarios (nome, dt_nascimento, cargo, salario)
VALUES (
    'Guilherme Santos',
    '1997-08-20',
    'Analista de Dados',
    2000.00
  );
INSERT INTO funcionarios (nome, dt_nascimento, cargo, salario)
VALUES (
    'Alexandre Gomes',
    '1991-04-08',
    'Designer Gráfico',
    1300.00
  );
INSERT INTO funcionarios (nome, dt_nascimento, cargo, salario)
VALUES (
    'Gustavo Miguel',
    '1994-01-01',
    'Gerente de Projeto',
    5000.00
  );
INSERT INTO funcionarios (nome, dt_nascimento, cargo, salario)
VALUES (
    'Benedito Souza',
    '1992-12-12',
    'Analista de Recursos Humanos',
    3000.00
  );
INSERT INTO funcionarios (nome, dt_nascimento, cargo, salario)
VALUES (
    'Lais Franco',
    '1993-12-20',
    'Desenvolvedor de Software',
    7000.00
  );
SELECT *
FROM funcionarios;
UPDATE funcionarios
SET fK_Id_Dep = 5
WHERE id = 4;
SHOW VARIABLES LIKE 'port';