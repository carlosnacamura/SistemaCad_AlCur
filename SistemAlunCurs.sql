-- Active: 1732980696723@@127.0.0.1@3306

-- Server=127.0.0.1;Database=SistemAlunCurs;User=root;Password=;
CREATE DATABASE IF NOT EXISTS SistemAlunCurs
    DEFAULT CHARACTER SET = 'utf8mb4';

    USE SistemAlunCurs;
    CREATE TABLE IF NOT EXISTS CURSOS(
        ID_CURSO INT PRIMARY KEY AUTO_INCREMENT,
        NOMR_CUR VARCHAR(30) NOT NULL,
        SIGLA VARCHAR(5) NOT NULL
);
    CREATE TABLE IF NOT EXISTS ALUNOS (
        ID_ALUNO INT PRIMARY KEY AUTO_INCREMENT,
        NOME VARCHAR(80) NOT NULL,
        IDADE INT(2),
        EMAIL VARCHAR(50) NOT NULL,
        ID_CURSO INT,
        FOREIGN KEY (ID_CURSO) REFERENCES CURSOS(ID_CURSO)
    );



-- Inserindo os cursos
INSERT INTO CURSOS (NOMR_CUR, SIGLA) VALUES
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

-- Inserindo os alunos
INSERT INTO ALUNOS (NOME, IDADE, EMAIL, ID_CURSO) VALUES
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


/*SELECT 
    CURSOS.NOMR_CUR AS Nome_Curso,
    ALUNOS.NOME AS Nome_Aluno,
    ALUNOS.EMAIL AS Email_Aluno
FROM 
    CURSOS
INNER JOIN 
    ALUNOS
ON 
    CURSOS.ID_CURSO = ALUNOS.ID_CURSO
ORDER BY 
    CURSOS.NOMR_CUR, ALUNOS.NOME;*/
