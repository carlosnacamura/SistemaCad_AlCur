-- Server=CLAUDIA1968\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233; 
-- Server=LS02M01;Database=SistemAlunCurs;User=carkapo1;Password=112233; 
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SistemAlunCurs')
BEGIN
    CREATE DATABASE SistemAlunCurs;
END;

USE SistemAlunCurs;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CURSOS')
BEGIN
    CREATE TABLE CURSOS (
        ID_CURSO INT IDENTITY(1,1) PRIMARY KEY, 
        NOME_CUR VARCHAR(30) NOT NULL,
        SIGLA VARCHAR(5) NOT NULL
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ALUNOS')
BEGIN
    CREATE TABLE ALUNOS (
        ID_ALUNO INT IDENTITY(1,1) PRIMARY KEY, 
        NOME VARCHAR(80) NOT NULL,
        IDADE INT,
        EMAIL VARCHAR(50) NOT NULL,
        ID_CURSO INT,
        FOREIGN KEY (ID_CURSO) REFERENCES CURSOS(ID_CURSO)
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'USUARIOS')
BEGIN
    CREATE TABLE USUARIOS (
        ID_USUARIOS INT IDENTITY(1,1) PRIMARY KEY, 
        NOME VARCHAR(80) NOT NULL,
        SENHA VARCHAR(25)
    );
END;

INSERT INTO CURSOS (NOME_CUR, SIGLA) 
VALUES
    ('Engenharia de Software', 'ENG'),
    ('Medicina', 'MED'),
    ('Direito', 'DIR'),
    ('Arquitetura', 'ARQ'),
    ('Psicologia', 'PSI'),
    ('Administração', 'ADM'),
    ('Ciência da Computação', 'CC'),
    ('Biologia', 'BIO'),
    ('Matemática', 'MAT'),
    ('Física', 'FIS');

INSERT INTO ALUNOS (NOME, IDADE, EMAIL, ID_CURSO) 
VALUES
    ('Ana Silva', 21, 'ana.silva@email.com', 1),
    ('João Oliveira', 23, 'joao.oliveira@email.com', 2),
    ('Maria Santos', 22, 'maria.santos@email.com', 3),
    ('Pedro Costa', 24, 'pedro.costa@email.com', 4),
    ('Juliana Souza', 20, 'juliana.souza@email.com', 5),
    ('Carlos Mendes', 25, 'carlos.mendes@email.com', 6),
    ('Fernanda Lima', 23, 'fernanda.lima@email.com', 7),
    ('Rafael Borges', 22, 'rafael.borges@email.com', 8),
    ('Bruna Martins', 21, 'bruna.martins@email.com', 9),
    ('Lucas Ferreira', 20, 'lucas.ferreira@email.com', 10),
    ('Larissa Pereira', 22, 'larissa.pereira@email.com', 1),
    ('Mateus Barros', 24, 'mateus.barros@email.com', 2),
    ('Isabela Rocha', 23, 'isabela.rocha@email.com', 3),
    ('Gustavo Alves', 25, 'gustavo.alves@email.com', 4),
    ('Camila Teixeira', 21, 'camila.teixeira@email.com', 5),
    ('Rodrigo Ribeiro', 20, 'rodrigo.ribeiro@email.com', 6),
    ('Renata Cunha', 23, 'renata.cunha@email.com', 7),
    ('Thiago Nascimento', 22, 'thiago.nascimento@email.com', 8),
    ('Patrícia Carvalho', 24, 'patricia.carvalho@email.com', 9),
    ('Vinícius Lopes', 20, 'vinicius.lopes@email.com', 10);

    INSERT INTO USUARIOS (NOME,SENHA) VALUES
    ('Carlos','112233'),
    ('Raphael','AmanteSonic'),
    ('Wagner','Mamute');

SELECT 
    CURSOS.NOME_CUR AS Nome_Curso,
    ALUNOS.NOME AS Nome_Aluno,
    ALUNOS.EMAIL AS Email_Aluno
FROM 
    CURSOS
INNER JOIN 
    ALUNOS
ON 
    CURSOS.ID_CURSO = ALUNOS.ID_CURSO
ORDER BY 
    CURSOS.NOME_CUR, ALUNOS.NOME;
