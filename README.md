# 🛒 Vendinha
Sistema de Gerenciamento de clientes e dívidas desenvolvido como projeto final da disciplina de Plataforma de desenvolvimento de sistemas, ministrada pelo Professor Rodrigo Rodrigues.

## 📋 Sobre o projeto
Gerenciar clientes e suas dívidas por meio de um sistema de interface gráfica.


## 🚀 Funcionalidades

### 👤 Gerenciamento de clientes
- Cadastrar novos clientes.

- Consultar clientes cadastrados.

- Editar informações dos clientes.

- Excluir clientes que não possuem dívidas.

- Pesquisar clientes.

- Paginação de registros, exibindo até 10 registros por página.

- Validar os dados informados.

### 💰 Gerenciamento de dívidas
- Cadastrar dívidas de clientes.

- Consultar dívidas cadastradas.

- Registrar o pagamento de dívidas.

- Armazenar a data de criação e de pagamento.

- Impedir que um cliente possua mais de uma dívida ativa.


## 🛠️ Tecnologias utilizadas
- ![C#](https://img.shields.io/badge/C%23-512BD4?style=flat&logo=csharp&logoColor=white) — Linguagem de programação.
- ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white) — Plataforma de desenvolvimento.
- ![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D4?style=flat&logo=windows&logoColor=white)  — Interface gráfica.
- ![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=flat&logo=dotnet&logoColor=white) — ORM para acesso ao banco de dados.
- ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=flat&logo=postgresql&logoColor=white) — Banco de dados relacional.
- ![Npgsql](https://img.shields.io/badge/Npgsql-336791?style=flat&logo=postgresql&logoColor=white) — Provedor de conexão com PostgreSQL.
- ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)  — Ambiente de desenvolvimento.
- ![Git](https://img.shields.io/badge/Git-F05032?style=flat&logo=git&logoColor=white) — Controle de versão.
- ![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github&logoColor=white) — Hospedagem do repositório.

## 📁 Estrutura do projeto

## ⚙️ Configuração do ambiente
⚙️ Configuração do ambiente

1. Clone o repositório.

2. Abra a solução no Visual Studio.

3. Instale ou restaure os pacotes NuGet necessários.

4. Crie o banco de dados PostgreSQL chamado vendinha.

5. Execute o script SQL disponibilizado no repositório.
    - Os scripts foram separados em 3 arquivos, execute-os na sequência 1 a 1 para evitar erros no postgre

6. Configure o arquivo .env com a conexão do seu banco de dados.
    - Ex:VENDINHA_CONEXAO=Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=SUA_SENHA_AQUI

7. Compile e execute o projeto.

Observação: O arquivo .env NÂO FOI disponibilizado no repositório por questões de segurança. Cada usuário deverá criar seu próprio arquivo com as configurações locais. Veja o exemplo de conexão no ítem 6 acima trocando apenas a senha


## 🎓 Finalidade
Projeto desenvolvido com fins acadêmicos com o fim de aplicar os conceitos aprendidos na disciplina de Plataforma de Desenvolvimento de sistemas como:
- Poogramação Orientada a objetos
- CRUD
- Validação de Dados
- ORM
- Integração entre a linguagem C# e PostgreSQL
- Desenvolvimento de interfaces gráficas

## 📸 Capturas de tela
![Tela Principal](CapturasDeTela/TelaPrincipal.png)

![Tela de Clientes](CapturasDeTela/TelaClientes.png)

![Tela de dívidas](CapturasDeTela/TelaDividas.png)

![Exemplo de Mensagem de Erro](CapturasDeTela/ExemploDeErro01.png)

![Exemplo de Mensagem de Erro](CapturasDeTela/ExemploDeErro02.png)

![Exemplo de Mensagem de Erro](CapturasDeTela/ExemploDeErro03.png)

## 👨‍💻 Autor

**Jonathan Ishida Biazollo**

Bacharelado em Ciência da Computação — UNIMAR.