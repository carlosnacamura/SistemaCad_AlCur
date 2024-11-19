# SistemaCad_AlCur
Prova do professor Fernando


# Descrição
Cadastro do aluno
Cadastro de Curso onde cada curso tem um lista de alunos matriculados
Login para Cadastrar

# Design
https://youtu.be/a9nF4Uppwfc?feature=shared

https://youtu.be/Y4WV1tQBW5I?feature=shared

# Planejamento do design
https://www.canva.com/design/DAGWYFrWbM0/6Ab8Dw1tBsizdvBw4tmDMQ/edit?utm_content=DAGWYFrWbM0&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton

# SQL Server
```
sql
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_ALUNCURS')
BEGIN
    CREATE DATABASE BD_ALUNCURS;
END;
GO

USE BD_ALUNCURS;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CURSOS')
BEGIN
    CREATE TABLE CURSOS (
        ID_CURSO INT PRIMARY KEY IDENTITY(1,1),
        NOME_CUR NVARCHAR(50),
        SIGLA NVARCHAR(5)
    );
END;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ALUNOS')
BEGIN
    CREATE TABLE ALUNOS (
        ID_ALUNO INT PRIMARY KEY IDENTITY(1,1),
        NOME NVARCHAR(80),
        DATA_NASC DATE,
        EMAIL NVARCHAR(50),
        ID_CURSO INT,
        FOREIGN KEY (ID_CURSO) REFERENCES CURSOS(ID_CURSO)
    );
END;
GO
INSERT INTO CURSOS (NOME_CUR, SIGLA)
VALUES
('Português', 'POR'),
('Matemática', 'MAT'),
('Ciências', 'CIE'),
('História', 'HIS'),
('Geografia', 'GEO'),
('Inglês', 'ING'),
('Educação Física', 'EDF'),
('Física', 'FIS'),
('Química', 'QUI'),
('Biologia', 'BIO'),
('Laboratório de Processos Criativos', 'LPC'),
('Banco de Dados', 'BD'),
('Programação Web Site', 'PW'),
('Programação Mobile', 'PAM'),
('Estudos Avançados de Matemática', 'EAMT'),
('Estudos Avançados de Ciências', 'EACT'),
('Desenvolvimento de Sistemas','DS');
GO
INSERT INTO ALUNOS (NOME, DATA_NASC, EMAIL, ID_CURSO)
VALUES
('Ana Clara Santos', '2002-05-15', 'ana.clara@gmail.com', 1),
('João Pedro Oliveira', '2000-09-20', 'joao.oliveira@hotmail.com', 1),
('Maria Fernanda Costa', '1998-12-10', 'maria.fernanda@yahoo.com', 1),
('Gabriel Souza Lima', '2001-03-25', 'gabriel.lima@outlook.com', 2),
('Carolina Dias Mendes', '1999-07-30', 'carolina.mendes@gmail.com', 2),
('Lucas Henrique Rocha', '2003-01-12', 'lucas.rocha@gmail.com', 2),
('Beatriz Martins Silva', '2001-11-05', 'beatriz.silva@gmail.com', 3),
('Rafael Almeida Nogueira', '1997-04-18', 'rafael.nogueira@yahoo.com', 3),
('Larissa Moura Gonçalves', '1996-08-22', 'larissa.goncalves@hotmail.com', 3),
('Vinícius Barbosa Pereira', '2000-10-10', 'vinicius.pereira@outlook.com', 4),
('Mariana Teixeira Lopes', '2002-08-01', 'mariana.teixeira@gmail.com', 4),
('André Silva Ramos', '2003-02-19', 'andre.ramos@hotmail.com', 4),
('Julia Araujo Dias', '2001-06-15', 'julia.dias@gmail.com', 5),
('Fernando Almeida Costa', '1999-11-25', 'fernando.costa@yahoo.com', 5),
('Priscila Nunes Souza', '2002-03-12', 'priscila.souza@gmail.com', 5),
('Ricardo Lima Santos', '2000-01-20', 'ricardo.santos@gmail.com', 6),
('Tatiana Rocha Mendes', '1998-07-15', 'tatiana.mendes@gmail.com', 6),
('Eduardo Henrique Torres', '1997-09-30', 'eduardo.torres@yahoo.com', 6),
('Renata Alves Barros', '2001-12-22', 'renata.barros@gmail.com', 7),
('Marcelo Nogueira Campos', '1996-05-10', 'marcelo.campos@gmail.com', 7),
('Luana Ribeiro Silva', '2003-08-30', 'luana.silva@gmail.com', 7),
('Thiago Oliveira Martins', '2000-04-17', 'thiago.martins@gmail.com', 8),
('Sofia Cardoso Pinto', '2002-01-09', 'sofia.pinto@hotmail.com', 8),
('Felipe Moura Andrade', '1999-10-05', 'felipe.andrade@yahoo.com', 8),
('Daniela Correia Souza', '1998-02-13', 'daniela.souza@gmail.com', 9),
('Rodrigo Santos Lopes', '2003-06-21', 'rodrigo.lopes@gmail.com', 9),
('Camila Duarte Reis', '1997-12-04', 'camila.reis@yahoo.com', 9),
('Bruno Costa Almeida', '2001-03-16', 'bruno.almeida@gmail.com', 10),
('Isabela Mendes Rocha', '2000-09-11', 'isabela.rocha@gmail.com', 10),
('Paulo Henrique Teixeira', '1996-07-24', 'paulo.teixeira@gmail.com', 10);
GO
```
