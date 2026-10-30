--03:

--Tem que dropar primeiro a tabela dívidas pq ela clientes depende dela
DROP TABLE IF EXISTS dividas;

DROP TABLE IF EXISTS clientes;

--cliente pode ter de 0 à N dívidas
--dívida tem somente 1 e apenas 1 cliente
--portanto 1 --> N

CREATE TABLE clientes(
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(11) NOT NULL UNIQUE, --CHAR no postgree vai completar os números que faltarem com espaço, já oi varchar NÂO
	dataNascimento DATE NOT NULL,
	--idade			--NÃO CRIAR AQUI USAR A dataNascimento para calculcar no progama
	email VARCHAR(100) --APENAS VALIDAR SE INFORMADO
);

CREATE TABLE dividas(
	id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	valor NUMERIC(10, 2) NOT NULL,
	paga BOOL NOT NULL DEFAULT FALSE,
	dataCriacao DATE NOT NULL,
	dataPagamento DATE DEFAULT NULL,
	clienteId INT NOT NULL,

	FOREIGN KEY (clienteId)
	REFERENCES clientes(id)
);

--Os valores pré setados diretamente no banco, podem não estar validados
--Pois a validação como a regra do cpf será feita apenas no back
--CONFIRA ANTES DE MANDAR ESSES INSERTS NO PROJETO FINAL
INSERT INTO clientes
	(nome, cpf, dataNascimento, email)
VALUES
	('Jonathan', '00000000000', '1995-03-18', 'jonathan@email.com'),
	('Johnny', '11111111111', '1995-03-18', 'JHON@email.com'),
	('teste', '22222222222', '1995-03-18', 'teste@email.com');

INSERT INTO dividas
	(valor, paga, dataCriacao, dataPagamento, clienteId)
VALUES
	(12.35, TRUE, '2026-10-20', '2026-10-21', 1),
    (12.35, FALSE, '2026-10-20', NULL, 2),
    (12.35, FALSE, '2026-10-20', NULL, 3);

SELECT * FROM dividas;

SELECT * FROM clientes;

