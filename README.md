# API de Gestão de Tarefas

Esta é uma API RESTful para gerenciar tarefas, desenvolvida com .NET 8.

## Funcionalidades

* Criar, listar, atualizar e remover tarefas.
* Cada tarefa possui: Id, título, descrição, status (Pendente, Em andamento, Concluído) e data de vencimento.

## Requisitos Técnicos

* .NET 8 SDK instalado.
* Um editor de código (como Visual Studio Code ou Visual Studio).

## Como Rodar a Aplicação

1.  **Clonar o repositório (se aplicável):**
    ```bash
    git clone [https://docs.github.com/articles/referencing-and-citing-content](https://docs.github.com/articles/referencing-and-citing-content)
    cd [nome do seu projeto]
    ```

2.  **Navegar até o diretório do projeto:**
    ```bash
    cd [nome do seu projeto]
    ```

3.  **Restaurar as dependências:**
    ```bash
    dotnet restore
    ```

4.  **Executar a aplicação:**
    ```bash
    dotnet run
    ```

    Você verá uma mensagem indicando a porta em que a aplicação está rodando (geralmente `https://localhost:xxxx`).

## Acessando a Documentação da API (Swagger UI)

Após a aplicação estar rodando, você pode acessar a documentação interativa da API através do Swagger UI no seu navegador, no seguinte endereço:

    https://localhost:[porta]/swagger

Substitua `[porta]` pela porta em que a sua aplicação está sendo executada.

## Utilizando a API

Você pode interagir com os endpoints da API utilizando ferramentas como Postman, Insomnia ou `curl`.

* **GET `/api/Tarefas/pesquisar/tudo`**: Lista todas as tarefas.
* **GET `/api/Tarefas/pesquisar/por/id/{id}`**: Obtém uma tarefa específica pelo ID.
* **POST `/api/Tarefas`**: Cria uma nova tarefa (envie um objeto JSON no corpo da requisição).
* **PUT `/api/Tarefas/{id}`**: Atualiza uma tarefa existente (envie um objeto JSON no corpo da requisição).
* **DELETE `/api/Tarefas/{id}`**: Remove uma tarefa pelo ID.

## Próximos Passos (Opcional)

* Implementar testes unitários e de integração.
* Configurar um banco de dados real (como SQL Server ou PostgreSQL).
* Adicionar autenticação e autorização.
* Melhorar a validação dos dados de entrada.

