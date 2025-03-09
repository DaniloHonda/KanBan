# 📌 KanBan

Este é um projeto de um sistema de Kanban simples e funcional, desenvolvido em **.NET** seguindo o padrão **MVC** e **Repository Pattern**. O sistema permite a gestão de tarefas de forma intuitiva, possibilitando a criação, movimentação e exclusão de tarefas dentro de colunas organizadas.

## 🚀 Tecnologias Utilizadas

- **.NET**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **PostgreSQL**
- **Bootstrap** (para estilização da interface)

## 📥 Instalação

Siga os passos abaixo para instalar e rodar o projeto localmente:

### 1️⃣ Clone o Repositório
```bash
git clone https://github.com/DaniloHonda/KanBan.git
cd KanBan
```

### 2️⃣ Configure o Banco de Dados
Certifique-se de ter um banco **PostgreSQL** rodando e edite o arquivo `appsettings.json` para definir as configurações de conexão com o banco.

Depois, execute as migrações:
```bash
dotnet ef database update
```

### 3️⃣ Execute o Servidor
```bash
dotnet run
```

O sistema estará acessível em: [http://localhost:5000](http://localhost:5000)

## 📌 Uso

1. Acesse a interface web.
2. Adicione novas tarefas.
3. Arraste e solte as tarefas entre as colunas para organizar seu fluxo de trabalho.
4. Exclua tarefas quando necessário.

