--03:

--Tem que dropar primeiro a tabela dívidas visto que ela depende de clientes
DROP TABLE IF EXISTS dividas;

DROP TABLE IF EXISTS clientes;

--cliente pode ter de 0 à N dívidas
--dívida tem somente 1 e apenas 1 cliente
--portanto 1 --> N

CREATE TABLE clientes(
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(11) NOT NULL UNIQUE, --CHAR no postgree vai completar os números que faltarem com espaço, já oi varchar NÂO
	"dataNascimento" DATE NOT NULL,-- precisa das aspas duplas se não o postgre vai deixar tudo em minuscúlas
	--idade			--NÃO CRIAR AQUI USAR A dataNascimento para calculcar no progama
	email VARCHAR(100) --APENAS VALIDAR SE INFORMADO
);

CREATE TABLE dividas(
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	valor NUMERIC(10, 2) NOT NULL,
	paga BOOL NOT NULL DEFAULT FALSE,
	"dataCriacao" DATE NOT NULL,
	"dataPagamento" DATE DEFAULT NULL,
	"clienteId" INT NOT NULL,

	FOREIGN KEY ("clienteId")
	REFERENCES clientes(id)
);


-- Os Inserts abaixo podem ou não serem executados para preencher o banco previamente

INSERT INTO clientes
    (nome, cpf, "dataNascimento", email)
VALUES
    ('Lucas Almeida', '12345678909', '1998-03-15', 'lucas@email.com'),
    ('Mariana Oliveira', '23456789173', '1995-07-22', 'mariana@email.com'),
    ('Pedro Santos', '34567891228', '2001-11-10', 'pedro@email.com'),
    ('Ana Carolina Lima', '45678912364', '1992-05-08', 'ana@email.com'),
    ('Rafael Costa', '56789123482', '1988-09-30', 'rafael@email.com'),
    ('Juliana Ferreira', '67891234582', '2000-01-18', 'juliana@email.com'),
    ('Bruno Rodrigues', '78912345664', '1997-12-04', 'bruno@email.com'),
    ('Camila Martins', '89123456728', '1994-06-25', 'camila@email.com'),
    ('Felipe Ribeiro', '91234567873', '2002-08-12', 'felipe@email.com'),
    ('Beatriz Gomes', '13579246828', '1999-04-03', 'beatriz@email.com');

INSERT INTO dividas
    (valor, paga, "dataCriacao", "dataPagamento", "clienteId")
VALUES
    (150.00, FALSE, '2026-11-01', NULL,
        (SELECT id FROM clientes WHERE cpf = '12345678909')),

    (75.50, TRUE, '2026-09-10', '2026-09-20',
        (SELECT id FROM clientes WHERE cpf = '12345678909')),

    (320.90, FALSE, '2026-11-02', NULL,
        (SELECT id FROM clientes WHERE cpf = '23456789173')),

    (45.00, FALSE, '2026-11-03', NULL,
        (SELECT id FROM clientes WHERE cpf = '34567891228')),

    (200.00, TRUE, '2026-08-05', '2026-08-15',
        (SELECT id FROM clientes WHERE cpf = '34567891228')),

    (580.75, FALSE, '2026-11-04', NULL,
        (SELECT id FROM clientes WHERE cpf = '45678912364')),

    (99.90, FALSE, '2026-11-05', NULL,
        (SELECT id FROM clientes WHERE cpf = '56789123482')),

    (120.00, TRUE, '2026-07-01', '2026-07-12',
        (SELECT id FROM clientes WHERE cpf = '56789123482')),

    (750.00, FALSE, '2026-11-06', NULL,
        (SELECT id FROM clientes WHERE cpf = '67891234582')),

    (35.80, FALSE, '2026-11-07', NULL,
        (SELECT id FROM clientes WHERE cpf = '78912345664')),

    (180.00, TRUE, '2026-06-10', '2026-06-25',
        (SELECT id FROM clientes WHERE cpf = '78912345664')),

    (420.50, FALSE, '2026-11-08', NULL,
        (SELECT id FROM clientes WHERE cpf = '89123456728')),

    (65.90, FALSE, '2026-11-09', NULL,
        (SELECT id FROM clientes WHERE cpf = '91234567873')),

    (250.00, TRUE, '2026-05-15', '2026-05-30',
        (SELECT id FROM clientes WHERE cpf = '91234567873')),

    (890.00, FALSE, '2026-11-10', NULL,
        (SELECT id FROM clientes WHERE cpf = '13579246828'));