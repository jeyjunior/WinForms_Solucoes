CREATE TABLE WFTeste (
    PK_WFTeste INT IDENTITY(1,1) PRIMARY KEY,
    Propriedade VARCHAR(100),
    Valor VARCHAR(100),
);

CREATE TABLE WFCategoria (
    PK_WFCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL
);

CREATE TABLE WFMetodoPagamento (
    PK_WFMetodoPagamento INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL
);

CREATE TABLE WFRegistroDebitos (
    PK_WFRegistroDebitos INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    DataDebito DATE NOT NULL,
    Valor DECIMAL(10, 2) NOT NULL,
    PK_WFCategoria INT,
    PK_WFMetodoPagamento INT,
    FOREIGN KEY (PK_WFCategoria) REFERENCES WFCategoria(PK_WFCategoria),
    FOREIGN KEY (PK_WFMetodoPagamento) REFERENCES WFMetodoPagamento(PK_WFMetodoPagamento)
);
