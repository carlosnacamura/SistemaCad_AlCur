-- Active: 1730821269104@@127.0.0.1@3306
CREATE DATABASE IF NOT EXISTS SISTEMA_ESCOLA
    DEFAULT CHARACTER SET = 'utf8mb4';

    USE SISTEMA_ESCOLA;

    CREATE TABLE IF NOT EXISTS ALUNOS(
        ID_ALUNO INT AUTO_INCREMENT PRIMARY KEY,
        NOME VARCHAR(60),
        EMAIL VARCHAR(60)
    );

    CREATE TABLE IF NOT EXISTS CURSOS(
        ID_CURSO INT AUTO_INCREMENT PRIMARY KEY,
        NOME VARCHAR(40),
        SIGLA VARCHAR(6),
        ATIVO BOOLEAN
    )