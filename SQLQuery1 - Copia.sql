CREATE DATABASE bdAdocao;

CREATE TABLE usuario (
  idUsuario INT PRIMARY KEY,
  nome VARCHAR(50),
  cidade VARCHAR(50),
  estado CHAR(2),
  login VARCHAR(50),
  senha CHAR(60)
);

CREATE TABLE responsavel (
  idResponsavel INT PRIMARY KEY,
  contato CHAR(15),
  idUsuario INT,
  FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)
);

CREATE TABLE requerente (
  idRequerente INT PRIMARY KEY,
  tipoPet VARCHAR(10) CHECK (tipoPet IN ('Cão', 'Gato', 'Outro')),
  racaPet VARCHAR(50),
  idUsuario INT,
  FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)
);

CREATE TABLE pet (
  idPet INT PRIMARY KEY,
  tipo VARCHAR(20) CHECK (tipo IN ('Cão', 'Gato', 'Outro')),
  nome VARCHAR(50),
  dataNascimento DATETIME,
  raca VARCHAR(50),
  cor VARCHAR(50),
  sexo VARCHAR(20) CHECK (sexo IN ('Macho', 'Fêmea')),
  statusPet VARCHAR(20) CHECK (statusPet IN ('Disponivel', 'Adotado')),
  historico VARCHAR(255)
);

CREATE TABLE adocao (
  idAdocao INT PRIMARY KEY,
  idResponsavel INT,
  idRequerente INT,
  idPet INT,
  data DATETIME,
  adotante VARCHAR(50),
  statusPet VARCHAR(20) CHECK (statusPet IN ('Pendente', 'Aprovada', 'Recusada')),
  FOREIGN KEY (idResponsavel) REFERENCES responsavel(idResponsavel),
  FOREIGN KEY (idRequerente) REFERENCES requerente(idRequerente),
  FOREIGN KEY (idPet) REFERENCES pet(idPet)
);

