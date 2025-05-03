# WebApplication1 - API REST com ASP.NET Core e SQLite

Este projeto é uma API Web criada com **ASP.NET Core** e **Entity Framework Core**, utilizando **SQLite** como banco de dados local (volátil), ideal para fins de prototipagem, testes de conceito e aprendizado.

O projeto está estruturado com foco em aplicações de **Machine Learning**, **Predição de Dados**, e também preparado para futura **integração com serviços em nuvem** como **AWS**, **Microsoft Azure B2C (autenticação)**, entre outros.

---

## 🧠 Finalidade

- Armazenamento de dados de sensores (temperatura e tensão por célula)
- Treinamento futuro de modelos de predição (ML/IA)
- Possível uso de modelos hospedados em nuvem
- Testes de autenticação e autorização com provedores externos (ex: Azure B2C)

---

## 🗂️ Estrutura de Diretórios

```

```
WebApplication1/
│
├── Controllers/           # Controladores da API (endpoints HTTP)
│   ├── TemperaturaController.cs
│   └── TensaoCellController.cs
│
├── Data/                  # Classe de contexto do banco de dados
│   └── AppDbContext.cs
│
├── Models/                # Modelos que representam a estrutura das tabelas
│   ├── TemperaturaSensor.cs
│   └── TensaoCell.cs
│
├── Properties/            # launchSettings.json (configuração de portas)
│
├── Migrations/            # Gerado automaticamente pelo EF Core
│
├── appsettings.json       # Configuração do banco de dados SQLite
├── Program.cs             # Inicialização do app, configuração de serviços
├── WebApplication1.csproj # Projeto .NET
└── README.md              # Este arquivo
```

```

---

## 💾 Banco de Dados

- 💽 Utiliza **SQLite**, armazenado localmente como `temperaturas.db`
- ⚙️ Gerenciado pelo **Entity Framework Core**
- 🧩 Migrações versionadas para controle de mudanças no esquema

---

## 🧪 Endpoints disponíveis (via Swagger)

- `GET /Temperatura` → Lista os dados de temperatura
- `POST /Temperatura` → Insere um novo registro de sensores de temperatura
- `GET /TensaoCell` → Lista os dados de tensão por célula
- `POST /TensaoCell` → Insere novo registro de tensões

### Swagger UI:

```
http://localhost:5203/swagger
```

---

## 🔒 Integração futura com autenticação (Azure B2C)

Este projeto pode ser estendido para:

- Autenticação de usuários com **Microsoft Azure B2C**
- Controle de acesso por **token JWT**
- Autorização por perfis de acesso (ex: admin, user)

---

## ☁️ Integração futura com IA e Nuvem

- Integração com **AWS Lambda** ou **Azure Functions** para análise em tempo real
- Treinamento offline e consumo de **modelos de ML treinados**
- Suporte a **APIs de IA** como Azure Machine Learning, Amazon SageMaker ou modelos locais (.onnx)

---

## 🛠️ Comandos úteis

### Criar nova migration:

```
dotnet ef migrations add NomeDaMigration
```

### Aplicar ao banco:

```
dotnet ef database update
```

### Rodar o projeto:

```
dotnet run
```

---

## 📌 Requisitos

- [.NET 7 SDK ou superior](https://dotnet.microsoft.com/)
- Visual Studio 2022 com workload "ASP.NET e desenvolvimento web"
- EF Core CLI (instalado com `dotnet tool install --global dotnet-ef`)

---

## 📬 Contribuição

Fique à vontade para clonar este repositório, testar localmente e sugerir melhorias! Ideal para estudo e protótipos de sistemas embarcados, IA e IoT.

---

## 🧑‍💻 Autor

Vinicius Moreira — 2025
